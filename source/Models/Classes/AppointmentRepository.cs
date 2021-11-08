
using System;
using System.Collections.Generic;

namespace MyPhotoStudio.Models
{
    public sealed class AppointmentRepository
    {
        //---------------------------------------------------------------------

        public static AppointmentRepository operator +
        (
            AppointmentRepository repo,
            Appointment           apoi
        )
        {
            repo._appointments.Add (apoi);

            // should make sense to sort after insert??
            repo._appointments.Sort();

            return repo;
        }
        //---------------------------------------------------------------------

        private readonly List<Appointment> _appointments = new ();

        //---------------------------------------------------------------------

        public Appointment this [int n]
        {
            get => _appointments [n];
            set => _appointments [n] = value;
        }
        //---------------------------------------------------------------------

        public AppointmentRepository Add (Appointment apoi)
        {
            _appointments.Add (apoi);
            return this;
        }

        //---------------------------------------------------------------------
        public AppointmentRepository GetAppointmentsFor
        (
            DateTime             targetDate,
            Action <Appointment> handle
        )
        {
            for (int n = 0; n < _appointments.Count; n++)
                if ( targetDate == _appointments[n].Date )
                    handle (_appointments[n]);

            return this;
        }
        //---------------------------------------------------------------------

        public AppointmentRepository Sort ()
        {
            _appointments.Sort
            (
                (Appointment a, Appointment b) => a.Date.CompareTo (b.Date)
            );
            
            return this;
        }
        //---------------------------------------------------------------------
    }
}
