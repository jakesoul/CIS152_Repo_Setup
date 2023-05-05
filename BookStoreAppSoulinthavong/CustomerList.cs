using System;
using System.Collections;
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
    class CustomerList : IEnumerable<Customer>
    {
        /**************************************************************
        * Name        : FINAL PROJECT: CustomerList
        * Author      : Jake Soulinthavong
        * Created     : 04/27/2023
        * Course      : CIS 152 - Data Structures
        * Version     : 1.0
        * OS          : Windows 10
        * IDE         : Visual Studio 2019
        * Copyright   : This is my own original work based on
        *               specifications issued by our instructor
        * Description : This class represents a linked list of Customer objects. The IEnumerable<Customer> interface is implemented to allow iterating over the list of customers.
        *               Output: N/A
        * Academic Honesty: I attest that this is my original work.
        * I have not used unauthorized source code, either modified or 
        * unmodified. I have not given other fellow student(s) access to
        * my program.         
        ***************************************************************/
        private class ListNode
        {
            /**************************************************************
            * Name: ListNode
            * Description: private class to represent a node in linked list
            * Input: No input
            * Output: No output
            ***************************************************************/

            public Customer Data;
            public ListNode Next;

            /**************************************************************
            * Name: ListNode
            * Description: constructor
            * Input: Customer customer
            * Output: No output
            ***************************************************************/
            public ListNode(Customer customer)
            {
                Data = customer;
                Next = null;
            }
        }

        //properties
        private ListNode head;
        private int count;

        /***************************************************************
        * Class Functions
        ***************************************************************/
        /**************************************************************
        * Name: CustomerList
        * Description: default method of CustomerList, accepts no parameters
        * Input: No input
        * Output: the initialized properties
        ***************************************************************/
        public CustomerList()
        {
            head = null;
            count = 0;
        }

        /**************************************************************
        * Name: Add
        * Description: add method, accepting the Customer class as an object
        * Input: Customer class as an object
        * Output: adds node, which contain properties of the Customer class
        ***************************************************************/
        public void Add(Customer customer)
        {
            ListNode newNode = new ListNode(customer);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                ListNode current = head;
                ListNode previous = null;

                while (current != null && current.Data.Id < customer.Id)
                {
                    previous = current;
                    current = current.Next;
                }

                if (previous == null)
                {
                    head = newNode;
                    newNode.Next = current;
                }
                else
                {
                    previous.Next = newNode;
                    newNode.Next = current;
                }
            }

            count++;
        }

        /**************************************************************
        * Name: Remove
        * Description: add method, accepting the Customer class as an object
        * Input: Customer class as an object
        * Output: removes node, which contain properties of the Customer class
        ***************************************************************/
        public void Remove(Customer customer)
        {
            if (head == null)
            {
                throw new InvalidOperationException("Cannot remove from an empty list.");
            }

            ListNode current = head;
            ListNode previous = null;

            while (current != null && !current.Data.Equals(customer))
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                throw new InvalidOperationException("Customer not found in list.");
            }

            if (previous == null)
            {
                head = current.Next;
            }
            else
            {
                previous.Next = current.Next;
            }

            count--;
        }

        /**************************************************************
        * Name: Size
        * Description: number of nodes
        * Input: No input
        * Output: count
        ***************************************************************/
        public int Size()
        {
            return count;
        }


        /**************************************************************
        * Name: GetCustomerByName
        * Description: searches for a customer with a specific name and returns that customer object
        * Input: string name
        * Output: null or customer object
        ***************************************************************/
        public Customer GetCustomerByName(string name)
        {
            ListNode current = head;

            while (current != null)
            {
                if (current.Data.Name == name)
                {
                    return current.Data;
                }

                current = current.Next;
            }

            return null;
        }


        /**************************************************************
        * Name: PlaceOrder
        * Description: places an order for a customer given their name and an Order object
        * Input: string customerName, Order order
        * Output: no output
        ***************************************************************/
        public void PlaceOrder(string customerName, Order order)
        {
            Customer customer = GetCustomerByName(customerName);

            if (customer != null)
            {
                customer.PlaceOrder(order);
            }
            else
            {
                throw new InvalidOperationException("Customer not found.");
            }
        }

        /**************************************************************
        * Name: GetEnumerator
        * Description: returns an IEnumerator<Customer> object, which is used to iterate over the Customer objects in the list.
        * Input: no input
        * Output: IEnumerator<Customer> object
        ***************************************************************/
        public IEnumerator<Customer> GetEnumerator()
        {
            ListNode current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        /**************************************************************
        * Name: GetEnumerator
        * Description: calls the GetEnumerator() method and returns its result
        * Input: no input
        * Output: results of GetEnumerator()
        ***************************************************************/
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
