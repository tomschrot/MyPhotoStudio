
using System;
using System.Collections.Generic;

using static MyPhotoStudio.Extensions;

namespace MyPhotoStudio.Models
{
    public sealed class AppointmentRepository
    {
        //---------------------------------------------------------------------
        private readonly List<Appointment> _appointments = new ();

        //---------------------------------------------------------------------
        public Appointment this [int n]
        {
            get => _appointments [n];
            set => _appointments [n] = value;
        }
        //---------------------------------------------------------------------
        public AppointmentRepository Add (Action <Appointment> treat)
        =>
            Add ( configureNew <Appointment> (treat) );

        //---------------------------------------------------------------------
        public AppointmentRepository Add (Appointment apoi)
        =>
            this.apply ( _ =>  _appointments.Add (apoi) );

        //---------------------------------------------------------------------
        public AppointmentRepository @foreach (Action <Appointment> handle)
        =>
            this.apply ( _ =>
            {
                for (int n = 0; n < _appointments.Count; n++)
                    handle?.Invoke (_appointments[n]);
            });
        //---------------------------------------------------------------------
        public AppointmentRepository SearchFor
        (
            Func   <Appointment, bool> match,
            Action <Appointment>       treat
        )
        =>  @foreach ( item =>
            {
                if ( match(item) )
                    treat (item);
            });
        //---------------------------------------------------------------------
        public AppointmentRepository SortBy (Comparison <Appointment> criteria)
        =>
            this.apply ( _ => _appointments.Sort (criteria) );
        //---------------------------------------------------------------------
    }
}
