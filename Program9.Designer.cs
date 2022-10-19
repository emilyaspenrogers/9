
namespace ERogersProgram9
{
    partial class Program9
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
            this.groupConferenceInfo = new System.Windows.Forms.GroupBox();
            this.groupAccomodation = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumberofAttendees = new System.Windows.Forms.Label();
            this.lblNumberofNights = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.rbtnDouble = new System.Windows.Forms.RadioButton();
            this.rbtnSuite = new System.Windows.Forms.RadioButton();
            this.chbxInternetAccess = new System.Windows.Forms.CheckBox();
            this.chbxRecCenterAccess = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnCreateConference = new System.Windows.Forms.Button();
            this.btnModifyConference = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupConferenceInfo.SuspendLayout();
            this.groupAccomodation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupConferenceInfo
            // 
            this.groupConferenceInfo.Controls.Add(this.numericUpDown2);
            this.groupConferenceInfo.Controls.Add(this.numericUpDown1);
            this.groupConferenceInfo.Controls.Add(this.textBox1);
            this.groupConferenceInfo.Controls.Add(this.lblNumberofNights);
            this.groupConferenceInfo.Controls.Add(this.lblNumberofAttendees);
            this.groupConferenceInfo.Controls.Add(this.lblName);
            this.groupConferenceInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupConferenceInfo.Location = new System.Drawing.Point(21, 55);
            this.groupConferenceInfo.Name = "groupConferenceInfo";
            this.groupConferenceInfo.Size = new System.Drawing.Size(468, 186);
            this.groupConferenceInfo.TabIndex = 0;
            this.groupConferenceInfo.TabStop = false;
            this.groupConferenceInfo.Text = "Conference Info: ";
            // 
            // groupAccomodation
            // 
            this.groupAccomodation.Controls.Add(this.rbtnSuite);
            this.groupAccomodation.Controls.Add(this.rbtnDouble);
            this.groupAccomodation.Controls.Add(this.rbtnSingle);
            this.groupAccomodation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupAccomodation.Location = new System.Drawing.Point(21, 270);
            this.groupAccomodation.Name = "groupAccomodation";
            this.groupAccomodation.Size = new System.Drawing.Size(231, 154);
            this.groupAccomodation.TabIndex = 1;
            this.groupAccomodation.TabStop = false;
            this.groupAccomodation.Text = "Accomodation: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbxRecCenterAccess);
            this.groupBox3.Controls.Add(this.chbxInternetAccess);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(258, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Optional Services: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnModifyConference);
            this.groupBox4.Controls.Add(this.btnCreateConference);
            this.groupBox4.Location = new System.Drawing.Point(495, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 170);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(16, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name: ";
            // 
            // lblNumberofAttendees
            // 
            this.lblNumberofAttendees.AutoSize = true;
            this.lblNumberofAttendees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberofAttendees.Location = new System.Drawing.Point(16, 86);
            this.lblNumberofAttendees.Name = "lblNumberofAttendees";
            this.lblNumberofAttendees.Size = new System.Drawing.Size(189, 23);
            this.lblNumberofAttendees.TabIndex = 1;
            this.lblNumberofAttendees.Text = "N&umber of Attendees:";
            // 
            // lblNumberofNights
            // 
            this.lblNumberofNights.AutoSize = true;
            this.lblNumberofNights.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberofNights.Location = new System.Drawing.Point(16, 126);
            this.lblNumberofNights.Name = "lblNumberofNights";
            this.lblNumberofNights.Size = new System.Drawing.Size(166, 23);
            this.lblNumberofNights.TabIndex = 2;
            this.lblNumberofNights.Text = "Nu&mber of Nights: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 30);
            this.textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(218, 82);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 30);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown2.Location = new System.Drawing.Point(218, 123);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(150, 30);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Location = new System.Drawing.Point(16, 38);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(77, 27);
            this.rbtnSingle.TabIndex = 0;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "Single";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // rbtnDouble
            // 
            this.rbtnDouble.AutoSize = true;
            this.rbtnDouble.Location = new System.Drawing.Point(16, 78);
            this.rbtnDouble.Name = "rbtnDouble";
            this.rbtnDouble.Size = new System.Drawing.Size(86, 27);
            this.rbtnDouble.TabIndex = 1;
            this.rbtnDouble.TabStop = true;
            this.rbtnDouble.Text = "Double";
            this.rbtnDouble.UseVisualStyleBackColor = true;
            // 
            // rbtnSuite
            // 
            this.rbtnSuite.AutoSize = true;
            this.rbtnSuite.Location = new System.Drawing.Point(16, 114);
            this.rbtnSuite.Name = "rbtnSuite";
            this.rbtnSuite.Size = new System.Drawing.Size(69, 27);
            this.rbtnSuite.TabIndex = 2;
            this.rbtnSuite.TabStop = true;
            this.rbtnSuite.Text = "Suite";
            this.rbtnSuite.UseVisualStyleBackColor = true;
            // 
            // chbxInternetAccess
            // 
            this.chbxInternetAccess.AutoSize = true;
            this.chbxInternetAccess.Location = new System.Drawing.Point(19, 39);
            this.chbxInternetAccess.Name = "chbxInternetAccess";
            this.chbxInternetAccess.Size = new System.Drawing.Size(148, 27);
            this.chbxInternetAccess.TabIndex = 0;
            this.chbxInternetAccess.Text = "Internet Access";
            this.chbxInternetAccess.UseVisualStyleBackColor = true;
            // 
            // chbxRecCenterAccess
            // 
            this.chbxRecCenterAccess.AutoSize = true;
            this.chbxRecCenterAccess.Location = new System.Drawing.Point(19, 79);
            this.chbxRecCenterAccess.Name = "chbxRecCenterAccess";
            this.chbxRecCenterAccess.Size = new System.Drawing.Size(171, 27);
            this.chbxRecCenterAccess.TabIndex = 1;
            this.chbxRecCenterAccess.Text = "Rec Center Access";
            this.chbxRecCenterAccess.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(201, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "CSU Conference Services Charge Calculator";
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(495, 239);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(293, 199);
            this.lblResults.TabIndex = 4;
            // 
            // btnCreateConference
            // 
            this.btnCreateConference.Location = new System.Drawing.Point(25, 38);
            this.btnCreateConference.Name = "btnCreateConference";
            this.btnCreateConference.Size = new System.Drawing.Size(246, 41);
            this.btnCreateConference.TabIndex = 0;
            this.btnCreateConference.Text = "&Create Conference";
            this.btnCreateConference.UseVisualStyleBackColor = true;
            // 
            // btnModifyConference
            // 
            this.btnModifyConference.Location = new System.Drawing.Point(25, 86);
            this.btnModifyConference.Name = "btnModifyConference";
            this.btnModifyConference.Size = new System.Drawing.Size(246, 41);
            this.btnModifyConference.TabIndex = 1;
            this.btnModifyConference.Text = "&Modify Conference";
            this.btnModifyConference.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 132);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 32);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(147, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Program9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupAccomodation);
            this.Controls.Add(this.groupConferenceInfo);
            this.Name = "Program9";
            this.Text = "Program9";
            this.groupConferenceInfo.ResumeLayout(false);
            this.groupConferenceInfo.PerformLayout();
            this.groupAccomodation.ResumeLayout(false);
            this.groupAccomodation.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConferenceInfo;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumberofNights;
        private System.Windows.Forms.Label lblNumberofAttendees;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupAccomodation;
        private System.Windows.Forms.RadioButton rbtnSuite;
        private System.Windows.Forms.RadioButton rbtnDouble;
        private System.Windows.Forms.RadioButton rbtnSingle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbxRecCenterAccess;
        private System.Windows.Forms.CheckBox chbxInternetAccess;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnModifyConference;
        private System.Windows.Forms.Button btnCreateConference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResults;
    }
}