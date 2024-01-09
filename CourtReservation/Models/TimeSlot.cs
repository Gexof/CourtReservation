using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class TimeSlot
    {

        public TimeSpan StartTime { get; }
        public TimeSpan EndTime { get; }

        public TimeSlot(TimeSpan startTime, TimeSpan endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool OverlapsWith(TimeSlot other)
        {
            return StartTime < other.EndTime && EndTime > other.StartTime;
        }
    }
}
