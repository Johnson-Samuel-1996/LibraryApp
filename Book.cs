using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp
{
    public class Book : Library, IBook
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public double ISBN { get; set; }
        public int PublicationYear { get; set; }
        public int AvailableCopies { get; set; }
        public void CheckoutCopies()
        {
            int i = 0;
            if (AvailableCopies == 0)
            {
                throw new Exception("No copies available");
            }
            AvailableCopies--;

            Console.WriteLine($"\nBook {this.Title} is Sussefully Checkedout.!");
            Console.WriteLine($"\nAvailable copies for the book {this.Title} : {this.AvailableCopies}");
            Console.WriteLine($"\nDue date [{DateTime.Now.AddDays(MaxCheckoutDays)}]");
            Console.WriteLine("\n6.Back .");
            do
            {

                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i != 6)
                    {
                        Console.WriteLine("Enter valid command...!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (i != 6);
            Console.Clear();

        }
        public void ReturnCopies()
        {
            int i = 0;
            AvailableCopies++;
            Console.WriteLine($"\nBook {this.Title} is Sussefully Returned.!");
            Console.WriteLine($"Available copies for the book {this.Title} : {this.AvailableCopies}");
            Console.WriteLine("\n6.Back .");
            do
            {

                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i != 6)
                    {
                        Console.WriteLine("Enter valid command...!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (i != 6);
            Console.Clear();

        }
        public override string ToString()
        {
            return $"\t\n### Title : {Title}\n   ISBN NO : {ISBN}\n   Year : {PublicationYear}      \n   Available Copies : {AvailableCopies}\n--------------------------------------------------------------------------------------------";
        }

        public Book(string title, string author, double isbn, int publicationYear, int availableCopies)
        {
            if (isbn.ToString().Length != 13)
            {
                throw new Exception("ISBN number has to be 13 digit number");

            }
            if (publicationYear > DateTime.Now.Year || publicationYear <= 0)
            {
                throw new Exception("Enter a Valid publication year in the past..!");
            }

            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            AvailableCopies = availableCopies;

        }
    }
}

