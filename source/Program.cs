
using System;
using MyPhotoStudio.Models;

// to build hit Crtl-Shift-B

Console.WriteLine ("Console Application Template for VS Code\nby Tom Schröter");

var list =

        new AppointmentRepository ()
            .Add ( appointment =>
            {
                appointment.Customer.Name             = "Donald Duck";
                appointment.Customer.CreditCardNumber = "12345-6789-000";
                appointment.Date                      = DateTime.Parse ("13.11.2021");
            })
            .Add ( appointment =>
            {
                appointment.Customer.Name             = "Mickey Mouse";
                appointment.Customer.CreditCardNumber = "12345-6789-000";
                appointment.Date                      = DateTime.Parse ("10.10.2021");
            })
            .Sort ()
            ;


Console.WriteLine ($"\r\nOK @ {DateTime.Now}");
