using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        private List<Book> books;
        private List<string> members;

        public Library()
        {
            books = new List<Book>();
            members = new List<string>();
        }

        public void AddBook(string title, string author)
        {
            Book newBook = new Book { Id = books.Count + 1, Title = title, Author = author };
            books.Add(newBook);
            Console.WriteLine($"Added book: {title} by {author}");
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Library Books:");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"ID: {books[i].Id}, Title: {books[i].Title}, Author: {books[i].Author}");
            }

        }

        public List<Book> SearchBooks(string searchTerm)
        {
            List<Book> searchResults = new List<Book>();

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].IsMatch(searchTerm))
                {
                    searchResults.Add(books[i]);
                }
            }

            return searchResults;
        }

        public void RegisterMember(string memberName)
        {
            members.Add(memberName);
            Console.WriteLine($"Registered new member: {memberName}");
        }
        public void BorrowBook(string memberName, int bookId)
        {
            bool memberExists = false;
            foreach (string member in members)
            {
                if (member == memberName)
                {
                    memberExists = true;
                    break;
                }
            }

            if (memberExists)
            {
                Book borrowedBook = null;
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Id == bookId)
                    {
                        borrowedBook = books[i];
                        books.RemoveAt(i);
                        Console.WriteLine($"Member {memberName} borrowed book: {borrowedBook.Title}");
                        return;
                    }
                }

                Console.WriteLine($"Book with ID '{bookId}' not available.");
            }
            else
            {
                Console.WriteLine($"Member '{memberName}' is not registered.");
            }
        }



        public void ReturnBook(string memberName, int bookId)
        {
            if (members.Contains(memberName))
            {
                Book returnedBook = new Book { Id = bookId };
                books.Add(returnedBook);
                Console.WriteLine($"Member {memberName} returned book with ID: {bookId}");
            }
            else
            {
                Console.WriteLine($"Member '{memberName}' is not registered.");
            }
        }
    }
}
