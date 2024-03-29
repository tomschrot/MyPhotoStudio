
using System;
using MyPhotoStudio.Models;

using static MyPhotoStudio.Extensions;

// to build hit Crtl-Shift-B

Console.WriteLine ("Console Application Template for VS Code\nby Tom Schröter");

var requiredDate = DateTime.Parse ("10.10.2021");

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
            .Add ( appointment =>
            {
                appointment.Customer.Name             = "Goofy";
                appointment.Customer.CreditCardNumber = "12345-6789-000";
                appointment.Date                      = DateTime.Parse ("10.10.2021");
            })
            .Add ( appointment =>
            {
                appointment.Customer.Name             = "Daisy Duck";
                appointment.Customer.CreditCardNumber = "12345-6789-000";
                appointment.Date                      = DateTime.Parse ("11.11.2021");
            })
            .SortBy    ( (a, b) => a.Date.CompareTo (b.Date) )
            .ForEach   ( item => Console.WriteLine (item) )
            .SearchFor
            (
                check: item => item.Date == requiredDate,
                treat: item => Console.WriteLine ($"Found: {item}")
            )
            ;

Console.WriteLine ($"\r\nOK @ {DateTime.Now}");
