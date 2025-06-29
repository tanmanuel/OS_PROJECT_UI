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
            comboEating = new ComboBox();
            dtpDate = new DateTimePicker();
            btnQueue = new Button();
            pbLogo = new PictureBox();
            dgvCurrentQueue = new DataGridView();
            dgvServing = new DataGridView();
            lblCurrent = new Label();
            lblServing = new Label();
            txtWaitingTime = new TextBox();
            lblEating = new Label();
            btnServe = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentQueue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServing).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(323, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(452, 91);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(75, 131);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(156, 25);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer Details";
            // 
            // lblWaiting
            // 
            lblWaiting.AutoSize = true;
            lblWaiting.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaiting.Location = new Point(336, 131);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.Size = new Size(213, 25);
            lblWaiting.TabIndex = 2;
            lblWaiting.Text = "Waiting Time (Minutes)";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.Window;
            txtFullName.ForeColor = SystemColors.InfoText;
            txtFullName.Location = new Point(75, 159);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(226, 27);
            txtFullName.TabIndex = 3;
            txtFullName.Text = "  Fullname*";
            // 
            // txtContactNumber
            // 
            txtContactNumber.ForeColor = SystemColors.InfoText;
            txtContactNumber.Location = new Point(75, 197);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(226, 27);
            txtContactNumber.TabIndex = 4;
            txtContactNumber.Text = "  Contact Number*";
            // 
            // comboEating
            // 
            comboEating.FormattingEnabled = true;
            comboEating.Location = new Point(660, 159);
            comboEating.Name = "comboEating";
            comboEating.Size = new Size(226, 28);
            comboEating.TabIndex = 5;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(336, 197);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(226, 27);
            dtpDate.TabIndex = 6;
            // 
            // btnQueue
            // 
            btnQueue.BackColor = SystemColors.Desktop;
            btnQueue.Cursor = Cursors.Hand;
            btnQueue.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnQueue.ForeColor = SystemColors.ControlLightLight;
            btnQueue.Location = new Point(394, 230);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(168, 41);
            btnQueue.TabIndex = 7;
            btnQueue.Text = "Queue Customer";
            btnQueue.UseVisualStyleBackColor = false;
            btnQueue.Click += btnQueue_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.utensils_logo;
            pbLogo.Location = new Point(-29, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(181, 94);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // dgvCurrentQueue
            // 
            dgvCurrentQueue.BackgroundColor = SystemColors.WindowFrame;
            dgvCurrentQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentQueue.Location = new Point(25, 373);
            dgvCurrentQueue.Name = "dgvCurrentQueue";
            dgvCurrentQueue.RowHeadersWidth = 51;
            dgvCurrentQueue.Size = new Size(565, 259);
            dgvCurrentQueue.TabIndex = 9;
            // 
            // dgvServing
            // 
            dgvServing.BackgroundColor = SystemColors.WindowFrame;
            dgvServing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServing.Location = new Point(584, 373);
            dgvServing.Name = "dgvServing";
            dgvServing.RowHeadersWidth = 51;
            dgvServing.Size = new Size(495, 259);
            dgvServing.TabIndex = 10;
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrent.Location = new Point(25, 347);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(127, 23);
            lblCurrent.TabIndex = 11;
            lblCurrent.Text = "Current Queue";
            // 
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServing.Location = new Point(584, 347);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(114, 23);
            lblServing.TabIndex = 12;
            lblServing.Text = "Serving Now";
            // 
            // txtWaitingTime
            // 
            txtWaitingTime.Location = new Point(336, 159);
            txtWaitingTime.Name = "txtWaitingTime";
            txtWaitingTime.Size = new Size(226, 27);
            txtWaitingTime.TabIndex = 13;
            // 
            // lblEating
            // 
            lblEating.AutoSize = true;
            lblEating.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEating.Location = new Point(660, 131);
            lblEating.Name = "lblEating";
            lblEating.Size = new Size(201, 25);
            lblEating.TabIndex = 14;
            lblEating.Text = "Eating Time (Minutes)";
            // 
            // btnServe
            // 
            btnServe.BackColor = SystemColors.Desktop;
            btnServe.Cursor = Cursors.Hand;
            btnServe.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnServe.ForeColor = SystemColors.ControlLightLight;
            btnServe.Location = new Point(890, 230);
            btnServe.Name = "btnServe";
            btnServe.Size = new Size(168, 41);
            btnServe.TabIndex = 15;
            btnServe.Text = "Serve";
            btnServe.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.Desktop;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ControlLightLight;
            btnNext.Location = new Point(660, 230);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(168, 41);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1131, 676);
            Controls.Add(btnNext);
            Controls.Add(btnServe);
            Controls.Add(lblEating);
            Controls.Add(txtWaitingTime);
            Controls.Add(lblServing);
            Controls.Add(lblCurrent);
            Controls.Add(dgvServing);
            Controls.Add(dgvCurrentQueue);
            Controls.Add(pbLogo);
            Controls.Add(btnQueue);
            Controls.Add(dtpDate);
            Controls.Add(comboEating);
            Controls.Add(txtContactNumber);
            Controls.Add(txtFullName);
            Controls.Add(lblWaiting);
            Controls.Add(lblCustomer);
            Controls.Add(lblWelcome);
            Name = "UI";
            Text = "UI";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentQueue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServing).EndInit();
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
        private DataGridView dgvServing;
        private Label lblCurrent;
        private Label lblServing;
        private TextBox txtWaitingTime;
        private Label lblEating;
        private Button btnServe;
        private Button btnNext;
    }
}
