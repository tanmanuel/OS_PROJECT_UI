using Microsoft.VisualBasic;

namespace OS_PROJECT_UI
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            // Initialize DataGridView columns programmatically if not done in designer
            InitializeCurrentQueueDGV();
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

            // You might want to add more robust validation for waitingTime (e.g., ensure it's a number)
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
            // Reset date picker to current date if desired, or leave it as is
            dtpDate.Value = DateTime.Now;

            MessageBox.Show("Customer added to the queue successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}