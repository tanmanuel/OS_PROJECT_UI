using System;
using System.Windows.Forms;

namespace OS_PROJECT_UI
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            InitializeCurrentQueueDGV(); // Ensure Current Queue DGV is set up
            InitializeServingNowDGV();   // Ensure Serving Now DGV is set up
        }

        private void InitializeCurrentQueueDGV()
        {
            // Clear existing columns just in case
            dgvCurrentQueue.Columns.Clear();

            // Add columns to dgvCurrentQueue
            dgvCurrentQueue.Columns.Add("colFullName", "Full Name");
            dgvCurrentQueue.Columns.Add("colContactNumber", "Contact Number");
            dgvCurrentQueue.Columns.Add("colQueueDate", "Queue Date");
            dgvCurrentQueue.Columns.Add("colWaitingTime", "Waiting Time (Minutes)");

            // Optional: Make columns auto-fill remaining space
            dgvCurrentQueue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Optional: Prevent users from adding or deleting rows directly
            dgvCurrentQueue.AllowUserToAddRows = false;
            dgvCurrentQueue.AllowUserToDeleteRows = false;
            dgvCurrentQueue.ReadOnly = true; // Make it read-only
            dgvCurrentQueue.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Allow full row selection
            dgvCurrentQueue.MultiSelect = false; // Only allow single row selection
        }

        private void InitializeServingNowDGV()
        {
            // Clear existing columns just in case
            dgvServingNow.Columns.Clear();

            // Add columns to dgvServingNow (should match dgvCurrentQueue)
            dgvServingNow.Columns.Add("colFullName", "Full Name");
            dgvServingNow.Columns.Add("colContactNumber", "Contact Number");
            dgvServingNow.Columns.Add("colQueueDate", "Queue Date");
            dgvServingNow.Columns.Add("colWaitingTime", "Waiting Time (Minutes)");

            // Optional: Make columns auto-fill remaining space
            dgvServingNow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Optional: Prevent users from adding or deleting rows directly
            dgvServingNow.AllowUserToAddRows = false;
            dgvServingNow.AllowUserToDeleteRows = false;
            dgvServingNow.ReadOnly = true; // Make it read-only
        }


        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Get customer details from input fields
            string fullName = txtFullName.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            DateTime queueDate = dtpDate.Value; // Assuming dtpDate is your DateTimePicker
            string waitingTime = txtWaitingTime.Text.Trim(); // Assuming txtWaitingMinutes is your textbox for waiting time

            // Basic validation
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

            // Add a new row to the dgvCurrentQueue DataGridView
            dgvCurrentQueue.Rows.Add(fullName, contactNumber, queueDate.ToShortDateString(), waitingTime);

            // Clear the input fields after queuing the customer
            txtFullName.Clear();
            txtContactNumber.Clear();
            txtWaitingTime.Clear();
            dtpDate.Value = DateTime.Now; // Reset date picker to current date

            MessageBox.Show("Customer added to the queue successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // New method for the "Next" button click
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check if there are any customers in the current queue
            if (dgvCurrentQueue.Rows.Count == 0)
            {
                MessageBox.Show("The queue is empty. No customer to serve next.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // In a queue system, "Next" typically means taking the first person in line (index 0).
            // If you want to allow serving a *selected* person, you would use dgvCurrentQueue.SelectedRows[0]
            // and add checks for selection. For a simple "Next" button in a queue, index 0 is common.
            DataGridViewRow customerToServe = dgvCurrentQueue.Rows[0];

            // Get the data from the current queue row
            string fullName = customerToServe.Cells["colFullName"].Value?.ToString();
            string contactNumber = customerToServe.Cells["colContactNumber"].Value?.ToString();
            string queueDate = customerToServe.Cells["colQueueDate"].Value?.ToString();
            string waitingTime = customerToServe.Cells["colWaitingTime"].Value?.ToString();

            // Check if dgvServingNow already has a customer.
            // If so, you might want to move them out or prevent serving another
            // until the current one is "done". For simplicity, we'll replace/add.
            // A more robust system would likely have a "Finish Serving" button.
            if (dgvServingNow.Rows.Count > 0)
            {
                // Option 1: Clear the "Serving Now" DGV before adding a new one
                dgvServingNow.Rows.Clear();
                // Option 2: Add to a list of served customers if dgvServingNow tracks history
                // For this scenario, we'll clear and show only the *current* serving customer.
            }

            // Add the customer details to the "Serving Now" DataGridView
            dgvServingNow.Rows.Add(fullName, contactNumber, queueDate, waitingTime);

            // Remove the customer from the "Current Queue" DataGridView
            dgvCurrentQueue.Rows.RemoveAt(0); // Remove the first row

            MessageBox.Show($"'{fullName}' is now being served!", "Customer Served", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Make sure to implement the btnServe_Click if you intend to use that button
        // private void btnServe_Click(object sender, EventArgs e)
        // {
        //     // This button might be used to clear the "Serving Now" DGV,
        //     // or move the customer to a "Served History" DGV.
        //     if (dgvServingNow.Rows.Count > 0)
        //     {
        //         string servedCustomer = dgvServingNow.Rows[0].Cells["colFullName"].Value?.ToString();
        //         dgvServingNow.Rows.Clear();
        //         MessageBox.Show($"'{servedCustomer}' has finished being served.", "Service Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //     }
        //     else
        //     {
        //         MessageBox.Show("No customer is currently being served.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //     }
        // }
    }
}