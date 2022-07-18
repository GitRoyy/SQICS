
namespace SQICS
{
    partial class Main
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBoxTransactionNo = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.btnNewPlan = new System.Windows.Forms.Button();
            this.buttonCurrent = new System.Windows.Forms.Button();
            this.btnReprint_LotLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(886, 48);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(86, 31);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(886, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Welcome, User";
            this.lblUsername.SizeChanged += new System.EventHandler(this.labelName_SizeChanged);
            // 
            // textBoxTransactionNo
            // 
            this.textBoxTransactionNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTransactionNo.Location = new System.Drawing.Point(367, 262);
            this.textBoxTransactionNo.Name = "textBoxTransactionNo";
            this.textBoxTransactionNo.PlaceholderText = "Transaction No.";
            this.textBoxTransactionNo.Size = new System.Drawing.Size(236, 34);
            this.textBoxTransactionNo.TabIndex = 2;
            this.textBoxTransactionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGo.Location = new System.Drawing.Point(606, 262);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(39, 34);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // btnNewPlan
            // 
            this.btnNewPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewPlan.Location = new System.Drawing.Point(367, 300);
            this.btnNewPlan.Name = "btnNewPlan";
            this.btnNewPlan.Size = new System.Drawing.Size(115, 34);
            this.btnNewPlan.TabIndex = 4;
            this.btnNewPlan.Text = "New Plan";
            this.btnNewPlan.UseVisualStyleBackColor = true;
            this.btnNewPlan.Click += new System.EventHandler(this.btnNewPlan_Click);
            // 
            // buttonCurrent
            // 
            this.buttonCurrent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCurrent.Location = new System.Drawing.Point(488, 300);
            this.buttonCurrent.Name = "buttonCurrent";
            this.buttonCurrent.Size = new System.Drawing.Size(115, 34);
            this.buttonCurrent.TabIndex = 5;
            this.buttonCurrent.Text = "View Current";
            this.buttonCurrent.UseVisualStyleBackColor = true;
            // 
            // btnReprint_LotLabel
            // 
            this.btnReprint_LotLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReprint_LotLabel.Location = new System.Drawing.Point(414, 337);
            this.btnReprint_LotLabel.Name = "btnReprint_LotLabel";
            this.btnReprint_LotLabel.Size = new System.Drawing.Size(143, 34);
            this.btnReprint_LotLabel.TabIndex = 6;
            this.btnReprint_LotLabel.Text = "Reprint Lot Label";
            this.btnReprint_LotLabel.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 671);
            this.ControlBox = false;
            this.Controls.Add(this.btnReprint_LotLabel);
            this.Controls.Add(this.buttonCurrent);
            this.Controls.Add(this.btnNewPlan);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxTransactionNo);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.buttonLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQICS (Sub-Assembly Quality Information Control System)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBoxTransactionNo;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button btnNewPlan;
        private System.Windows.Forms.Button buttonCurrent;
        private System.Windows.Forms.Button btnReprint_LotLabel;
    }
}