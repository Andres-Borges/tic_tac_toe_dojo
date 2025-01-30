# Tic-Tac-Toe Dojo
### Be the Tic-Tac-Toe Champion of Japan!


![logo_with_bg](https://github.com/user-attachments/assets/c96eaa0e-778e-44e5-98da-8255639ca1ee)

## About
*Tic-Tac-Toe Dojo* is a collaborative project created by *Sleepy Owl Games*. It is a tournament type game where players choose from an arrangement of characters and dispute in Tic-Tac-Toe matches for a chance to be crowned the ultimate champion. It utilizes Computer Science fundamentals such as Polymorphism and Inheritance to create a cleaner and reusable code, allowing for easy expansion of content if needed!

## How it works
The game works by allowing players to choose one out of four possible characters, which will be their chosen champion. All the non-selected characters will be the player's opponents during the tournament.

![characterSelect](https://github.com/user-attachments/assets/4735e370-bfb7-4d6c-94b1-0fa9d49b1ab5)
*Screenshot of the [Character Selection Page](TicTacToeDojo/Form2.cs)*

Each character has two hearts, and is defeated once all their hearts have been used. Hearts are lost by losing a Tic-Tac-Toe match. Every win adds to the player's final score. The game ends once only one character is standing (the player) or if the player is defeated!

![gameplay](https://github.com/user-attachments/assets/fd0dac1f-c7e3-42d3-894a-370f3c846ff3)
*Screenshot of the [Gameplay](TicTacToeDojo/Form3.cs)*

## Built with

* C#
* Windows Form

## Characters
Each character is an object of the [Champion class](TicTacToesClasses/Champion.cs).
The character which the player selects becomes a object of the [Player Class](TicTacToesClasses/Player.cs) that inherits from the base class Champion.
