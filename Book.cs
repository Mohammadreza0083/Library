using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        interface ISearchable
        {
            bool IsMatch(string searchTerm);
        }

        public class Book : ISearchable
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }

            public bool IsMatch(string searchTerm)
            {
                return Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                       Author.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                       Id.ToString() == searchTerm;
            }
        }


    }

