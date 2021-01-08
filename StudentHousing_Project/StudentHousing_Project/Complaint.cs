using System;

namespace StudentHousing_Project
{
    public class Complaint
    {
        private string subject;
        private string description;
        private bool isRead;

        public Complaint(string subject, string description)
        {
            this.Subject = subject;
            this.Description = description;
            this.IsRead = false;
        }
        public DateTime CreatedAt => DateTime.Now;
        public bool IsRead
        {
            get { return isRead; }
            private set { isRead = value; }
        }
        public string Description
        {
            get { return description; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description cannot be empty.");
                }
                description = value;
            }
        }

        public string Subject
        {
            get { return subject; }
            private set
            {
                if (value.Length < 5 || value.Length > 20)
                {
                    throw new ArgumentException("Please provide a complaint subject in (5 - 20) character range");
                }
                subject = value;
            }
        }

        public void MarkAsRead()
        {
            this.IsRead = !this.IsRead; //Flipping a boolean value
            /*Not sure if it works. In case it doesn't: 
            if (this.IsRead)
            {
                this.IsRead = false;
            }
            else
            {
                this.IsRead = true;
            }
            */
        }

        public override string ToString()
        {
            return $"{this.Subject}: {this.CreatedAt}";
        }
    }
}