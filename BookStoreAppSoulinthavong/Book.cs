using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAppSoulinthavong
{
    /***************************************************************
    * Name        : FINAL PROJECT: BookStoreAppSoulinthavong
    * Author      : Jake Soulinthavong
    * Created     : 04/27/2023
    ***************************************************************/
    public class Book
    {
        /**************************************************************
        * Name        : FINAL PROJECT: Book
        * Author      : Jake Soulinthavong
        * Created     : 04/27/2023
        * Course      : CIS 152 - Data Structures
        * Version     : 1.0
        * OS          : Windows 10
        * IDE         : Visual Studio 2019
        * Copyright   : This is my own original work based on
        *               specifications issued by our instructor
        * Description : This class represents a book object
        *               Output: N/A
        * Academic Honesty: I attest that this is my original work.
        * I have not used unauthorized source code, either modified or 
        * unmodified. I have not given other fellow student(s) access to
        * my program.         
        ***************************************************************/
        public long ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }


        /**************************************************************
        * Name: Book
        * Description: default constructor of Book
        * Input: long isbn, string title, string author, decimal price
        * Output: No output
        ***************************************************************/
        public Book(long isbn, string title, string author, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
        }

        /***************************************************************
        * Class Functions
        ***************************************************************/

        /**************************************************************
        * Name: ToString
        * Description: Method returns a string representation of the book with its title, author, and price.
        * Input: No input
        * Output: string of properties
        ***************************************************************/
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Price: {Price:C}";
        }
    }
}
