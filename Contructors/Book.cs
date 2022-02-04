using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Book
    {
        //you'll going to get it a series of attributes what it is...
        //what are the different attributes of a book?

        public string title; //this is one attribute of a book
        public string author;
        public int pages;

        //basically heses are attributes of a book. so this is a specification template.
        //So now I can ceate a book inside of my program. Go back to your Program.cs file.

        //Next we can create something called an object, which is going to be a actual book inside of our program. Now go back to your Program.cs file.


        //Topic: Constructor
        //This us what's called a constructor. So anytime I make a method like where I'm saying public, and then the name of the class, this means that this is going to be the constructor for this class.
        //and I like I told you guys before, the constructor is basically a special method inside of our class, that's going to get called when we create an object of this class.
        

        //so when they create the book, I want them to be able to tell me what the title is going to be, what the author is going to be and what the number of pages is going to be. 
        //that way, they can just tell me right away, and I can handle it up front. And I don't have to say like book.1 title is qual to whatever book etc..
        //so this book constructor will take 3 constructors. What is happening is whenever we create a book, we need to pass in the title, the author, and pages.
        public Book(string aTitle, string aAuthor, int aPages) //you can name whatever you want. i'm using aTitle, aAuthor, and aPages to show the parameters that are passed in. 
        {   
            //book1.title = //this is the same exact thing like line 35
            //so we want to do this for each attributes.
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}

/*

 this is a blueprint for our data type. 

 */