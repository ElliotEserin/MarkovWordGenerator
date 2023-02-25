# Procedural Word Generator
This Procedural Word Generator is a C# algorithm that uses Markov Chains to generate random words based on a given set of training data. The program takes in several parameters to customize the generated words, including the n-gram size, whether or not to include word endings, whether or not to include symbols, and whether or not to be case sensitive.

With a training set of a list of Dinosaurs, it might generate the output:
 - yaningshan
 - ksosaurus
 - gjia
 - yptops
 - edrosaurus
 
 Which are made up words that follow the same rules that dinosaur names follow.

## Installation
To use the Procedural Word Generator, you'll need to have the following installed:

 - [**.NET Core SDK**](https://dotnet.microsoft.com/en-us/download)

Once you have the .NET Core SDK installed, you can clone this repository and build the program using the following commands:

```
git clone https://github.com/ElliotEserin/MarkovWordGenerator.git
cd MarkovWordGenerator
dotnet build
```

Whilst the project contains a demo, it is intended to be used as part of larger projects with custom datasets.

## Usage
To generate procedural words using the program, you'll need to provide a set of training data in the form of a string or string array. Here's an example of how to use the program:

```
using Markov;

string[] trainingData = new string[]
{
    "hello",
    "world",
    "foo",
    "bar",
    "baz",
    "qux"
};

int ngram = 2;
bool includeWordEndings = true;
bool caseSensitive = false;
bool includeSymbols = false;

int characterLimit = 10;

WordGenerator wordGenerator = new WordGenerator(trainingData, ngram, includeWordEndings, caseSensitive, includeSymbols);
string generatedWord = wordGenerator.GenerateWord(characterLimit);
Console.WriteLine(generatedWord); // Output: "quxbaz"
```
In this example, we're using a set of six words as our training data. We're using a 2-gram size, meaning that the program will generate words by looking at pairs of letters in the training data. We're including word endings in the generated words, but not symbols. We're also not being case sensitive, so the program will treat "Foo" and "foo" as the same word.

## License
This program is licensed under the [**MIT License.**](https://opensource.org/license/mit/)
