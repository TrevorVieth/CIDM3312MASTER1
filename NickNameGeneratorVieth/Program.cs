
using System;
using System.Text ;
using System.IO;
using System.Reflection;

namespace NickNameGeneratorVieth
{
    class Program
    {
        static void Main(string[] args)
        {

            //string path = @"c:\code\Names.txt";
            //string path = @"C:\Users\Trevor\Desktop\WT stuff\Code\NickNameGeneratorVieth\NameList.txt";
            string path = "NameList.txt";
                
            Console.WriteLine("{Possible names}");
            string[] fileReadText = File.ReadAllLines(path);
            foreach (string s in fileReadText)
                {
                     //numberList += i + " "
                 Console.WriteLine(s);
                }
            
                     //string names = File.ReadLines(filename);
            
            Console.WriteLine();
            Console.WriteLine( "Please enter your name:");
            string inputname = Console.ReadLine();
//Has to be 4 characters or it says destination array is not long enough?
                     
                     //Console.WriteLine(inputname[5]);
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(inputname);
            int ASCIIValuesINT = BitConverter.ToInt32(ASCIIValues, 0);
                     Console.WriteLine(ASCIIValuesINT);
//Only goes to 10 digits?

            Random rand1 = new Random((int) ASCIIValuesINT);
            int randomNumber = rand1.Next(0, 10);
                     //string RandomName = rand1 (0,sizeof(fileRead)-1);
            Console.WriteLine("Seeded random number: " + randomNumber);

            string generatedName;
            generatedName = fileReadText[randomNumber];
            Console.WriteLine("Your generated nickname is : " + generatedName);
           






            //foreach(char c in inputname)
            //{   
           //  Console.WriteLine((int)c);
          //  }
       

           // string[] nameparts = inputname.Split(new char[' ']);
            
            //char character;
            //character = Char.Parse(Console.ReadLine());
            //    Console.WriteLine((int)character);

            //[0] = "Trevor";
            //[1] = "Vieth";
           // for(int i = 0; i < nameparts.Length; i++){
               // Console.WriteLine(nameparts[1]);
            //}

            //char[] nameparts = name.ToCharArray();

            //for(int i = 0; i < nameparts.Length; i++){

            //}
            /* 
            Console.WriteLine("Your Nickname is: ");

            Console.WriteLine("Hello World!");
            */
        }
    }
}
