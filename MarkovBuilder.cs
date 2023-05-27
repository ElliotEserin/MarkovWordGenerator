using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov
{
    public class MarkovBuilder
    {
        string trainingData = string.Empty;
        int ngram = 2;
        bool includeWordEndings = true;
        bool caseSensitive = false;
        bool includeSymbols = false;

        public MarkovBuilder UsingData(string trainingData)
        {
            this.trainingData += " " + trainingData;
            return this;
        }

        public MarkovBuilder WithNgram(int ngram)
        {
            this.ngram = ngram;
            return this;
        }

        public MarkovBuilder UsingWordEndings(bool on)
        {
            includeWordEndings = on;
            return this;
        }

        public MarkovBuilder UsingCaseSensitivity(bool on)
        {
            includeWordEndings = on;
            return this;
        }

        public MarkovBuilder UsingSymbols(bool on)
        {
            includeSymbols = on;
            return this;
        }

        public WordGenerator Build()
        {
            if(string.IsNullOrEmpty(trainingData))
            {
                throw new EmptyTrainingDataException("Training data is a required property");
            }

            return new WordGenerator(trainingData, ngram, includeWordEndings, caseSensitive, includeSymbols);
        }

        public class EmptyTrainingDataException : Exception
        {
            public EmptyTrainingDataException()
            {

            }

            public EmptyTrainingDataException(string message) : base(message)
            {

            }
        }
    }
}
