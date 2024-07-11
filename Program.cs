using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
namespace LibraryApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

           
            var serviceProvider = new ServiceCollection()
                .AddLogging(configure => configure.AddSerilog())
                .BuildServiceProvider();

           
            var logger = serviceProvider.GetService<ILogger<Program>>();

            ILibrary library1 = new Library();
            try
            {
                IBook book1 = new Book("To Kill a Mockingbird", "Harper Lee", 9780061120084, 1960, 7);
                IBook book2 = new Book("1984", "George Orwell", 9780451524935, 1949, 5);
                IBook book3 = new Book("Pride and Prejudice", "Jane Austen", 9780141439518, 1813, 4);
                IBook book4 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 9780743273565, 1925, 6);
                IBook book5 = new Book("Moby-Dick", "Herman Melville", 9780142437247, 1851, 3);
                library1.Books = new List<IBook>();
                library1.AddBook(book1);
                library1.AddBook(book2);
                library1.AddBook(book3);
                library1.AddBook(book4);
                library1.AddBook(book5);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : "+ ex.Message);

            }
           
           
            int x,y,z,i=0;


            do
            {
                Console.WriteLine("\tMenu");
                Console.WriteLine("        ---------------");
                Console.WriteLine("\t1  View Library");
                Console.WriteLine("\t2. Checkout book");
                Console.WriteLine("\t3. Return book");
                Console.WriteLine("\t4. Exit");
                Console.WriteLine("---------------------------------------------------------");


                x = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (x)
                {
                    case 1:
                        foreach (var book in library1.Books)
                        {
                            Console.WriteLine(book);

                        }
                        Console.WriteLine("\n6. Back.");
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
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                           
                        } while ( i != 6);
                        Console.Clear();
                        break;
                    case 2:
                       
                            do
                            {
                                Console.WriteLine("\tMenu To Checkout book");
                                Console.WriteLine("        ---------------");
                                Console.WriteLine("\t1 To Kill a Mockingbird ");
                                Console.WriteLine("\t2.1984 ");
                                Console.WriteLine("\t3.Pride and Prejudice ");
                                Console.WriteLine("\t4.The Great Gatsby ");
                                Console.WriteLine("\t5 Moby-Dick");
                                Console.WriteLine("\t6 Back");
                                Console.WriteLine("---------------------------------------------------------");
                            y = Convert.ToInt32(Console.ReadLine());
                                switch (y)
                                {
                                    case 1:
                                    try {
                                        Console.Clear();
                                        logger.LogInformation("Checking book...");
                                        library1.CheckoutBook(9780061120084);

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                        case 2:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Checking book...");
                                        library1.CheckoutBook(9780451524935);



                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                        case 3:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Checking book...");
                                        library1.CheckoutBook(9780141439518);



                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                        case 4:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Checking book...");
                                        library1.CheckoutBook(9780743273565);



                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                        case 5:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Checking book...");
                                        library1.CheckoutBook(9780142437247);



                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("");
                                    break;
                                default:
                                        Console.WriteLine("Enter a valid command");
                                        break;
                                }

                            } while (y!=6);
                        Console.Clear();
                        break;
                    case 3:

                        do
                        {
                            Console.WriteLine("\tMenu TO Return book");
                            Console.WriteLine("        ---------------");
                            Console.WriteLine("\t1 To Kill a Mockingbird ");
                            Console.WriteLine("\t2.1984 ");
                            Console.WriteLine("\t3.Pride and Prejudice ");
                            Console.WriteLine("\t4.The Great Gatsby ");
                            Console.WriteLine("\t5 Moby-Dick");
                            Console.WriteLine("\t6 Back");
                            Console.WriteLine("---------------------------------------------------------");
                            z = Convert.ToInt32(Console.ReadLine());
                            switch (z)
                            {
                                case 1:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Returned book...");
                                        library1.ReturnBook(9780061120084);

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Book Returned...");
                                        library1.ReturnBook(9780451524935);



                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                case 3:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Book Returned...");
                                        library1.ReturnBook(9780141439518);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                case 4:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Book Returned...");
                                        library1.ReturnBook(9780743273565);



                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                case 5:
                                    try
                                    {
                                        Console.Clear();
                                        logger.LogInformation("Book Returned...");
                                        library1.ReturnBook(9780142437247);



                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);

                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("");
                                    break;
                                default:
                                    Console.WriteLine("Enter a valid command");
                                    break;
                            }

                        } while (z != 6);
                        Console.Clear();
                        break;
                        case 4:
                        Console.WriteLine("Thank you for visiting...!");
                        break;
                    default: Console.WriteLine("Enter a valid command");
                break;
                }
            } while (x != 4);


        }


    }
}