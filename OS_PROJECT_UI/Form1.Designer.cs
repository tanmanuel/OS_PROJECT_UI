namespace OS_PROJECT_UI
{
    partial class UI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblCustomer = new Label();
            lblWaiting = new Label();
            txtFullName = new TextBox();
            txtContactNumber = new TextBox();
            dtpDate = new DateTimePicker();
            btnQueue = new Button();
            pbLogo = new PictureBox();
            dgvCurrentQueue = new DataGridView();
            dgvServingNow = new DataGridView();
            lblCurrent = new Label();
            lblServing = new Label();
            txtWaitingTime = new TextBox();
            lblDining = new Label();
            btnServe = new Button();
            btnNext = new Button();
            txtDiningTime = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentQueue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServingNow).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(283, 14);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(363, 73);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(66, 98);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(129, 20);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer Details";
            // 
            // lblWaiting
            // 
            lblWaiting.AutoSize = true;
            lblWaiting.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaiting.Location = new Point(294, 98);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.Size = new Size(175, 20);
            lblWaiting.TabIndex = 2;
            lblWaiting.Text = "Waiting Time (Minutes)";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.Window;
            txtFullName.ForeColor = SystemColors.InfoText;
            txtFullName.Location = new Point(66, 119);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(198, 23);
            txtFullName.TabIndex = 3;
            txtFullName.Text = "  Fullname*";
            // 
            // txtContactNumber
            // 
            txtContactNumber.ForeColor = SystemColors.InfoText;
            txtContactNumber.Location = new Point(66, 148);
            txtContactNumber.Margin = new Padding(3, 2, 3, 2);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(198, 23);
            txtContactNumber.TabIndex = 4;
            txtContactNumber.Text = "  Contact Number*";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(294, 148);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(198, 23);
            dtpDate.TabIndex = 6;
            // 
            // btnQueue
            // 
            btnQueue.BackColor = SystemColors.Desktop;
            btnQueue.Cursor = Cursors.Hand;
            btnQueue.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnQueue.ForeColor = SystemColors.ControlLightLight;
            btnQueue.Location = new Point(345, 175);
            btnQueue.Margin = new Padding(3, 2, 3, 2);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(147, 31);
            btnQueue.TabIndex = 7;
            btnQueue.Text = "Queue Customer";
            btnQueue.UseVisualStyleBackColor = false;
            btnQueue.Click += btnQueue_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.utensils_logo;
            pbLogo.Location = new Point(-25, 9);
            pbLogo.Margin = new Padding(3, 2, 3, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(158, 70);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // dgvCurrentQueue
            // 
            dgvCurrentQueue.BackgroundColor = SystemColors.WindowFrame;
            dgvCurrentQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentQueue.Location = new Point(33, 280);
            dgvCurrentQueue.Margin = new Padding(3, 2, 3, 2);
            dgvCurrentQueue.Name = "dgvCurrentQueue";
            dgvCurrentQueue.RowHeadersWidth = 51;
            dgvCurrentQueue.Size = new Size(459, 194);
            dgvCurrentQueue.TabIndex = 9;
            // 
            // dgvServingNow
            // 
            dgvServingNow.BackgroundColor = SystemColors.WindowFrame;
            dgvServingNow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServingNow.Location = new Point(498, 280);
            dgvServingNow.Margin = new Padding(3, 2, 3, 2);
            dgvServingNow.Name = "dgvServingNow";
            dgvServingNow.RowHeadersWidth = 51;
            dgvServingNow.Size = new Size(460, 194);
            dgvServingNow.TabIndex = 10;
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrent.Location = new Point(33, 259);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(106, 19);
            lblCurrent.TabIndex = 11;
            lblCurrent.Text = "Current Queue";
            // 
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServing.Location = new Point(498, 259);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(96, 19);
            lblServing.TabIndex = 12;
            lblServing.Text = "Serving Now";
            // 
            // txtWaitingTime
            // 
            txtWaitingTime.Location = new Point(294, 119);
            txtWaitingTime.Margin = new Padding(3, 2, 3, 2);
            txtWaitingTime.Name = "txtWaitingTime";
            txtWaitingTime.Size = new Size(198, 23);
            txtWaitingTime.TabIndex = 13;
            // 
            // lblDining
            // 
            lblDining.AutoSize = true;
            lblDining.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDining.Location = new Point(578, 98);
            lblDining.Name = "lblDining";
            lblDining.Size = new Size(167, 20);
            lblDining.TabIndex = 14;
            lblDining.Text = "Dining Time (Minutes)";
            // 
            // btnServe
            // 
            btnServe.BackColor = SystemColors.Desktop;
            btnServe.Cursor = Cursors.Hand;
            btnServe.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnServe.ForeColor = SystemColors.ControlLightLight;
            btnServe.Location = new Point(780, 175);
            btnServe.Margin = new Padding(3, 2, 3, 2);
            btnServe.Name = "btnServe";
            btnServe.Size = new Size(147, 31);
            btnServe.TabIndex = 15;
            btnServe.Text = "Finish Customer";
            btnServe.UseVisualStyleBackColor = false;
            btnServe.Click += btnServe_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.Desktop;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ControlLightLight;
            btnNext.Location = new Point(578, 175);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(147, 31);
            btnNext.TabIndex = 16;
            btnNext.Text = "Serve Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // txtDiningTime
            // 
            txtDiningTime.Location = new Point(578, 120);
            txtDiningTime.Margin = new Padding(3, 2, 3, 2);
            txtDiningTime.Name = "txtDiningTime";
            txtDiningTime.Size = new Size(198, 23);
            txtDiningTime.TabIndex = 17;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(990, 507);
            Controls.Add(txtDiningTime);
            Controls.Add(btnNext);
            Controls.Add(btnServe);
            Controls.Add(lblDining);
            Controls.Add(txtWaitingTime);
            Controls.Add(lblServing);
            Controls.Add(lblCurrent);
            Controls.Add(dgvServingNow);
            Controls.Add(dgvCurrentQueue);
            Controls.Add(pbLogo);
            Controls.Add(btnQueue);
            Controls.Add(dtpDate);
            Controls.Add(txtContactNumber);
            Controls.Add(txtFullName);
            Controls.Add(lblWaiting);
            Controls.Add(lblCustomer);
            Controls.Add(lblWelcome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentQueue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServingNow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblCustomer;
        private Label lblWaiting;
        private TextBox txtFullName;
        private TextBox txtContactNumber;
        private ComboBox comboEating;
        private DateTimePicker dtpDate;
        private Button btnQueue;
        private PictureBox pbLogo;
        private DataGridView dgvCurrentQueue;
        private DataGridView dgvServingNow;
        private Label lblCurrent;
        private Label lblServing;
        private TextBox txtWaitingTime;
        private Label lblDining;
        private Button btnServe;
        private Button btnNext;
        private TextBox txtDiningTime;
    }
}
