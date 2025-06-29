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
            txtFullname = new TextBox();
            txtContact = new TextBox();
            comboWaiting = new ComboBox();
            dtpWaiting = new DateTimePicker();
            btnQueue = new Button();
            pbLogo = new PictureBox();
            dgvCurrent = new DataGridView();
            dgvServing = new DataGridView();
            lblCurrent = new Label();
            lblServing = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServing).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Swis721 Blk BT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(323, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(487, 96);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(73, 158);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(156, 25);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer Details";
            // 
            // lblWaiting
            // 
            lblWaiting.AutoSize = true;
            lblWaiting.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaiting.Location = new Point(731, 157);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.Size = new Size(213, 25);
            lblWaiting.TabIndex = 2;
            lblWaiting.Text = "Waiting Time (Minutes)";
            // 
            // txtFullname
            // 
            txtFullname.BackColor = SystemColors.Window;
            txtFullname.ForeColor = SystemColors.ScrollBar;
            txtFullname.Location = new Point(99, 186);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(226, 27);
            txtFullname.TabIndex = 3;
            txtFullname.Text = "  Fullname*";
            // 
            // txtContact
            // 
            txtContact.ForeColor = SystemColors.ScrollBar;
            txtContact.Location = new Point(99, 231);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(226, 27);
            txtContact.TabIndex = 4;
            txtContact.Text = "  Contact Number*";
            // 
            // comboWaiting
            // 
            comboWaiting.FormattingEnabled = true;
            comboWaiting.Location = new Point(752, 185);
            comboWaiting.Name = "comboWaiting";
            comboWaiting.Size = new Size(226, 28);
            comboWaiting.TabIndex = 5;
            // 
            // dtpWaiting
            // 
            dtpWaiting.Location = new Point(752, 229);
            dtpWaiting.Name = "dtpWaiting";
            dtpWaiting.Size = new Size(226, 27);
            dtpWaiting.TabIndex = 6;
            // 
            // btnQueue
            // 
            btnQueue.BackColor = SystemColors.Desktop;
            btnQueue.Cursor = Cursors.Hand;
            btnQueue.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnQueue.ForeColor = SystemColors.ControlLightLight;
            btnQueue.Location = new Point(455, 266);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(168, 41);
            btnQueue.TabIndex = 7;
            btnQueue.Text = "Queue Customer";
            btnQueue.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.utensils_logo;
            pbLogo.Location = new Point(-29, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(197, 116);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // dgvCurrent
            // 
            dgvCurrent.BackgroundColor = SystemColors.WindowFrame;
            dgvCurrent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrent.Location = new Point(25, 351);
            dgvCurrent.Name = "dgvCurrent";
            dgvCurrent.RowHeadersWidth = 51;
            dgvCurrent.Size = new Size(565, 259);
            dgvCurrent.TabIndex = 9;
            // 
            // dgvServing
            // 
            dgvServing.BackgroundColor = SystemColors.WindowFrame;
            dgvServing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServing.Location = new Point(584, 351);
            dgvServing.Name = "dgvServing";
            dgvServing.RowHeadersWidth = 51;
            dgvServing.Size = new Size(495, 259);
            dgvServing.TabIndex = 10;
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrent.Location = new Point(25, 328);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(127, 23);
            lblCurrent.TabIndex = 11;
            lblCurrent.Text = "Current Queue";
            // 
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServing.Location = new Point(584, 328);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(114, 23);
            lblServing.TabIndex = 12;
            lblServing.Text = "Serving Now";
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1112, 631);
            Controls.Add(lblServing);
            Controls.Add(lblCurrent);
            Controls.Add(dgvServing);
            Controls.Add(dgvCurrent);
            Controls.Add(pbLogo);
            Controls.Add(btnQueue);
            Controls.Add(dtpWaiting);
            Controls.Add(comboWaiting);
            Controls.Add(txtContact);
            Controls.Add(txtFullname);
            Controls.Add(lblWaiting);
            Controls.Add(lblCustomer);
            Controls.Add(lblWelcome);
            Name = "UI";
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblCustomer;
        private Label lblWaiting;
        private TextBox txtFullname;
        private TextBox txtContact;
        private ComboBox comboWaiting;
        private DateTimePicker dtpWaiting;
        private Button btnQueue;
        private PictureBox pbLogo;
        private DataGridView dgvCurrent;
        private DataGridView dgvServing;
        private Label lblCurrent;
        private Label lblServing;
    }
}
