using System;

namespace ClassesAndObjects // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //You can create more constructor on here with arugments or no arguments. 

            Book book1 = new Book("Harry Potter", "JK Rowling", 400); //this should mirror book.cs file on line 32

                                    //create an object which is an instance of the book class.
                                    //I'm actually calling that constructor method on line 21 and line 32. These are directly link to this method Book() in Book.cs
                                    //So now it is going to call Mike and John because I'm calling that book contructor in Book.cs
                                    //Therefore not only does this call that constructor but from here, we can also pass parameters.
                                    //Next imageine we have to create 10-20 books and it would take a long time to go through and assign a title, a author, and a number of pages..etc
                                    //So there is another way we can use the constructor to do it. line 9 



            Console.WriteLine(book1.title);
            //Console.WriteLine(book1.author);
            //Console.WriteLine(book1.pages);

            //example
            Book book2 = new Book ("Lord Of the Rings", "Tolkein", 700); //this should mirror book.cs file on line 32

            Console.WriteLine(book2.title);
            //Console.WriteLine(book2.author);
            //Console.WriteLine(book2.pages);

            //so if you want, you can modify any of these values. 
            book2.title = "The Hobbit";
            Console.WriteLine(book2.title);


        }
    }
}

/*
Topic: What is Constructor?
A Constructor basically a special method that we can put inside of a C# class which is going to get called whenever we create an object of that class.
So anytime I create an object of a specific class, the constructor method will get called. And we can do different things.


 */