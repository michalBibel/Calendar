using System;
using System.Collections.Generic;
using System.Drawing;

namespace Calendar.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        public CalendarUser Owner { get; set; }
        public TimeZone CalendarTimeZone { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }

        public virtual IList<CalendarEvent> Evnts { get; set; }
        public virtual IList<CalendarUser> SharingUsers { get; set; }
        public virtual IList<Reminder> DefaultReminders { get; set; }
    }
}
