using System;

namespace Reminders.Controllers
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Reminder(int id, string name, DateTime date)
        {
            this.Id = id;
            this.Name = name;
            this.Date = date;
        }
    }
}