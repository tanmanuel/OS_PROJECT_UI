using System;
using System.Windows.Forms;

namespace OS_PROJECT_UI
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            InitializeCurrentQueueDGV(); 
            InitializeServingNowDGV();  
        }

        private void InitializeCurrentQueueDGV()
        {
            dgvCurrentQueue.Columns.Clear();

            dgvCurrentQueue.Columns.Add("colFullName", "Full Name");
            dgvCurrentQueue.Columns.Add("colContactNumber", "Contact Number");
            dgvCurrentQueue.Columns.Add("colQueueDate", "Queue Date");
            dgvCurrentQueue.Columns.Add("colWaitingTime", "Waiting Time (Minutes)");

            dgvCurrentQueue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentQueue.AllowUserToAddRows = false;
            dgvCurrentQueue.AllowUserToDeleteRows = false;
            dgvCurrentQueue.ReadOnly = true; 
            dgvCurrentQueue.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgvCurrentQueue.MultiSelect = false;
        }

        private void InitializeServingNowDGV()
        {
            dgvServingNow.Columns.Clear();

            dgvServingNow.Columns.Add("colFullName", "Full Name");
            dgvServingNow.Columns.Add("colContactNumber", "Contact Number");
            dgvServingNow.Columns.Add("colQueueDate", "Queue Date");
            dgvServingNow.Columns.Add("colDiningTime", "Dining Time (Minutes)");

            dgvServingNow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServingNow.AllowUserToAddRows = false;
            dgvServingNow.AllowUserToDeleteRows = false;
            dgvServingNow.ReadOnly = true;
        }


        private void btnQueue_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            DateTime queueDate = dtpDate.Value; 
            string waitingTime = txtWaitingTime.Text.Trim();
            string diningTime = txtDiningTime.Text.Trim();

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please enter the customer's Full Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("Please enter the customer's Contact Number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNumber.Focus();
                return;
            }

            if (string.IsNullOrEmpty(waitingTime))
            {
                MessageBox.Show("Please enter the Waiting Time.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWaitingTime.Focus();
                return;
            }

            if (!int.TryParse(waitingTime, out int minutes))
            {
                MessageBox.Show("Please enter a valid number for Waiting Time.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWaitingTime.Focus();
                return;
            }

            if (string.IsNullOrEmpty(diningTime))
            {
                MessageBox.Show("Please enter the Waiting Time.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWaitingTime.Focus();
                return;
            }

            dgvCurrentQueue.Rows.Add(fullName, contactNumber, queueDate.ToShortDateString(), waitingTime, diningTime);

            txtFullName.Clear();
            txtContactNumber.Clear();
            txtWaitingTime.Clear();
            dtpDate.Value = DateTime.Now; 

            MessageBox.Show("Customer added to the queue successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dgvCurrentQueue.Rows.Count == 0)
            {
                MessageBox.Show("The queue is empty. No customer to serve next.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow customerToServe = dgvCurrentQueue.Rows[0];

            string fullName = customerToServe.Cells["colFullName"].Value?.ToString();
            string contactNumber = customerToServe.Cells["colContactNumber"].Value?.ToString();
            string queueDate = customerToServe.Cells["colQueueDate"].Value?.ToString();
            string diningTime = customerToServe.Cells["colWaitingTime"].Value?.ToString();

            if (dgvServingNow.Rows.Count > 0)
            {
                dgvServingNow.Rows.Clear();
            }

            dgvServingNow.Rows.Add(fullName, contactNumber, queueDate, diningTime);

            dgvCurrentQueue.Rows.RemoveAt(0);

            MessageBox.Show($"'{fullName}' is now being served!", "Customer Served", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnServe_Click(object sender, EventArgs e)
        {
            if (dgvServingNow.Rows.Count == 0)
            {
                MessageBox.Show("No customer is currently being served.", "Serve Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string fullName = dgvServingNow.Rows[0].Cells["colFullName"].Value?.ToString();

            dgvServingNow.Rows.RemoveAt(0);

            MessageBox.Show($"{fullName} has finished and is removed from serving.", "Serve Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}