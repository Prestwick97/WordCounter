


# _WordCounter_

#### _A program that counts words, March 2020_

#### By _**Patrick S. Delaney**_

## Description

_This program will allow you to enter a sentence and a word. It then tells you how many times that word occurs in the sentence entered._

## Setup/Installation Requirements

* _Make sure you have C# and Microsoft's .NET installed on your computer. As well as a text editor of your choice._
* _Open your command terminal, navigate to the desktop directory: ```$ cd desktop```_
* _Clone the remote repository for this program: ```git clone https://github.com/Prestwick97/WordCounter.git```_
* _Navigate to the program's root directory and open the program in your text editor: ```cd WordCounter```  -->  ```code . ```_
    * NOTE: In /Models/WordCounter.cs there is a Dictionary file reference on line 12. As is, this contains an sbsolute path for Epicodus Computers. However, in order to implement to word check functionality you may change this path to adhere to your specific computer.
* _use the ```dotnet run``` command in your terminal to begin._


## Specs:
_Behavior: Program will only accept letters as input._
* Input: 3
  * 3 was chosen as simplist input to check behavior because it is a single digit number, and not a letter.
* Output: "Please only enter words consisting of letters into the program."

_Behavior: Program will check all words to verify if they are in the English dictionary._
* Input: asdfasfd
  * This input was chosen because it is not a word in the English dictionary.
* Output: false.

_Behavior: Program checks to see if there is any instance of a word in a sentence._
* Input: cat, the fat cat loves hats.
  * This input was chosen because the sentence has one instance of the word "cat" in a sentence.
* Output: true

_Behavior: Program differentiates between individual and 'nested' words._
* Input: cat, the man in the cathedral.
  * This input was chosen because "cathedral" contains the correct spelling for the word "cat", but that doesn't mean it contains the word: "cat".
* Output: 0  (0 instances of 'cat')

_Behavior: Program allows user to input both a word and a sentence. Then counts how many times that word appears in the sentence._
* Input: apple, the apple doesn't fall far from the apple tree.
  * I chose this input because the word "apple" appears in the inputted sented only twice, and in an easy to understand way.
* Output: 2




## Known Bugs

_At the moment, there are no known bugs._

## Support and contact details

_If you have any questions, comments, concerns, or suggestions, please contact me at prestwick97@gmail.com_

## Technologies Used

* _C#_
* _.NET_
* _VS code_
* _Command Terminal_

### License

* This application is licensed under the MIT open source license. *

Copyright (c) 2020 **_Patrick Delaney_**