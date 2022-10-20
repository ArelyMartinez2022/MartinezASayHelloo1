/* See https://aka.ms/new-console-template for more information
Arely Martinez 

October 18, 2022 11:25 AM

Say Hello #1

This program will ask the user for thier name 
then display "Good evening" then their name onto
the termial. After the user will be asked if they 
want to play again. If they respond with yes in any 
form it will replay. If they enter no then it will 
end the program. If they dont type in yes or no then 
"INVAILD RESPONSE TRY AGAIN!!" will be displayed on 
the terminal. (they will have to answer the question 
again)
*/
Console.WriteLine("Hello, World!");
Console.Clear();
bool playAgain = true;
while(playAgain){

    bool isConverted = true;
    bool isNumber; 
    

    Console.WriteLine("WHAT UR NAME? ");
    string name = Console.ReadLine();
    Console.WriteLine(" ");
    Console.WriteLine( "GOOD EVENING " + name );
    

    bool converted = true;
    while (converted){
        Console.WriteLine(" ");
        Console.WriteLine("Would you like to play again? Yes or No");
        string rePlay = Console.ReadLine();

        if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" || rePlay == "no"){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
            Console.WriteLine(" ");
        }
    } 
}