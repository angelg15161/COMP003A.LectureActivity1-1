/* 
 * Author: Angel Gomez 
 * Course: COMP-003A
 * Faculty: Jonathan Cruz 
 * Purpose: Basic console app 
 */
// namespace level 
namespace COMP003A.LectureActivity1
{
    // Main class level
    internal class Program
    {
        //main level
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string username = Console.ReadLine();   //Saves user's input as "username" 
            Console.WriteLine("Hello, "+ username +"! My Name is Angel Gomez.");
            Console.WriteLine("\n \n Here are 10 things about me:");
            Console.WriteLine("\t 1. I major in Mathematics.");
            Console.WriteLine("\t 2. I love creating art with any art media.");
            Console.WriteLine("\t 3. I like to play multiplayer video games.");
            Console.WriteLine("\t 4. My favorite mobile video game is Brawl Stars.");
            Console.WriteLine("\t 5. I like to watch most genres of Anime.");
            Console.WriteLine("\t 6. I like to listen to a variety of music genres.");
            Console.WriteLine("\t 7. I have never been outside of California.");
            Console.WriteLine("\t 8. I am taking COMP003A to learn how to program/code.");
            Console.WriteLine("\t 9. I have no previous knowledge of programming/coding.");
            Console.WriteLine("\t 10. I want to be a game developer.");
        }
    }
}
