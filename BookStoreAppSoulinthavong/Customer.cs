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
    public class Customer
    {
        /**************************************************************
        * Name        : FINAL PROJECT: Customer
        * Author      : Jake Soulinthavong
        * Created     : 04/27/2023
        * Course      : CIS 152 - Data Structures
        * Version     : 1.0
        * OS          : Windows 10
        * IDE         : Visual Studio 2019
        * Copyright   : This is my own original work based on
        *               specifications issued by our instructor
        * Description : This class represents a customer ordering and buying books
        *               Output: N/A
        * Academic Honesty: I attest that this is my original work.
        * I have not used unauthorized source code, either modified or 
        * unmodified. I have not given other fellow student(s) access to
        * my program.         
        ***************************************************************/
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Order> OrderHistory { get; set; }

        /**************************************************************
        * Name: Customer
        * Description: default constructor of Customer
        * Input: No input
        * Output: No output
        ***************************************************************/
        public Customer()
        {
            OrderHistory = new List<Order>();
        }

        /**************************************************************
        * Name: Customer
        * Description: constructor of Customer
        * Input: string name, string address
        * Output: No output
        ***************************************************************/
        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
            OrderHistory = new List<Order>();
        }

        /***************************************************************
        * Class Functions
        ***************************************************************/

        /**************************************************************
        * Name: AddBookToOrder
        * Description: Method adds a Book to the Order identified by orderId
        * Input: int orderId, Book book
        * Output: No output unless there was no order found
        ***************************************************************/
        public void AddBookToOrder(int orderId, Book book)
        {
            Order order = OrderHistory.FirstOrDefault(o => o.OrderId == orderId);

            if (order != null)
            {
                order.Books.Add(book);
                order.TotalPrice += book.Price;
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }

        /**************************************************************
        * Name: AddBookToOrder
        * Description: Method method adds an Order to the customer's OrderHistory list
        * Input: Order order
        * Output: No output
        ***************************************************************/
        public void PlaceOrder(Order order)
        {
            OrderHistory.Add(order);
        }

        /**************************************************************
        * Name: AddBookToOrder
        * Description: Method returns the customer's OrderHistory list
        * Input: Order order
        * Output: OrderHistory
        ***************************************************************/
        public List<Order> GetOrderHistory()
        {
            return OrderHistory;
        }
    }
}
