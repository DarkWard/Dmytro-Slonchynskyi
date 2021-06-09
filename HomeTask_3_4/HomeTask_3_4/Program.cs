using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeTask_3_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Address> addresses = new List<Address>()
            {
                new Address { Id = 1, Country = "USA", State = "California", City = "Sacramento", ZipCode = "sac100", AddressLine = "Central street 5" },
                new Address { Id = 2, Country = "UK", State = "Wales", City = "Cardiff ", ZipCode = "car160", AddressLine = "Grand ave 26" },
                new Address { Id = 3, Country = "Ukraine", State = "Kharkivska", City = "Kharkov", ZipCode = "kha218", AddressLine = "Miru 16" },
                new Address { Id = 4, Country = "USA", State = "Nevada", City = "Carson", ZipCode = "car744", AddressLine = "Railroad 18" },
                new Address { Id = 5, Country = "UK", State = "Scotland", City = "Edinburgh", ZipCode = "edi490", AddressLine = "Old Town 3" },
                new Address { Id = 6, Country = "Poland", State = "Warsawska", City = "Warsaw", ZipCode = "war637", AddressLine = "Bemowo 22" },
                new Address { Id = 7, Country = "Poland", State = "Krakowska", City = "Krakow", ZipCode = "kra845", AddressLine = "Wawel Hill 64" }
            };

            List<Person> people = new List<Person>()
            {
                new Person { Id = 1, Age = 46, FirstName = "John", LastName = "Black", Email = "john.bl@gmail.com", AddressList = new List<int> { 1, 5, 6 } },
                new Person { Id = 2, Age = 13, FirstName = "Adam", LastName = "White", Email = "adam.wh@gmail.com", AddressList = new List<int> { 2, 4, 7 } },
                new Person { Id = 3, Age = 26, FirstName = "Peter", LastName = "Red", Email = "peter.re@gmail.com", AddressList = new List<int> { 3, 2, 6 } },
                new Person { Id = 4, Age = 33, FirstName = "Steve", LastName = "Green", Email = "steve.gr@gmail.com", AddressList = new List<int> { 1, 4, 3 } }
            };

            var result = from pe in people
                         from adr in pe.AddressList
                         join ad in addresses on adr equals ad.Id
                         select new { Person = pe.FirstName, Country = ad.Country, State = ad.State, Adress = ad.AddressLine };

            Console.WriteLine("Persons with their addresses\n");
            foreach (var r in result)
            {
                Console.WriteLine($"Name:{r.Person} Country:{r.Country} State:{r.State} Address:{r.Adress}");
            }

            Console.WriteLine("\nPersons older than 18");
            var result2 = people.Where(p => p.Age > 18);
            foreach (var p in result2)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} {p.Age}");
            }

            Console.WriteLine("\nPersons based on same country");
            var result3 = from t in people
                          .SelectMany(p => p.AddressList, (p, ad) => new { Person = p, Address = ad })
                          .Where(p => p.Address == 1 || p.Address == 4)
                          .Select(p => p.Person)
                          from a in t.AddressList.Where(a => a == 1 || a == 4)
                          join ad in addresses on a equals ad.Id
                          select new { Person = t.FirstName, Country = ad.Country };
            result3 = result3.Distinct();

            foreach (var r in result3)
            {
                Console.WriteLine($"Name:{r.Person} Country:{r.Country}");
            }

            Console.WriteLine("\nAverage age of all Persons");
            var result4 = from p in people
                          select p.Age;
            Console.WriteLine($"Average age of all Persons: {result4.Average()}");
        }
    }
}