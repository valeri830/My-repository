using System;

namespace StudentHousing_Project
{
    public class Event
    {
        private string title;
        private string description;

        public Event(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public DateTime CreatedAt => DateTime.Now;

        public string Description
        {
            get { return description; }
            private set
            {
                description = value;
            }
        }
        public string Title
        {
            get { return title; }
            private set
            {
                if (value.Length < 5 || value.Length > 20)
                {
                    throw new ArgumentException("Please provide an event title in (5 - 20) character range");
                }
                title = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Title}: {this.CreatedAt}";
        }
    }
}