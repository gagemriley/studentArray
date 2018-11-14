namespace studentArray
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.StudentLbl = new System.Windows.Forms.Label();
            this.GradeLbl = new System.Windows.Forms.Label();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.DisplayArrayBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.StudentBox = new System.Windows.Forms.TextBox();
            this.GradeBox = new System.Windows.Forms.TextBox();
            this.ShowArrayLbl = new System.Windows.Forms.Label();
            this.LineLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLbl.Location = new System.Drawing.Point(40, 29);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(540, 100);
            this.DescriptionLbl.TabIndex = 0;
            this.DescriptionLbl.Text = resources.GetString("DescriptionLbl.Text");
            // 
            // StudentLbl
            // 
            this.StudentLbl.AutoSize = true;
            this.StudentLbl.Location = new System.Drawing.Point(84, 148);
            this.StudentLbl.Name = "StudentLbl";
            this.StudentLbl.Size = new System.Drawing.Size(75, 13);
            this.StudentLbl.TabIndex = 1;
            this.StudentLbl.Text = "Student Name";
            // 
            // GradeLbl
            // 
            this.GradeLbl.AutoSize = true;
            this.GradeLbl.Location = new System.Drawing.Point(325, 148);
            this.GradeLbl.Name = "GradeLbl";
            this.GradeLbl.Size = new System.Drawing.Size(210, 13);
            this.GradeLbl.TabIndex = 2;
            this.GradeLbl.Text = "Course Grade as a Number (e.q. 99 is 99%)";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(157, 214);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(311, 47);
            this.AddStudentBtn.TabIndex = 3;
            this.AddStudentBtn.Text = "Add Student to Grading Array";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // DisplayArrayBtn
            // 
            this.DisplayArrayBtn.Location = new System.Drawing.Point(87, 302);
            this.DisplayArrayBtn.Name = "DisplayArrayBtn";
            this.DisplayArrayBtn.Size = new System.Drawing.Size(448, 29);
            this.DisplayArrayBtn.TabIndex = 4;
            this.DisplayArrayBtn.Text = "Display Array - Display Each Student\'s Info from the Stored Array AND Calculate A" +
    "verage";
            this.DisplayArrayBtn.UseVisualStyleBackColor = true;
            this.DisplayArrayBtn.Click += new System.EventHandler(this.DisplayArrayBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(63, 494);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(494, 30);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Clear Text Box and Clear Away and Reset Student Counter/Array Index";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // StudentBox
            // 
            this.StudentBox.Location = new System.Drawing.Point(87, 164);
            this.StudentBox.Name = "StudentBox";
            this.StudentBox.Size = new System.Drawing.Size(124, 20);
            this.StudentBox.TabIndex = 6;
            // 
            // GradeBox
            // 
            this.GradeBox.Location = new System.Drawing.Point(328, 164);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(207, 20);
            this.GradeBox.TabIndex = 7;
            // 
            // ShowArrayLbl
            // 
            this.ShowArrayLbl.BackColor = System.Drawing.Color.PowderBlue;
            this.ShowArrayLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowArrayLbl.Location = new System.Drawing.Point(40, 350);
            this.ShowArrayLbl.Name = "ShowArrayLbl";
            this.ShowArrayLbl.Size = new System.Drawing.Size(540, 129);
            this.ShowArrayLbl.TabIndex = 8;
            // 
            // LineLbl
            // 
            this.LineLbl.Location = new System.Drawing.Point(84, 270);
            this.LineLbl.Name = "LineLbl";
            this.LineLbl.Size = new System.Drawing.Size(451, 11);
            this.LineLbl.TabIndex = 29;
            this.LineLbl.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 555);
            this.Controls.Add(this.LineLbl);
            this.Controls.Add(this.ShowArrayLbl);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.StudentBox);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.DisplayArrayBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.GradeLbl);
            this.Controls.Add(this.StudentLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label StudentLbl;
        private System.Windows.Forms.Label GradeLbl;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button DisplayArrayBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.TextBox StudentBox;
        private System.Windows.Forms.TextBox GradeBox;
        private System.Windows.Forms.Label ShowArrayLbl;
        private System.Windows.Forms.Label LineLbl;
    }
}

