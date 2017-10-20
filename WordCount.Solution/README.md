# Word Counter
##### By Adam Titus

### Description
This program will take a user inputed sentence and a word, and will tell you how many times that word appears in the sentence.

### Installation Instructions
* Copy the url for this repository
* Open your Shell program of choice, such as git bash or Terminal.
* Navigate with your shell to the location you would like to save this project.
* Once there, type the command `git clone` then paste the url you copied and hit enter.
* Now navigate to this folder you cloned by typing `cd Word-Counter/WordCount.Solution/WordCount`
* Once in, type in your shell `dotnet restore` and wait for files to be decompressed and loaded.
* Once finished, type `dotnet run`.
* Open your web browser now, and navigate to http://localhost:5000/

### Technology Required
* ASP.Net 1.1
* Code Text Editor
* Shell program like git bash or Terminal
* Browser with internet connection
* GitHub

### Specs
|Behavior|Input|Output|
|-|-|-|
|Will accept single words|hello|hello|
|Will count a single word| hello| 1|
|Will Count multiple words| hello there| 2|
|Will match single words| hello| 1|
|Will match a single word in a sentence| hello there hello| 1|
|Will match multiple words in a sentence| hello there hello| 2|
|Will ignore punctuation| hello! there... hello?| 2|

### Contact Information
You can reach me at adamtitus76@gmail.com or connect with me on linkedin at [www.linkedin.com/in/adam-titus-06740b149](www.linkedin.com/in/adam-titus-06740b149).

#### Legal
Licensed under the MIT License
Copyright (c) 2017 Adam Titus All Rights Reserved.

_If you find a way to monetize this pleas contact the author_
