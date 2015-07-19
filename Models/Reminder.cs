using System;

namespace Calendar.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public DateTime ReminderTime { get; set; }
        public int? EventId { get; set; }
        public int? CalendarId { get; set; }
        public int? UserId { get; set; }
        public bool IsDismissed { get; set; }
        public bool IsSnoozed { get; set; }

        public CalendarEvent Event { get; set; }
        public Calendar Calendar { get; set; }
        public CalendarUser User { get; set; }
    }
}