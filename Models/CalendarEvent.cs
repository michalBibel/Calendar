using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Calendar.Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CalendarId { get; set; }
        public EventType Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        
        public virtual Calendar EventCalendar { get; set; }
        public virtual IList<Reminder> Reminders { get; set; }
    }
}