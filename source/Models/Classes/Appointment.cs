
using System;

namespace MyPhotoStudio.Models
{
    public sealed class Appointment
    {
        public DateTime Date     { get; set; } = DateTime.Now;
        public Customer Customer { get; set; } = new ();

        override
        public string ToString () => $"{Date}: {Customer.Name}";
    }
}
