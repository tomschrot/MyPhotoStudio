
using System;
using MyPhotoStudio.Models;

// to build hit Crtl-Shift-B

Console.WriteLine ("Console Application Template for VS Code\nby Tom Schröter");

var list =

        new AppointmentRepository ()
            .Add
            (
                new Appointment
                {
                    Customer = new Customer
                    {
                        Name             = "Donald Duck",
                        CreditCardNumber = "12345-6789-000"
                    },

                    Date = DateTime.Parse ("13.11.2021")
                }
            )
            .Add
            (
                new Appointment
                {
                    Customer = new Customer
                    {
                        Name             = "Mickey Mouse",
                        CreditCardNumber = "12345-6789-111"
                    },

                    Date = DateTime.Parse ("10.10.2021")
                }
            )
            .Sort ()
            ;


Console.WriteLine ($"\r\nOK @ {DateTime.Now}");
