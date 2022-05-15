using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{

    class Program
    {
        class Movie
        {
            string title;
            string raiting;
            string year;

            public Movie(string _title, string _raiting, string _year)
            {
                title = _title;
                raiting = _raiting;
                year = _year;

            }

            public string Title
            {
                get
                {
                    return title;
                }
            }
            public string Raiting
            {
                get
                {
                    return raiting;
                }
            }
            public string Year
            {
                get
                {
                    return year;
                }
            }
        }

        static void Main(string[] args)
        {
            List<Movie> myMovies = new List<Movie>();
            string[] moviesFromFile = GetDataFromFile();

            foreach(string line in moviesFromFile)
            {
                string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);

                myMovies.Add(newMovie);
            }
            foreach(Movie moveFromList in myMovies)
            {
                Console.WriteLine($"Title --> {moveFromList.Title}. Rating --> {moveFromList.Raiting}. Year --> {moveFromList.Year}");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }


        public static string[] GetDataFromFile()
        {
            string filePath = @"D:\visual_studio_failid\samples\fail movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
