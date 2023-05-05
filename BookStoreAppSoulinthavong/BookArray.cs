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
    public class BookArray
    {
        /**************************************************************
        * Name        : FINAL PROJECT: BookArray
        * Author      : Jake Soulinthavong
        * Created     : 04/27/2023
        * Course      : CIS 152 - Data Structures
        * Version     : 1.0
        * OS          : Windows 10
        * IDE         : Visual Studio 2019
        * Copyright   : This is my own original work based on
        *               specifications issued by our instructor
        * Description : This class represents an array of books
        *               Output: N/A
        * Academic Honesty: I attest that this is my original work.
        * I have not used unauthorized source code, either modified or 
        * unmodified. I have not given other fellow student(s) access to
        * my program.         
        ***************************************************************/

        private Book[] books; // array of books
        private int size; // number of books in the array

        /**************************************************************
        * Name: BookArray
        * Description: default constructor of BookArray
        * Input: No input
        * Output: No output
        ***************************************************************/
        public BookArray()
        {
            books = new Book[10];
            size = 0;
        }
        /**************************************************************
        * Name: BookArray
        * Description: constructor of BookArray
        * Input: int capacity
        * Output: No output
        ***************************************************************/
        public BookArray(int capacity)
        {
            books = new Book[capacity];
            size = 0;
        }

        // Properties
        public int Size { get { return size; } }

        // Indexer
        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
        public Book[] GetBooks()
        {
            Book[] result = new Book[size];
            Array.Copy(books, result, size);
            return result;
        }


        /***************************************************************
        * Class Functions
        ***************************************************************/

        /**************************************************************
        * Name: AddBook
        * Description: Method is used to add a new book to the array. If the array is full, it resizes the array by doubling its capacity.
        * Input: Book book
        * Output: No output
        ***************************************************************/
        public Book AddBook(Book book)
        {
            if (size >= books.Length)
            {
                return null; // the array is full
            }

            books[size] = book;
            size++;

            return book;
        }


        /**************************************************************
        * Name: RemoveBook
        * Description: removes a book from the array, given a Book object as a parameter. The function returns true if the book was found and removed, otherwise, it returns false.
        * Input: Book book
        * Output: true or false
        ***************************************************************/
        public bool RemoveBook(Book book)
        {
            int index = FindBook(book);
            if (index != -1)
            {
                for (int i = index; i < size - 1; i++)
                {
                    books[i] = books[i + 1];
                }
                size--;
                return true;
            }
            else
            {
                return false;
            }
        }

        /**************************************************************
        * Name: FindBook
        * Description: Method searches for a book in the array
        * Input: Book book
        * Output: returns the index of the book if it was found, otherwise, it returns -1
        ***************************************************************/
        public int FindBook(Book book)
        {
            for (int i = 0; i < size; i++)
            {
                if (books[i].ISBN == book.ISBN)
                {
                    return i;
                }
            }
            return -1;
        }


        /**************************************************************
        * Name: SortByTitle
        * Description: Method uses the insertion sort algorithm to sort by Title
        * Input: No input, Book[] books for overloaded function
        * Output: No output
        ***************************************************************/
        public void SortByTitle()
        {
            for (int i = 1; i < size; i++)
            {
                Book current = books[i];
                int j = i - 1;
                while (j >= 0 && books[j].Title.CompareTo(current.Title) > 0)
                {
                    books[j + 1] = books[j];
                    j--;
                }
                books[j + 1] = current;
            }
        }

        public void SortByTitle(Book[] books)
        {
            for (int i = 1; i < books.Length; i++)
            {
                Book current = books[i];
                int j = i - 1;
                while (j >= 0 && books[j].Title.CompareTo(current.Title) > 0)
                {
                    books[j + 1] = books[j];
                    j--;
                }
                books[j + 1] = current;
            }
        }


        /**************************************************************
        * Name: SortByTitle
        * Description: Method uses the insertion sort algorithm to sort by Author
        * Input: No input, Book[] book for overloaded function
        * Output: No output
        ***************************************************************/
        public void SortByAuthor()
        {
            for (int i = 1; i < size; i++)
            {
                Book current = books[i];
                int j = i - 1;
                while (j >= 0 && books[j].Author.CompareTo(current.Author) > 0)
                {
                    books[j + 1] = books[j];
                    j--;
                }
                books[j + 1] = current;
            }
        }

        public void SortByAuthor(Book[] books)
        {
            for (int i = 1; i < books.Length; i++)
            {
                Book current = books[i];
                int j = i - 1;
                while (j >= 0 && books[j].Author.CompareTo(current.Author) > 0)
                {
                    books[j + 1] = books[j];
                    j--;
                }
                books[j + 1] = current;
            }
        }

        /**************************************************************
        * Name: SortByPrice
        * Description: Method uses the insertion sort algorithm to sort by Author
        * Input: No input, Book[] book for overloaded function
        * Output: No output
        ***************************************************************/
        public void SortByPrice()
        {
            for (int i = 1; i < size; i++)
            {
                Book current = books[i];
                int j = i - 1;
                while (j >= 0 && books[j].Price > current.Price)
                {
                    books[j + 1] = books[j];
                    j--;
                }
                books[j + 1] = current;
            }
        }


        public void SortByPrice(Book[] books)
        {
            for (int i = 1; i < books.Length; i++)
            {
                Book current = books[i];
                int j = i - 1;
                while (j >= 0 && books[j].Price > current.Price)
                {
                    books[j + 1] = books[j];
                    j--;
                }
                books[j + 1] = current;
            }
        }


        /**************************************************************
        * Name: IsFull
        * Description: Method checks to see if the array is full
        * Input: no input
        * Output: true or false
        ***************************************************************/
        public bool IsFull()
        {
            return size == books.Length;
        }

    }
}
