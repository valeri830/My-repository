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
    public partial class MainForm : Form
    {
        private List<Event> listOfEvents;
        private List<Complaint> listOfComplaints;
        //Predefined house rules
        private List<string> listOfRules = new List<string>
        {
            "No smoking inside your room",
            "Do not leave dirty dishes in the sink",
            "Do not disturb your housemates after 11PM"
        };
        public MainForm(bool isAdmin)
        {
            listOfEvents = new List<Event>();
            listOfComplaints = new List<Complaint>();
            InitializeComponent();

            // Set colors
            // Form background color
            this.BackColor = ColorPalette.White;

            // Dashboard panel
            SetDashboardPanelColors();

            // Admin panel
            SetAdminPanelColors();

            // House rules panel
            SetHouseRulesPanelColors();

            // New Panel
            SetNewPanelColors();

            tcMain.DrawItem += new DrawItemEventHandler(tcMain_DrawItem);
            ShowRules();
            if (!isAdmin)
            {
                tcMain.TabPages.RemoveAt(tcMain.TabPages.IndexOf(tpAdminPanel));
            }
        }

        // Stolen from Microsoft
        private void tcMain_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tcMain.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tcMain.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Selected tab text color
                _textBrush = new SolidBrush(ColorPalette.White);
                // Selected tab background color
                g.FillRectangle(new SolidBrush(ColorPalette.DarkBlue), e.Bounds);
            }
            else
            {
                // Rest of tabs text color
                _textBrush = new SolidBrush(ColorPalette.SemiDarkBlue);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Segoe UI", 16.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void SetDashboardPanelColors()
        {
            tpDashboard.BackColor = ColorPalette.White;
            lblDashboard.ForeColor = ColorPalette.DarkBlue;
            lbEvents.ForeColor = ColorPalette.SemiDarkBlue;
            lbEvents.BackColor = ColorPalette.LightBlue;
            panelLBEventsBorder.BackColor = ColorPalette.DarkBlue;

            btnEventInfo.BackColor = ColorPalette.LightBlue;
            btnEventInfo.ForeColor = ColorPalette.SemiDarkBlue;
            btnEventInfo.FlatAppearance.BorderColor = ColorPalette.DarkBlue;

            btnDeleteEvent.BackColor = ColorPalette.LightBlue;
            btnDeleteEvent.ForeColor = ColorPalette.SemiDarkBlue;
            btnDeleteEvent.FlatAppearance.BorderColor = ColorPalette.DarkBlue;
        }

        private void SetAdminPanelColors()
        {
            lblAdminPanel.ForeColor = ColorPalette.DarkBlue;
            tpAdminPanel.BackColor = ColorPalette.White;

            lbComplaints.ForeColor = ColorPalette.SemiDarkBlue;
            lbComplaints.BackColor = ColorPalette.LightBlue;
            panelLBComplaintsBorder.BackColor = ColorPalette.DarkBlue;

            btnShowMore.BackColor = ColorPalette.LightBlue;
            btnShowMore.ForeColor = ColorPalette.SemiDarkBlue;
            btnShowMore.FlatAppearance.BorderColor = ColorPalette.DarkBlue;

            btnMarkAsRead.BackColor = ColorPalette.LightBlue;
            btnMarkAsRead.ForeColor = ColorPalette.SemiDarkBlue;
            btnMarkAsRead.FlatAppearance.BorderColor = ColorPalette.DarkBlue;

            btnDeleteComplaint.BackColor = ColorPalette.LightBlue;
            btnDeleteComplaint.ForeColor = ColorPalette.SemiDarkBlue;
            btnDeleteComplaint.FlatAppearance.BorderColor = ColorPalette.DarkBlue;

            rbShowAll.ForeColor = ColorPalette.DarkBlue;
            rbShowRead.ForeColor = ColorPalette.DarkBlue;
            rbUnread.ForeColor = ColorPalette.DarkBlue;
        }

        private void SetHouseRulesPanelColors()
        {
            tpHouseRules.BackColor = ColorPalette.White;
            lblHouseRules.ForeColor = ColorPalette.DarkBlue;

            lbHouseRules.ForeColor = ColorPalette.SemiDarkBlue;
            lbHouseRules.BackColor = ColorPalette.LightBlue;
            panelLBHouseRulesBorder.BackColor = ColorPalette.DarkBlue;

            btnAddRule.BackColor = ColorPalette.LightBlue;
            btnAddRule.ForeColor = ColorPalette.SemiDarkBlue;
            btnAddRule.FlatAppearance.BorderColor = ColorPalette.DarkBlue;

            btnDeleteRule.BackColor = ColorPalette.LightBlue;
            btnDeleteRule.ForeColor = ColorPalette.SemiDarkBlue;
            btnDeleteRule.FlatAppearance.BorderColor = ColorPalette.DarkBlue;

            tbNewRule.BackColor = ColorPalette.LightBlue;
            tbNewRule.ForeColor = ColorPalette.SemiDarkBlue;
            panelTBnewRuleBorder.BackColor = ColorPalette.DarkBlue;
        }

        private void SetNewPanelColors()
        {
            tpCreate.BackColor = ColorPalette.White;
            lblNew.ForeColor = ColorPalette.DarkBlue;

            rbComplaint.ForeColor = ColorPalette.DarkBlue;
            rbEvent.ForeColor = ColorPalette.DarkBlue;

            tbTitle.BackColor = ColorPalette.LightBlue;
            tbTitle.ForeColor = ColorPalette.SemiDarkBlue;
            panelTBtitleBorder.BackColor = ColorPalette.DarkBlue;

            btnCreate.ForeColor = ColorPalette.SemiDarkBlue;
            btnCreate.BackColor = ColorPalette.LightBlue;
            btnCreate.FlatAppearance.BorderColor = ColorPalette.DarkBlue;

            lblTitle.ForeColor = ColorPalette.DarkBlue;
            lblDescription.ForeColor = ColorPalette.DarkBlue;

            rtbDescription.BackColor = ColorPalette.LightBlue;
            rtbDescription.ForeColor = ColorPalette.SemiDarkBlue;
            panelRTBdescriptionBorder.BackColor = ColorPalette.DarkBlue;
        }

        // Create "New" panel
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string description = rtbDescription.Text;
            if (rbComplaint.Checked)
            {
                try
                {
                    Complaint currentComplaint = new Complaint(title, description);
                    listOfComplaints.Add(currentComplaint);
                    tbTitle.Text = String.Empty;
                    rtbDescription.Text = String.Empty;
                    ShowAllComplaints();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (rbEvent.Checked)
            {
                try
                {
                    Event currentEvent = new Event(title, description);
                    listOfEvents.Add(currentEvent);
                    tbTitle.Text = string.Empty;
                    rtbDescription.Text = string.Empty;
                    ShowAllEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // Dashboard panel
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (lbEvents.SelectedItem != null)
            {
                string currentEvent = lbEvents.SelectedItem.ToString().Split(':')[0];
                if (FindEvent(currentEvent) != null)
                {
                    DeleteEvent(currentEvent);
                }
                else
                {
                    MessageBox.Show("Please select a complaint first");
                }
            }
        }

        // House rules panel
        private void btnAddRule_Click(object sender, EventArgs e)
        {
            string rule = tbNewRule.Text;
            if (!String.IsNullOrEmpty(rule))
            {
                listOfRules.Add(rule);
                tbNewRule.Text = string.Empty;
            }
            ShowRules();
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            if (lbHouseRules.SelectedItem != null)
            {
                string currentRule = lbHouseRules.SelectedItem.ToString().Substring(2).TrimStart();
                listOfRules.Remove(currentRule);
                ShowRules();
            }
            else
            {
                MessageBox.Show("Please select a complaint first");
            }
        }
        //helping methods
        private Event FindEvent(string currentEvent)
        {
            foreach (Event checkEvent in listOfEvents)
            {
                if (checkEvent.Title == currentEvent)
                {
                    return checkEvent;
                }
            }
            return null;
        }

        private void DeleteEvent(string currentEvent)
        {
            Event eventToDelete = FindEvent(currentEvent);
            foreach (Event getEvent in listOfEvents)
            {
                if (getEvent == eventToDelete)
                {
                    listOfEvents.Remove(getEvent);
                    break;
                }
            }
            ShowAllEvents();
        }

        // methods related to table viewing
        private void ShowAllEvents()
        {
            lbEvents.Items.Clear();
            foreach (Event currentEvent in listOfEvents)
            {
                lbEvents.Items.Add(currentEvent);
            }
        }

        private void ShowAllComplaints()
        {
            lbComplaints.Items.Clear();
            if (rbShowAll.Checked)
            {
                foreach (Complaint currentComplaint in listOfComplaints)
                {
                    lbComplaints.Items.Add(currentComplaint);
                }
            }
            else if (rbShowRead.Checked)
            {
                foreach (Complaint complaint in listOfComplaints.Where(c => c.IsRead))
                {
                    lbComplaints.Items.Add(complaint);
                }
            }
            else if (rbUnread.Checked)
            {
                foreach (Complaint complaint in listOfComplaints.Where(c => !c.IsRead))
                {
                    lbComplaints.Items.Add(complaint);
                }
            }
            
        }

        private void ShowRules()
        {
            int count = 0;
            lbHouseRules.Items.Clear();
            foreach (string rule in listOfRules)
            {
                count++;
                lbHouseRules.Items.Add($"{count}| {rule}");
            }
        }

        private void btnEventInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Event currentEvent = (Event)lbEvents.SelectedItem;
                EventInfo eventInfoForm = new EventInfo(currentEvent);
                eventInfoForm.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an event first.");
            }
        }

        private void btnShowMore_Click(object sender, EventArgs e)
        {
            try
            {
                Complaint currentComplaint = (Complaint)lbComplaints.SelectedItem;
                ComplaintInfo complaintInfoForm = new ComplaintInfo(currentComplaint);
                complaintInfoForm.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a complaint first.");
            }
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            Complaint selectedComplaint = (Complaint)lbComplaints.SelectedItem;
            if (selectedComplaint != null)
            {
                listOfComplaints.Remove(selectedComplaint);
                ShowAllComplaints();
            }
            else
            {
                MessageBox.Show("Please select a complaint first");
            }
        }

        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            Complaint selectedItem = (Complaint)lbComplaints.SelectedItem;
            Complaint selectedComplaint =  listOfComplaints.Find(c => c.Subject == selectedItem.Subject && c.CreatedAt == selectedItem.CreatedAt);
            if (selectedComplaint != null)
            {
                selectedComplaint.MarkAsRead();
            }
        }

        private void rbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            ShowAllComplaints();
        }

        private void rbShowRead_CheckedChanged(object sender, EventArgs e)
        {
            ShowAllComplaints();
        }

        private void rbUnread_CheckedChanged(object sender, EventArgs e)
        {
            ShowAllComplaints();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
