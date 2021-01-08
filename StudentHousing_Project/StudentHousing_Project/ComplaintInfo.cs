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
    public partial class ComplaintInfo : Form
    {
        private Complaint complaint;
        public ComplaintInfo()
        {
            InitializeComponent();
        }
        public ComplaintInfo(Complaint complaint) : this()
        {
            this.complaint = complaint;
            lblTitle.Text = complaint.Subject;
            lblDescription.Text = complaint.Description;
            lblCreatedAt.Text = $"{complaint.CreatedAt.Date.Day}/{complaint.CreatedAt.Date.Month}/{complaint.CreatedAt.Date.Year}";
            if (complaint.IsRead)
            {
                lblStatus.Text = "Read";
            }
            else
            {
                lblStatus.Text = "Unread";
            }
        }
    }
}
