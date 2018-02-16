
# Word Counter
#### By Jasun Feddema

## Description
A webapp that tells you how many times a word appears in a piece of text.

## Specifications
* Take input from the user for a guideWord in a single string.
  - example input: "bird"
  - example output: "bird"

* Take input from the user for a textBase in a single string.
  - example input: "Bird-bird, bird. Bird isn't the Word."
  - example output: "Bird-bird, bird. Bird isn't the Word."
  - Note: I chose this as the example textBase string because:
    1. I want to differentiate between capital B bird and lowercase b bird.
    2. I want to be able to exclude punctuation and spaces like "," , " " , and "."
    3. I wanted hyphenated word combinations to be counted as their own word: "bird-bird" instead of "bird" and "bird".
    4. I want conjunctions to be counted as a word: "isn't" instead of "isn" and "t".

* Convert user guideWord into a char array in lowercase form.
  - example input: "Bird"
  - example output: array chars[] = {"b", "i", "r", "d"}
  - Note: This is the simplest way to test that a single string is being converted into a char[] because passing one word through is all that is needed to test this functionality.

* Convert user textBase string into char[] in lowercase form.
  - example input: "Bird-bird, bird."
  - example output: textBaseArray <"b", "i", "r","d","-","b","i","r", "d", ".", " ", "b", "i", "r", "d", ".">
  - Note: This is the simplest way to test this functionality because this phrase contains more than one word, contains a capital letter, and punctuation types that I will want to ignore or include later on(".", "-", ",", and " ").

* Breakdown user textBase char[] into a List of char[]s for each word unit, by excluding spaces and punctuation (except hyphens).
  - example input: textBaseArray <"b", "i", "r","d","-","b","i","r", "d", ".", " ", "b", "i", "r", "d", ".">
  - example output: List<char[]> textBaseListOfArrays = new List<char[]> {<"b","i","r","d","-","b","i","r","d">, "b", "i", "r", "d"}
  - Note: This is the simplest way to test this functionality because it contains:
    1. 2 words: a hyphenated word and a non-hyphenated word.
    2. Ignorable punctuation/characters: "", "," and ".".
    3. Included puntuation/characters: "-".

* Breakdown user textBase char[] into a List of char[]s for each word unit, by excluding spaces and punctuation (except apostrophes).
  - example user input: "Bird isn't the Word."
  - example input: textBaseArray <"b","i","r","d", "","i","s","n","'","t", "", "t","h","e", "", "w","o","r","d", ".">
  - example output: List<char[]> textBaseListOfArrays = new List<char[]> {<"b","i","r","d">, <"i","s","n","'","t">, <"t","h","e">, <"w","o","r","d">}
  - Note: This is the simplest way to test this functionality because it contains:
    1. More than 2 words.
    2. Ignorable punctuation/characters: ".".
    3. Included puntuation/characters: "'".

* Compare user guideWordArray each array in the textBaseListOfArrays and output a count of each time they match.
  - example guideWord input: "bird"
  - example textBase input: "Bird-bird, bird. Bird isn't the Word."
  - example Output: number of times they match = 2.
  - Note: This is the simplest way to test this functionality because it contains:
     - 2 instances of the guideWord:
        1. One instance beginning with a capital letter
        2. One instance beginning with a lower case letter

* Return result to user.
  - example guideWord input: "Bird"
  - example textBase input: "Bird-bird, bird. Bird isn't the Word."
  - example Output: " "Bird" occurs 2 times in the following piece of text:  "Bird-bird, bird. Bird isn't the Word." "

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/jaybojaybojaybo/WordCounter-Epicodus'.
* Run the command 'dotnet restore' in the WordCounter folder to download the necessary packages.
* While still in the WordCounter folder, run the command 'dotnet run' to build and run the server on localhost.
* Use your preferred web browser to navigate to localhost:5000
* Follow instructions on webpage for the Word Counter experience.


## Support and contact details

* contact the author at jasun.feddema@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Jasun Feddema

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
