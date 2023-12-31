﻿using Microsoft.EntityFrameworkCore;
using Pop_Andreea_Georgiana_Lab2.Models;


namespace Pop_Andreea_Georgiana_Lab2.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new
           LibraryContext(serviceProvider.GetRequiredService
            <DbContextOptions<LibraryContext>>()))
            {
                if (context.Books.Any())
                {
                    return; // BD a fost creata anterior
                }

                var author1 = new Author { ID  = 1, FirstName = "Mihail", LastName = "Sadoveanu" };
                var author2 = new Author { ID = 2, FirstName = "George", LastName = "Calinescu" };
                var author3 = new Author { ID = 3, FirstName = "Mircea", LastName = "Eliade" };
                context.Books.AddRange(
                new Book
                {
                    Title = "Baltagul",
                    Author = author1,
                    Price =Decimal.Parse("22")
                },
               
                new Book
                {
                    Title = "Enigma Otiliei",
                    Author = author2,
                    Price=Decimal.Parse("18")
                },
               
                new Book
                {
                    Title = "Maytrei",
                    Author = author3,
                    Price=Decimal.Parse("27")
                }
               
                );


                context.Customers.AddRange(
                new Customer
                {
                    Name = "Popescu Marcela",
                    Adress = "Str. Plopilor, nr. 24",
                    BirthDate = DateTime.Parse("1979-09-01")
                },
                new Customer
                {
                    Name = "Mihailescu Cornel",
                    Adress = "Str. Bucuresti, nr.45,ap. 2",
                    BirthDate=DateTime.Parse("1969 - 07 - 08")}
               
                );

                context.SaveChanges();
            }
        }
    }
}

