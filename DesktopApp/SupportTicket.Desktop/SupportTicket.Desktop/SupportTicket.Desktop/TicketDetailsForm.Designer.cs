namespace SupportTicket.Desktop
{
    partial class TicketDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Subject = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Priority = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.CreatedDate = new System.Windows.Forms.Label();
            this.AssignedAdmin = new System.Windows.Forms.Label();
            this.TicketNumber = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCreatedDate = new System.Windows.Forms.TextBox();
            this.lblAssignedAdmin = new System.Windows.Forms.TextBox();
            this.lblTicketNumber = new System.Windows.Forms.TextBox();
            this.cmbAssignAdmin = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.adAssignTo = new System.Windows.Forms.Label();
            this.adstatus = new System.Windows.Forms.Label();
            this.adcomment = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(137, 84);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(63, 20);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "Subject";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(137, 165);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(89, 20);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.Location = new System.Drawing.Point(137, 242);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(56, 20);
            this.Priority.TabIndex = 2;
            this.Priority.Text = "Priority";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(137, 301);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 20);
            this.Status.TabIndex = 3;
            this.Status.Text = "Status";
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSize = true;
            this.CreatedDate.Location = new System.Drawing.Point(137, 356);
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Size = new System.Drawing.Size(105, 20);
            this.CreatedDate.TabIndex = 4;
            this.CreatedDate.Text = "Created Date";
            // 
            // AssignedAdmin
            // 
            this.AssignedAdmin.AutoSize = true;
            this.AssignedAdmin.Location = new System.Drawing.Point(137, 410);
            this.AssignedAdmin.Name = "AssignedAdmin";
            this.AssignedAdmin.Size = new System.Drawing.Size(124, 20);
            this.AssignedAdmin.TabIndex = 5;
            this.AssignedAdmin.Text = "Assigned Admin";
            // 
            // TicketNumber
            // 
            this.TicketNumber.AutoSize = true;
            this.TicketNumber.Location = new System.Drawing.Point(137, 47);
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.Size = new System.Drawing.Size(111, 20);
            this.TicketNumber.TabIndex = 6;
            this.TicketNumber.Text = "Ticket Number";
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(273, 84);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(231, 26);
            this.lblSubject.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(273, 310);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(257, 26);
            this.lblStatus.TabIndex = 8;
            // 
            // lblPriority
            // 
            this.lblPriority.Location = new System.Drawing.Point(273, 242);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(231, 26);
            this.lblPriority.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(273, 135);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(231, 76);
            this.txtDescription.TabIndex = 10;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Location = new System.Drawing.Point(273, 356);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(257, 26);
            this.lblCreatedDate.TabIndex = 11;
            // 
            // lblAssignedAdmin
            // 
            this.lblAssignedAdmin.Location = new System.Drawing.Point(273, 407);
            this.lblAssignedAdmin.Name = "lblAssignedAdmin";
            this.lblAssignedAdmin.Size = new System.Drawing.Size(257, 26);
            this.lblAssignedAdmin.TabIndex = 12;
            // 
            // lblTicketNumber
            // 
            this.lblTicketNumber.Location = new System.Drawing.Point(273, 41);
            this.lblTicketNumber.Name = "lblTicketNumber";
            this.lblTicketNumber.Size = new System.Drawing.Size(231, 26);
            this.lblTicketNumber.TabIndex = 13;
            // 
            // cmbAssignAdmin
            // 
            this.cmbAssignAdmin.FormattingEnabled = true;
            this.cmbAssignAdmin.Location = new System.Drawing.Point(867, 44);
            this.cmbAssignAdmin.Name = "cmbAssignAdmin";
            this.cmbAssignAdmin.Size = new System.Drawing.Size(121, 28);
            this.cmbAssignAdmin.TabIndex = 14;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(867, 94);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 28);
            this.cmbStatus.TabIndex = 15;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(867, 135);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(231, 76);
            this.txtComment.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(867, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 44);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save Button";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // adAssignTo
            // 
            this.adAssignTo.AutoSize = true;
            this.adAssignTo.Location = new System.Drawing.Point(686, 52);
            this.adAssignTo.Name = "adAssignTo";
            this.adAssignTo.Size = new System.Drawing.Size(79, 20);
            this.adAssignTo.TabIndex = 18;
            this.adAssignTo.Text = "Assign To";
            // 
            // adstatus
            // 
            this.adstatus.AutoSize = true;
            this.adstatus.Location = new System.Drawing.Point(686, 102);
            this.adstatus.Name = "adstatus";
            this.adstatus.Size = new System.Drawing.Size(116, 20);
            this.adstatus.TabIndex = 19;
            this.adstatus.Text = "Change Status";
            // 
            // adcomment
            // 
            this.adcomment.AutoSize = true;
            this.adcomment.Location = new System.Drawing.Point(686, 165);
            this.adcomment.Name = "adcomment";
            this.adcomment.Size = new System.Drawing.Size(111, 20);
            this.adcomment.TabIndex = 20;
            this.adcomment.Text = "Add Comment";
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(175, 532);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 62;
            this.dgvHistory.RowTemplate.Height = 28;
            this.dgvHistory.Size = new System.Drawing.Size(590, 238);
            this.dgvHistory.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ticket History Section";
            // 
            // TicketDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1263, 998);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.adcomment);
            this.Controls.Add(this.adstatus);
            this.Controls.Add(this.adAssignTo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbAssignAdmin);
            this.Controls.Add(this.lblTicketNumber);
            this.Controls.Add(this.lblAssignedAdmin);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.TicketNumber);
            this.Controls.Add(this.AssignedAdmin);
            this.Controls.Add(this.CreatedDate);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Subject);
            this.Name = "TicketDetailsForm";
            this.Text = "TicketDetailsForm";
            this.Load += new System.EventHandler(this.TicketDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Priority;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label CreatedDate;
        private System.Windows.Forms.Label AssignedAdmin;
        private System.Windows.Forms.Label TicketNumber;
        private System.Windows.Forms.TextBox lblSubject;
        private System.Windows.Forms.TextBox lblStatus;
        private System.Windows.Forms.TextBox lblPriority;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox lblCreatedDate;
        private System.Windows.Forms.TextBox lblAssignedAdmin;
        private System.Windows.Forms.TextBox lblTicketNumber;
        private System.Windows.Forms.ComboBox cmbAssignAdmin;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label adAssignTo;
        private System.Windows.Forms.Label adstatus;
        private System.Windows.Forms.Label adcomment;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label label4;
    }
}