using System;
using System.Collections.Generic;
using System.Threading;


namespace catboy_generator
{
    class Catboy
    {
        Random rd = new Random();
        public string name;
        public string lastName;
        public string favoriteFace;
        public string favoriteActivity;
        public int age;

        string[] names = {"Felix", "Geezosh", "Rakosh","Nagisa", "Lucifer", "Kumiko", "Jiro", "Legion", "King", "Neil", "Thomas", "Blaze", "Killers", "Thomas", "Budgie", "Bagguete"};
        string[] lastnames = {"Haruki", "Siechas", "Tamae", "Kesonmaa", "Budgie", "Stirskey", "Getu", "Aoi", "Miu", "Dream", "Ruzi", "Usagi"};
        string[] faces = {"owo", "uwu", ">w<", "^w^", ">^w^<", "OwO", "UwU", "-w-", "UMU", "oMo", ":3", "x3"};
        string[] activities = {"head pats", "sex", "saying meow", "being a good girl", "watching anime", "cbt", "playing among us"};
        

        public Catboy()
        {
            name = (names[rd.Next(0, names.Length)]);
            lastName = (lastnames[rd.Next(0, lastnames.Length)]);
            favoriteFace = (faces[rd.Next(0, faces.Length)]);
            favoriteActivity = (activities[rd.Next(0, activities.Length)]);
            age = rd.Next(16, 31);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Catboy Generator";
            ConsoleKeyInfo cki;
            Console.TreatControlCAsInput = true;

            Console.WriteLine("HIII!!! welcome to the catboy generator, press any key to generate a catboy\n----------");
            cki = Console.ReadKey();
            loop: while (cki.Key == ConsoleKey.Enter) 
            {
                Catboy catboy01 = new Catboy();
                Console.WriteLine("name: " + catboy01.name + " " + catboy01.lastName);
                Console.WriteLine("age: " + catboy01.age);
                Console.WriteLine("introduction: hewwo rawr, my name is " + catboy01.name + " " + catboy01.lastName + " " + catboy01.favoriteFace + " i really love " + catboy01.favoriteActivity);
                Console.WriteLine("----------");
                Thread.Sleep(500);
                cki = Console.ReadKey();
            }
            goto loop;
        }
    }
}   

