using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing_Project
{
    public partial class EventInfo : Form
    {
        private Event @event;
        public EventInfo()
        {
            InitializeComponent();
        }
        public EventInfo(Event @event) : this()
        {
            this.@event = @event;
            lblTitle.Text = @event.Title;
            lblDescription.Text = @event.Description;
            lblDateCreated.Text = $"{@event.CreatedAt.Date.Day}/{@event.CreatedAt.Date.Month}/{@event.CreatedAt.Date.Year}";
        }
    }
}
