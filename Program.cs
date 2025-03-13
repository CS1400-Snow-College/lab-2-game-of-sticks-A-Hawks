using System.Numerics;

Console.Title = "Game of Sticks";

//1. Explain the rules of the game of sticks.
// Rules: Players will take turns choosing at least 1
//and no more than 3 of the remaining sticks until the sticks are gone. 
//The player who takes the last stick looses.
//2. Set the number of sticks left to 20
//3. Set the current player to be player 1. 
//a. Ask player 1 their name, ask player 2 their name.
//4. Set the maximum number of sticks that can be taken to be equal to 3. 
//5. If the number of sticks left is less than 3, then set the maximum number of sticks
// that can be taken  to be equal to the number of sticks left. 
//6. Ask the current player to choose a number of sticks beteen
// one and the maximum number of sticks that can be taken on this turn. 
//7. If the number of sticks chosen is not in the allowed range, print an error
//message and tehn go back to set 6; otherwise go on to step 8. 
//8. Decrease the number of sticks by the number of sticks chosen. 
//9. If the current player is player 1, set current player to be player 2; 
//otherwise set current player to be player 1. 
//10. If the number of sticks left is equal to 0, 
//then print that the current player won; otherwise, go back to step 4.
Console.WriteLine("Welcome to Sticks. Where you Picks your Sticks. Last stick loses.");
Console.Write("Rule 1. Take turns. " +
    "Rule 2. Each player chooses 1, 2, or 3 sticks on " +
    "their turn until the sticks are gone." +
    " Rule 3. Who picks the last stick loses.");

string name1;
Console.WriteLine("Player 1, please enter your name? ");
name1 = Console.ReadLine();

string name2;
Console.WriteLine("Player 2, please enter your name? ");
name2 = Console.ReadLine();

Console.WriteLine(name1 + " press any key when you're ready to begin.");
Console.ReadKey();

Console.WriteLine("Starting with 20 Sticks");

Console.WriteLine(name1 + ", How many sticks do you choose? 1, 2, or 3.");

//There is an if then loop here somewhere, or if while.... 
//string maxSticks 
// = Console.ReadLine();

//the player chooses 1, 2 or 3, which is subtracted from sticksLeft WE GONNA DECREMENT THE OPERATORS. 
//I also need to work on updating the variables.  ie: int leftSticks = 20 leftSticks=leftSticks - 1, 2, or 3. Same thing? 
//maxSticks is the most they can choose. 
//leftSticks is what they are pulling from 
//selectedSticks is the choice of the players
//Are these the variables or the ints? 
//Formatting is the least of my concerns. But the formatting isn't awesome. 
//sticksLeft< maxSticks True maxSticks =sticksLeft true then get sticks from player



