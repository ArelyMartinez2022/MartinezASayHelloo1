// See https://aka.ms/new-console-template for more information
//Arely Martinez 
//October 18, 2022 11:25 AM
//This program will ask the user if 
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
    
    Console.WriteLine(" ");
    Console.WriteLine("Would you like to play again? Yes or No");
    string rePlay = Console.ReadLine();

    bool converted = true;
    while (converted){
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
            break;
        }
    } 
}