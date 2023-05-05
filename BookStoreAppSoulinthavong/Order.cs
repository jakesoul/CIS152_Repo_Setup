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
    public class Order
    {
        /**************************************************************
        * Name        : FINAL PROJECT: Order
        * Author      : Jake Soulinthavong
        * Created     : 04/27/2023
        * Course      : CIS 152 - Data Structures
        * Version     : 1.0
        * OS          : Windows 10
        * IDE         : Visual Studio 2019
        * Copyright   : This is my own original work based on
        *               specifications issued by our instructor
        * Description : This class represents a customer order of a collection of books
        *               Output: N/A
        * Academic Honesty: I attest that this is my original work.
        * I have not used unauthorized source code, either modified or 
        * unmodified. I have not given other fellow student(s) access to
        * my program.         
        ***************************************************************/
        public int OrderId { get; set; }
        public Book Book { get; set; }
        public List<Book> Books { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        /**************************************************************
        * Name: Order
        * Description: default constructor of BookArray
        * Input: int orderId, List<Book> books, decimal totalPrice, DateTime orderDate
        * Output: No output
        ***************************************************************/
        public Order(int orderId, List<Book> books, decimal totalPrice, DateTime orderDate)
        {
            OrderId = orderId;
            Books = books;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
        }
    }
}
