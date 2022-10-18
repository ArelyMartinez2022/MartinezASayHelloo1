// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();
bool playAgain = true;
while(playAgain){

    bool isConverted = true;
    bool isNumber; 
    
    while (isConverted){
        Console.WriteLine("WHAT UR NAME? ");
        string name = Console.ReadLine();
        Console.WriteLine(" ");

        isNumber = Int64.TryParse(userInput, out vaildNum);

        if(isNumber == true) {
            isConverted = false;
            Console.WriteLine("You Entered A Number ");
        } else {
            Console.WriteLine( " " );
            Console.WriteLine("Invaild entry, please try again ");
        }
    }

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