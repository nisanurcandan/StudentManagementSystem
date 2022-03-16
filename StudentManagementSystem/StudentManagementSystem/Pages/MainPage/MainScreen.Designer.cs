
namespace StudentManagementSystem.Pages.MainPage
{
    partial class MainScreen
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
            this.myPersonalInfoButton = new System.Windows.Forms.Button();
            this.getTopStudentInfoButton = new System.Windows.Forms.Button();
            this.myAcademiInfoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myMessagesButton = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myPersonalInfoButton
            // 
            this.myPersonalInfoButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.myPersonalInfoButton.Location = new System.Drawing.Point(12, 111);
            this.myPersonalInfoButton.Name = "myPersonalInfoButton";
            this.myPersonalInfoButton.Size = new System.Drawing.Size(255, 61);
            this.myPersonalInfoButton.TabIndex = 1;
            this.myPersonalInfoButton.Text = "My Personal Info";
            this.myPersonalInfoButton.UseVisualStyleBackColor = true;
            this.myPersonalInfoButton.Click += new System.EventHandler(this.myPersonalInfoButton_Click);
            // 
            // getTopStudentInfoButton
            // 
            this.getTopStudentInfoButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.getTopStudentInfoButton.Location = new System.Drawing.Point(12, 312);
            this.getTopStudentInfoButton.Name = "getTopStudentInfoButton";
            this.getTopStudentInfoButton.Size = new System.Drawing.Size(255, 61);
            this.getTopStudentInfoButton.TabIndex = 2;
            this.getTopStudentInfoButton.Text = "Get Top Student Info";
            this.getTopStudentInfoButton.UseVisualStyleBackColor = true;
            this.getTopStudentInfoButton.Click += new System.EventHandler(this.getTopStudentInfoButton_Click);
            // 
            // myAcademiInfoButton
            // 
            this.myAcademiInfoButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.myAcademiInfoButton.Location = new System.Drawing.Point(12, 178);
            this.myAcademiInfoButton.Name = "myAcademiInfoButton";
            this.myAcademiInfoButton.Size = new System.Drawing.Size(255, 61);
            this.myAcademiInfoButton.TabIndex = 3;
            this.myAcademiInfoButton.Text = "My Academic Info";
            this.myAcademiInfoButton.UseVisualStyleBackColor = true;
            this.myAcademiInfoButton.Click += new System.EventHandler(this.myAcademiInfoButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(287, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 403);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // myMessagesButton
            // 
            this.myMessagesButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.myMessagesButton.Location = new System.Drawing.Point(12, 245);
            this.myMessagesButton.Name = "myMessagesButton";
            this.myMessagesButton.Size = new System.Drawing.Size(255, 61);
            this.myMessagesButton.TabIndex = 5;
            this.myMessagesButton.Text = "My Messages";
            this.myMessagesButton.UseVisualStyleBackColor = true;
            this.myMessagesButton.Click += new System.EventHandler(this.myMessagesButton_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.welcomeText.Location = new System.Drawing.Point(13, 21);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(206, 34);
            this.welcomeText.TabIndex = 6;
            this.welcomeText.Text = "Welcome, User!";
            this.welcomeText.Click += new System.EventHandler(this.welcomeText_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.myMessagesButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myAcademiInfoButton);
            this.Controls.Add(this.getTopStudentInfoButton);
            this.Controls.Add(this.myPersonalInfoButton);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myPersonalInfoButton;
        private System.Windows.Forms.Button getTopStudentInfoButton;
        private System.Windows.Forms.Button myAcademiInfoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button myMessagesButton;
        public System.Windows.Forms.Label welcomeText;
    }
}