using System;
using System.Collections.Generic;

namespace BookStoreAppSoulinthavong
{
    /***************************************************************
    * Name        : FINAL PROJECT: BookStoreAppSoulinthavong
    * Author      : Jake Soulinthavong
    * Created     : 04/27/2023
    ***************************************************************/
    class Program
    {    /**************************************************************
    * Name        : FINAL PROJECT: Program
    * Author      : Jake Soulinthavong
    * Created     : 04/27/2023
    * Course      : CIS 152 - Data Structures
    * Version     : 1.0
    * OS          : Windows 10
    * IDE         : Visual Studio 2019
    * Copyright   : This is my own original work based on
    *               specifications issued by our instructor
    * Description : This program is the interface for the Bookstore. It has two portals, one for customers and one for employees (admin) users. A customer can place an order and the admin user can manipulate the data.
    *               Output: Customers, Books, Testing and Debugging code
    * Academic Honesty: I attest that this is my original work.
    * I have not used unauthorized source code, either modified or 
    * unmodified. I have not given other fellow student(s) access to
    * my program.         
    ***************************************************************/
        static void Main(string[] args)
        {
            //create admin pw
            string password = "CIS152"; //implement CIS152 as pw
            bool isAdmin = false;

            // create some books
            Book book1 = new Book(9781416936466, "The Great Gatsby", "F. Scott Fitzgerald", 7.99m);
            Book book2 = new Book(0440419468, "To Kill a Mockingbird", "Harper Lee", 6.99m);
            Book book3 = new Book(9780749336073, "1984", "George Orwell", 5.99m);
            Book book4 = new Book(9780497257842, "Animal Farm", "George Orwell", 4.99m);
            Book book5 = new Book(9780743273565, "The Catcher in the Rye", "J.D. Salinger", 6.99m);
            Book book6 = new Book(9780060935467, "One Hundred Years of Solitude", "Gabriel Garcia Marquez", 9.99m);
            Book book7 = new Book(9780061120084, "The Road", "Cormac McCarthy", 8.99m);
            Book book8 = new Book(9780316769174, "The Bell Jar", "Sylvia Plath", 7.99m);
            Book book9 = new Book(9780140283334, "The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 5.99m);
            Book book10 = new Book(9780375701451, "The Wind-Up Bird Chronicle", "Haruki Murakami", 9.99m);

            // create some customers
            Customer customer1 = new Customer() { Name = "John Smith", Address = "123 Main St." };
            Customer customer2 = new Customer() { Name = "Jane Doe", Address = "456 Elm St." };
            Customer customer3 = new Customer() { Name = "Alice Johnson", Address = "789 Oak St." };
            Customer customer4 = new Customer() { Name = "Bob Williams", Address = "1010 Maple Ave." };
            Customer customer5 = new Customer() { Name = "Olivia Brown", Address = "222 Pine St." };
            Customer customer6 = new Customer() { Name = "Ethan Davis", Address = "333 Cherry St." };
            Customer customer7 = new Customer() { Name = "Avery Wilson", Address = "444 Cedar Ave." };
            Customer customer8 = new Customer() { Name = "Hannah Martin", Address = "555 Walnut St." };
            Customer customer9 = new Customer() { Name = "Isabella Thompson", Address = "666 Elm St." };
            Customer customer10 = new Customer() { Name = "David Rodriguez", Address = "777 Maple Ave." };

            // add customers to a list
            CustomerList customerList = new CustomerList();
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);
            customerList.Add(customer5);
            customerList.Add(customer6);
            customerList.Add(customer7);
            customerList.Add(customer8);
            customerList.Add(customer9);
            customerList.Add(customer10);

            // create some orders
            List<Book> books1 = new List<Book>() { book1, book2 };
            Order order1 = new Order(1, books1, 14.98m, DateTime.Now);
            List<Book> books2 = new List<Book>() { book3 };
            Order order2 = new Order(2, books2, 5.99m, DateTime.Now);
            List<Book> books3 = new List<Book>() { book1, book4 };
            Order order3 = new Order(3, books3, 12.98m, DateTime.Now);
            List<Book> books4 = new List<Book>() { book2, book5, book6 };
            Order order4 = new Order(4, books4, 23.97m, DateTime.Now);
            List<Book> books5 = new List<Book>() { book7, book8, book9, book10 };
            Order order5 = new Order(5, books5, 32.96m, DateTime.Now);
            List<Book> books6 = new List<Book>() { book4, book9, book2, book2 };
            Order order6 = new Order(6, books5, 32.96m, DateTime.Now);
            List<Book> books7 = new List<Book>() { book3, book8, book1, book7 };
            Order order7 = new Order(7, books5, 32.96m, DateTime.Now);
            List<Book> books8 = new List<Book>() { book2, book5, book1, book6, book9, book3 };
            Order order8 = new Order(8, books8, 45.82m, DateTime.Now);
            List<Book> books9 = new List<Book>() { book1, book4, book8, book10, book2, book4, book7 };
            Order order9 = new Order(9, books9, 23.49m, DateTime.Now);
            List<Book> books10 = new List<Book>() { book9, book6, book3, book10, book8 };
            Order order10 = new Order(10, books10, 19.99m, DateTime.Now);

            BookArray bookArray = new BookArray();
            Book[] books = new Book[] { book1, book2, book3, book4, book5, book6, book7, book8, book9, book10 };

            foreach (Book book in books)
            {
                if (!bookArray.IsFull())
                {
                    bookArray.AddBook(book);
                }
                else
                {
                    Console.WriteLine("Array is full, cannot add book: {0}", book.Title);
                }
            }


            // place orders for customers
            try
            {
                customerList.PlaceOrder(customer1.Name, order1);
                customerList.PlaceOrder(customer2.Name, order2);
                customerList.PlaceOrder(customer3.Name, order3);
                customerList.PlaceOrder(customer4.Name, order4);
                customerList.PlaceOrder(customer5.Name, order5);
                customerList.PlaceOrder(customer6.Name, order6);
                customerList.PlaceOrder(customer7.Name, order7);
                customerList.PlaceOrder(customer8.Name, order8);
                customerList.PlaceOrder(customer9.Name, order9);
                customerList.PlaceOrder(customer10.Name, order10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // get order history for customers
            List<Order> johnOrders = customer1.GetOrderHistory();
            List<Order> janeOrders = customer2.GetOrderHistory();

            while (true)
            {
                Console.WriteLine("Welcome to our Bookstore App! We appreciate your visit. \nPlease enter 1, 2, or 3 to verify which portal you would like to enter.");
                Console.WriteLine("1. Customer Portal");
                Console.WriteLine("2. Employee Portal");
                Console.WriteLine("3. Exit");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Welcome, customer!");
                    break;


                }
                else if (input == "2")
                {
                    Console.WriteLine("Please enter the password:");
                    string enteredPassword = Console.ReadLine();

                    if (enteredPassword == password)
                    {
                        isAdmin = true;
                        Console.WriteLine("Password accepted. Welcome, admin!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Please try again.");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

            if (isAdmin)
            {
                while (true)
                {

                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Execute admin commands");
                    Console.WriteLine("2. Enter testing and debugging code");
                    Console.WriteLine("3. Exit");
                    string input = Console.ReadLine();

                    switch (input)
                    {

                        case "1":
                            Console.WriteLine("Select an option:");
                            Console.WriteLine("1. Add New Customer");
                            Console.WriteLine("2. Add New Book");
                            Console.WriteLine("3. Exit");
                            string adminInput = Console.ReadLine();

                            if (adminInput == "1")
                            {
                                bool wantsToAddCustomer = true;
                                while (wantsToAddCustomer)
                                {
                                    Console.WriteLine("Would you like to add a new customer? (yes/no)");
                                    string answer = Console.ReadLine().Trim().ToLower();

                                    if (answer == "yes")
                                    {
                                        Console.WriteLine("Please enter the Customer's full name:");
                                        string name = Console.ReadLine();

                                        Console.WriteLine("Please enter their address:");
                                        string address = Console.ReadLine();

                                        // Create customer object and add it to the customer list
                                        Customer customer = new Customer() { Name = name, Address = address };
                                        customerList.Add(customer);

                                        // Display customer information
                                        Console.WriteLine("You have successfully added a new customer with the below information:\n   Customer Name: " + customer.Name + "\n   Customer Address: " + customer.Address);

                                        try
                                        {
                                            Console.WriteLine("Would you like to see the current list of customers? (yes/no)");
                                            answer = Console.ReadLine().Trim().ToLower();

                                            if (answer == "yes")
                                            {
                                                Console.WriteLine();
                                                foreach (Customer c in customerList)
                                                {
                                                    Console.WriteLine(c.Name);
                                                }
                                                Console.WriteLine();
                                                break;
                                            }
                                            else if (answer == "no")
                                            {
                                                wantsToAddCustomer = false;
                                                break;
                                            }
                                            else
                                            {
                                                throw new Exception("Invalid input. Please enter 'yes' or 'no'.");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Error: " + ex.Message);
                                        }
                                    }
                                    else if (answer == "no")
                                    {
                                        wantsToAddCustomer = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                                    }
                                }

                            }
                            else if (adminInput == "2")
                            {
                                bool wantsToAddBook = true;

                                while (wantsToAddBook)
                                {
                                    decimal bookPrice = 1.00m;
                                    long bookISBN = 1111111111;

                                    Console.WriteLine("Would you like to add a new book? (yes/no)");
                                    string answer = Console.ReadLine().Trim().ToLower();
                                    if (answer == "yes")
                                    {
                                        if (bookArray.IsFull()) // Check if bookArray is already full
                                        {
                                            Console.WriteLine("Sorry, the book list is already full.");
                                            Console.WriteLine("Would you like to remove a book from the list? (yes/no)");
                                            string removeBookInput = Console.ReadLine();
                                            if (removeBookInput.ToLower() == "yes")
                                            {
                                                Console.WriteLine("\nHere is our list of books sorted by Author: ");
                                                bookArray.SortByAuthor(books);
                                                Console.WriteLine("   " + "Item #, Author, Title");

                                                Dictionary<int, Book> displayBookArray = new Dictionary<int, Book>();
                                                int recordNumber = 1;
                                                foreach (Book book in books)
                                                {
                                                    Console.WriteLine("   " + recordNumber + " " + book.Author + ", " + book.Title);
                                                    displayBookArray[recordNumber] = book;
                                                    recordNumber++;
                                                }

                                                Console.WriteLine();

                                                Console.WriteLine("Please enter the record number of the book you would like to remove:");
                                                string removeTitle = Console.ReadLine();
                                                int selectedBook;
                                                bool isNumeric = int.TryParse(removeTitle, out selectedBook);

                                                if (isNumeric && displayBookArray.ContainsKey(selectedBook))
                                                {
                                                    Book selectedBookObject = displayBookArray[selectedBook];
                                                    BookArray bookArray1 = new BookArray(displayBookArray.Count);
                                                    foreach (KeyValuePair<int, Book> pair in displayBookArray)
                                                    {
                                                        bookArray.AddBook(pair.Value);
                                                    }
                                                    bookArray1.RemoveBook(selectedBookObject);
                                                    Console.WriteLine(selectedBookObject.Title + " has been removed successfully.");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input. Please try again.");
                                                }
                                            }
                                            else if (removeBookInput.ToLower() == "no")
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter the Book Title:");
                                            string bookTitle = Console.ReadLine();

                                            Console.WriteLine("Please enter the Author:");
                                            string bookAuthor = Console.ReadLine();

                                            Console.WriteLine("Please enter the ISBN:");
                                            try
                                            {
                                                bookISBN = long.Parse(Console.ReadLine());
                                            }
                                            catch (FormatException ex)
                                            {
                                                Console.WriteLine("Invalid input. Please enter a valid decimal value. Error: " + ex.Message);
                                            }

                                            Console.WriteLine("Please enter the Price:");
                                            try
                                            {
                                                bookPrice = decimal.Parse(Console.ReadLine());
                                            }
                                            catch (FormatException ex)
                                            {
                                                Console.WriteLine("Invalid input. Please enter a valid decimal value. Error: " + ex.Message);
                                            }
                                            // Create book object and add it to the book list
                                            Book book = new Book(bookISBN, bookTitle, bookAuthor, bookPrice);
                                            bookArray.AddBook(book);
                                            bookArray.SortByTitle();

                                            // Display book information
                                            Console.WriteLine("You have successfully added a new book with the below information:\n   Book Title: " + book.Title + "\n   Book Author: " + book.Author + "\n   Book ISBN: " + book.ISBN + "\n   Book Price: " + book.Price);
                                        }


                                        try
                                        {
                                            Console.WriteLine("Would you like to see the current list of books? (yes/no)");
                                            answer = Console.ReadLine().Trim().ToLower();

                                            if (answer == "yes")
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Book List:");
                                                foreach (Book b in bookArray.GetBooks())
                                                {
                                                    Console.WriteLine($"ISBN: {b.ISBN}, Title: {b.Title}, Author: {b.Author}, Price: {b.Price:C}");
                                                }

                                                Console.WriteLine();
                                                break;
                                            }
                                            else if (answer == "no")
                                            {
                                                wantsToAddBook = false;
                                                break;
                                            }
                                            else
                                            {
                                                throw new Exception("Invalid input. Please enter 'yes' or 'no'.");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Error: " + ex.Message);
                                        }
                                    }
                                    else if (answer == "no")
                                    {
                                        wantsToAddBook = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                                    }
                                }

                            }
                            else if (adminInput == "3")
                            {
                                Console.WriteLine("Exiting program...");
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again by entering either 1, 2, or 3.");
                            }
                            break;
                        case "2":
                            // Enter testing and debugging code
                            Console.WriteLine(
                                "\n---------------------------------------------------------------" +             
                                "\n---------------------------------------------------------------" +
                                "\n---------------------TESTING AND DEBUGGING---------------------" +
                                "\n---------------------------------------------------------------" +
                                "\n---------------------------------------------------------------");
                            Console.WriteLine("\n-----------------TESTING ORDERS-----------------");
                            Console.WriteLine("John's Orders:");
                            foreach (Order order in johnOrders)
                            {
                                Console.WriteLine("   Order ID: " + order.OrderId + ", Total Price: " + order.TotalPrice);
                                foreach (Book book in order.Books)
                                {
                                    Console.WriteLine("   Book ISBN: " + book.ISBN + ", Title: " + book.Title);
                                }
                            }

                            Console.WriteLine("\nJane's Orders:");
                            foreach (Order order in janeOrders)
                            {
                                Console.WriteLine("   Order ID: " + order.OrderId + ", Total Price: " + order.TotalPrice);
                                foreach (Book book in order.Books)
                                {
                                    Console.WriteLine("   Book ISBN: " + book.ISBN + ", Title: " + book.Title);
                                }
                            }

                            // Sort the array by Author
                            bookArray.SortByAuthor(books);

                            Console.WriteLine("\n-----------------TESTING SORTING ALGORITHMS-----------------");
                            Console.WriteLine("Books alphabetically sorted by Author: ");
                            Console.WriteLine("   " + "Authors");
                            foreach (Book book in books)
                            {
                                Console.WriteLine("   " + book.Author);
                            }
                            Console.WriteLine();
                            // Sort the array by Price
                            bookArray.SortByPrice(books);
                            Console.WriteLine("Books sorted by Price (least to greatest):");
                            Console.WriteLine("   " + "Price, Title");
                            foreach (Book book in books)
                            {
                                Console.WriteLine("   " + "$" + book.Price.ToString() + ", " + book.Title + " " + book.Title);
                            }
                            Console.WriteLine();
                            // Sort the array by Title
                            bookArray.SortByTitle(books);
                            Console.WriteLine("Books alphabetically sorted by Title:");
                            Console.WriteLine("   " + "Title, Price, ISBN");
                            foreach (Book book in books)
                            {
                                Console.WriteLine("   " + book.Title + ", " + book.Price + ", " + book.ISBN);
                            }

                            Console.WriteLine("\n-----------------TESTING *CUSTOMERLIST*: REMOVE FUNCTION-----------------");
                            // remove a customer from the list
                            Console.WriteLine("Customer List Size: " + customerList.Size());
                            Console.WriteLine("Removing Customers 1-6....");
                            customerList.Remove(customer1);
                            customerList.Remove(customer2);
                            customerList.Remove(customer3);
                            customerList.Remove(customer4);
                            customerList.Remove(customer5);
                            customerList.Remove(customer6);

                            Console.WriteLine("Customer List Size: " + customerList.Size());
                            Console.WriteLine(
                                "\n---------------------------------------------------------------" +
                                "\n---------------------------------------------------------------" +
                                "\n---------------------END TESTING/DEBUGGING---------------------" +
                                "\n---------------------------------------------------------------" +
                                "\n---------------------------------------------------------------");
                            Console.WriteLine("Press enter to continue.\n");
                            Console.ReadKey();
                            break;
                        case "3":
                            // Exit loop
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again by typing in either 1, 2, or 3. Then hit enter.");
                            break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("\nAre you a current or new customer?");
                    Console.WriteLine("1. Current customer");
                    Console.WriteLine("2. New customer");
                    Console.WriteLine("3. Exit.");
                    string customerType = Console.ReadLine();

                    if (customerType == "1")
                    {
                        try
                        {
                            Console.WriteLine("Thank you for supporting our business! To see your current order, please enter your full name: ");
                            string inputName = Console.ReadLine();

                            // Convert the input to lowercase and capitalize only the first letter
                            string formattedName = char.ToUpper(inputName[0]) + inputName.Substring(1).ToLower();

                            bool foundCustomer = false;

                            // Loop through the customer names and check if the formatted input matches
                            foreach (Customer customer in customerList)
                            {
                                string formattedCustomerName = char.ToUpper(customer.Name[0]) + customer.Name.Substring(1).ToLower();

                                if (formattedName == formattedCustomerName)
                                {
                                    // The input matches a customer name
                                    Console.WriteLine("Found customer: " + customer.Name);

                                    // Output the customer's order history
                                    Console.WriteLine("Order history for " + customer.Name + ":");
                                    HashSet<int> orderIds = new HashSet<int>();
                                    foreach (Order order in customer.GetOrderHistory())
                                    {
                                        if (!orderIds.Contains(order.OrderId))
                                        {
                                            Console.WriteLine("   Order ID: " + order.OrderId + ", Total Price: " + order.TotalPrice);
                                            foreach (Book book in order.Books)
                                            {
                                                Console.WriteLine("   Book ISBN: " + book.ISBN + ", Title: " + book.Title);
                                            }
                                            orderIds.Add(order.OrderId);
                                        }
                                    }
                                    foundCustomer = true;
                                    break;
                                }
                            }

                            if (!foundCustomer)
                            {
                                // if we get to this point, the name was not found in the list
                                Console.WriteLine("No customer found with the name " + formattedName + ". Please try again.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred: " + ex.Message);
                        }

                    }
                    else if (customerType == "2")
                    {
                        Console.WriteLine("Please enter your full name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Please enter your address:");
                        string address = Console.ReadLine();

                        //Console.WriteLine("Please enter your phone number:");
                        //string phone = Console.ReadLine();

                        // Create customer object and add it to the customer list
                        Customer customer = new Customer() { Name = name, Address = address };
                        customerList.Add(customer);
                        // Display customer information
                        Console.WriteLine("Thank you for submitting your information, " + customer.Name + "!");

                        bool wantsToOrderBooks = false;
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Would you like to place an order for some books? (yes/no)");
                                string answer = Console.ReadLine().Trim().ToLower();

                                if (answer == "yes")
                                {
                                    wantsToOrderBooks = true;
                                    bookArray.SortByAuthor(books);

                                    Console.WriteLine("\nAwesome! Here is our list of books sorted by price: ");
                                    bookArray.SortByPrice(books);
                                    Console.WriteLine("   " + "Item #, Price, Title");

                                    Dictionary<int, Book> checkoutItems = new Dictionary<int, Book>();
                                    int itemNumber = 1;
                                    foreach (Book book in books)
                                    {
                                        Console.WriteLine("   " + itemNumber + " $" + book.Price.ToString() + ", " + book.Title);
                                        checkoutItems[itemNumber] = book;
                                        itemNumber++;
                                    }

                                    Console.WriteLine();

                                    // Ask the customer which items they want to purchase
                                    while (wantsToOrderBooks)
                                    {
                                        try
                                        {
                                            List<Book> currentBooksOrder = new List<Book>();
                                            decimal totalPrice = 0m;

                                            string userInput = "";
                                            bool isOrderPlaced = false;
                                            while (true)
                                            {
                                                Console.WriteLine("Enter the item number of the book you'd like to purchase, or type 'done' to finish:");
                                                userInput = Console.ReadLine();

                                                if (userInput.ToLower() == "done")
                                                {
                                                    if (currentBooksOrder.Count == 0)
                                                    {
                                                        Console.WriteLine("Your order is empty. Exiting order placement.");
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Total price of your order: " + totalPrice);

                                                        Order currentOrder = new Order(customerList.Size(), currentBooksOrder, totalPrice, DateTime.Now);
                                                        customer.PlaceOrder(currentOrder);

                                                        isOrderPlaced = true;
                                                        break;
                                                    }
                                                }

                                                int selectedBook;
                                                bool isNumeric = int.TryParse(userInput, out selectedBook);

                                                if (isNumeric && checkoutItems.ContainsKey(selectedBook))
                                                {
                                                    Book selectedBookObject = checkoutItems[selectedBook];
                                                    currentBooksOrder.Add(selectedBookObject);
                                                    Console.WriteLine("Added " + selectedBookObject.Title + " to your order!");
                                                    totalPrice += selectedBookObject.Price;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input. Please try again.");
                                                }
                                            }

                                            if (isOrderPlaced)
                                            {
                                                break;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("An error occurred: " + ex.Message);
                                        }
                                    }
                                }
                                else if (answer == "no")
                                {
                                    wantsToOrderBooks = false;
                                    break;
                                }
                                else
                                {
                                    throw new Exception("Invalid input. Please enter 'yes' or 'no'.");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                    }

                    else if (customerType == "3")
                    {
                        Console.WriteLine("Exiting program...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again by entering either 1, 2, or 3.");
                    }
                }

            }
        }
    }
}
