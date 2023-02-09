using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Markov
{
    /// <summary>
    /// <c>WordGenerator</c> can be used to generate random words using a Markov chain.
    /// This model is calculated from a provided training set of space seperated words you woud like to mimic.
    /// See https://en.wikipedia.org/wiki/Markov_chain for more information.
    /// This code is also heavily inspired by the concepts explained in this playlist by "Normalized Nerd" on YouTube: https://www.youtube.com/watch?v=i3AkTO9HLXo&list=PLM8wYQRetTxBkdvBtz-gw8b9lcVkdXQKV
    /// </summary>
    public class WordGenerator
    {
        #region properties
        private Dictionary<string, Dictionary<string, float>> model;

        public Dictionary<string, Dictionary<string, float>> Model { get => model; }
        public int ngram;
        #endregion

        #region constructors and factories
        /// <summary>
        /// This will generate an object with a Markov model based off of a provided <paramref name="trainingData"/>.
        /// </summary>
        /// <param name="trainingData">space separated list of words to use as training for the model</param>
        /// <param name="ngram">the number of characters included in each state. A lower ngram will produce more randomnes</param>
        /// <param name="caseSensitive">if true, the model will consider "a" and "A" as two different characters with different probabilities of occurring</param>
        /// <param name="includeSymbols">if true, symbols (.?!,'" etc.) will be included in the model</param>
        public WordGenerator(string trainingData, int ngram = 2, bool caseSensitive = false, bool includeSymbols = false)
        {
            this.ngram = ngram;
            model = new();
            GenerateModel(trainingData, ngram, caseSensitive, includeSymbols);
        }
        /// <summary>
        /// This will generate an object with a Markov model based off of a provided <paramref name="trainingData"/>.
        /// </summary>
        /// <param name="trainingData">space separated list of words to use as training for the model</param>
        /// <param name="ngram">the number of characters included in each state. A lower ngram will produce more randomnes</param>
        /// <param name="caseSensitive">if true, the model will consider "a" and "A" as two different characters with different probabilities of occurring</param>
        /// <param name="includeSymbols">if true, symbols (.?!,'" etc.) will be included in the model</param>
        public static WordGenerator ModelFromTrainingData(string trainingData, int ngram = 2, bool caseSensitive = false, bool includeSymbols = false)
        {
            return new WordGenerator(trainingData, ngram, caseSensitive, includeSymbols);
        }
        #endregion

        #region generating markov model
        public void GenerateModel(string trainingData, int ngram = 2, bool caseSensitive = false, bool includeSymbols = false)
        {
            this.ngram = ngram;

            if(string.IsNullOrEmpty(trainingData) || trainingData.Length < ngram * 2)
            {
                throw new ArgumentException("The training data provided is not suitable.");
            }

            var cleanedText = CleanText(trainingData, caseSensitive, includeSymbols);

            GenerateMarkovModel(cleanedText);
        }
        /// <summary>
        /// This is for filtering out any unwanted characters and formatting the text correctly
        /// </summary>
        /// <param name="trainingData"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="includeSymbols"></param>
        /// <returns>formatted words split into char arrays</returns>
        char[][] CleanText(string trainingData, bool caseSensitive, bool includeSymbols)
        {
            List<char[]> cleanedText = new();

            var splitText = trainingData.Split(' ');

            foreach (var word in splitText)
            {
                string cleanedWord = word;

                if (!caseSensitive)
                    cleanedWord = cleanedWord.ToLower();

                if (!includeSymbols)
                {
                    var pattern = @"[^0-9a-zA-Z]+";
                    cleanedWord = Regex.Replace(cleanedWord, pattern, "");
                }
                char[] tokens = cleanedWord.ToCharArray();

                cleanedText.Add(tokens);
            }

            return cleanedText.ToArray();
        }
        /// <summary>
        /// Calculates the probability that any next charater(s) will proceed the current character(s)
        /// </summary>
        /// <param name="wordsAs2DCharArray"></param>
        void GenerateMarkovModel(char[][] wordsAs2DCharArray)
        {
            Dictionary<string, Dictionary<string, float>> model = new();

            for (int i = 0; i < wordsAs2DCharArray.Length; i++)
            {
                for (int j = 0; j < wordsAs2DCharArray[i].Length - ngram - (ngram - 1); j++)
                {
                    string currentState = "", nextState = "";

                    for (int k = 0; k < ngram; k++)
                    {
                        currentState += wordsAs2DCharArray[i][j + k];
                        nextState += wordsAs2DCharArray[i][j + k + ngram];
                    }

                    if (!model.ContainsKey(currentState))
                    {
                        model[currentState] = new()
                        {
                            [nextState] = 1
                        };
                    }
                    else
                    {
                        if (model[currentState].ContainsKey(nextState))
                        {
                            model[currentState][nextState] += 1;
                        }
                        else
                        {
                            model[currentState][nextState] = 1;
                        }
                    }
                }
            }

            var copy = model.ToDictionary(entry => entry.Key, entry => entry.Value.ToDictionary(entry => entry.Key, entry => entry.Value));

            foreach (var pair in model)
            {
                int total = (int)Enumerable.Sum(pair.Value.Values);

                foreach (var pair2 in pair.Value)
                {
                    copy[pair.Key][pair2.Key] = pair2.Value / total;
                }
            }

            this.model = copy;
        }
        #endregion

        #region public methods
        public string GenerateWord(int characterLimit)
        {
            //no Random object is passed in, create our own
            Random rand = new();

            return GenerateWord(characterLimit, rand);
        }
        public string GenerateWord(int characterLimit, int seed)
        {
            //no Random object is passed in, create our own
            Random rand = new(seed);

            return GenerateWord(characterLimit, rand);
        }
        public string GenerateWord(int characterLimit, Random rand)
        {
            string start = GenerateStartingCharacters(rand);

            return GenerateWord(characterLimit, rand, start);
        }
        /// <summary>
        /// This is less advised as <paramref name="start"/> must be a current state in the model to work
        /// </summary>
        /// <param name="characterLimit"></param>
        /// <param name="rand"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public string GenerateWord(int characterLimit, Random rand, string start)
        {
            //easiest explained with an example: an ngram of 2 will result in each iteration adding 2 new characters
            //so we need to divide the character limit by the number of characters added per iteration to know how many to do.
            //this will automatically truncate it down
            var iterations = characterLimit / ngram;

            //if character limit is less than the number of characters added per iteration (ngram) then you will get no iterations, and no result. So we throw an error.
            if (iterations <= 0)
            {
                throw new ArgumentException($"characterLimit must be at least equal to ngram: {ngram}");
            }

            int n = 0;

            string currentState = start;
            string nextState = "";

            string name = "";

            name += currentState;

            if (!model.ContainsKey(currentState))
            {
                throw new ArgumentException($"the starting state must be in the model. (start state was {currentState})");
            }

            while (n < iterations)
            {
                //Finish if we meet a state that has no possible next states
                if (!model.ContainsKey(currentState))
                {
                    return name;
                }

                float probability = (float)rand.NextDouble();

                foreach (var state in model[currentState])
                {
                    probability -= state.Value;

                    if (probability < state.Value)
                    {
                        nextState = state.Key;
                        break;
                    }
                }

                currentState = nextState;
                name += currentState;

                n++;
            }

            return name;
        }
        #endregion

        #region private methods
        string GenerateStartingCharacters(Random rand)
        {
            return model.ElementAt(rand.Next(0, model.Count)).Key;
        }
        #endregion
    }
}