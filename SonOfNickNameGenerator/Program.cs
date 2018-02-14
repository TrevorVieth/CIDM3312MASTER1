using System;


namespace SonOfNickNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nicknames = new string [10,2];

            //row 1, column 1
            nicknames[0,0] = "Dude";
            //row 1, column 2
            nicknames[0,1] = "Jones";

             //row 2, column 1
            nicknames[0,0] = "Snappy";
            //row 2, column 2
            nicknames[0,1] = "Firecracker";

            Console.WriteLine( "Please enter your name:");
            string name = Console.ReadLine();

            string[] nameparts = name.Split(new char[' ']);

            //[0] = "Trevor";
            //[1] = "Vieth";
            for(int i = 0; i < nameparts.Length; i++){
                Console.WriteLine(nameparts[1]);
            }

            //char[] nameparts = name.ToCharArray();

            for(int i = 0; i < nameparts.Length; i++){

            }
            /* 
            Console.WriteLine("Your Nickname is: ");

            Console.WriteLine("Hello World!");
            */
        }
    }
}


