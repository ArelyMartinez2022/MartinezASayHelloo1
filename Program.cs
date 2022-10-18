// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();
bool playAgain = true;
while(playAgain){

    Console.WriteLine("WHAT UR NAME? ");

    string name = Console.ReadLine();

    Console.WriteLine(" ");

    Console.WriteLine( "GOOD EVENING " + name );
    Console.WriteLine(" ");
    Console.WriteLine("Would you like to play again? Yes or No");
    string rePlay = Console.ReadLine();
    if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
        playAgain = true;
        Console.Clear();
        Console.WriteLine( "LETS PLAY AGAIN!!" );
        Console.WriteLine( " " );
    } 
    if(rePlay == "NO" || rePlay == "no"){
        playAgain = false;
         Console.WriteLine(" ");
        Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
    } 
}