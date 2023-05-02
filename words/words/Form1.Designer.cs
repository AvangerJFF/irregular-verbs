
namespace words
{
    partial class Form1
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
            this.firstFormText = new System.Windows.Forms.TextBox();
            this.secondFormText = new System.Windows.Forms.TextBox();
            this.thirdFormText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.testBox = new System.Windows.Forms.TextBox();
            this.ChooseGroup = new System.Windows.Forms.ComboBox();
            this.ruWordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstFormText
            // 
            this.firstFormText.Location = new System.Drawing.Point(138, 114);
            this.firstFormText.Name = "firstFormText";
            this.firstFormText.Size = new System.Drawing.Size(100, 23);
            this.firstFormText.TabIndex = 1;
            // 
            // secondFormText
            // 
            this.secondFormText.Location = new System.Drawing.Point(244, 114);
            this.secondFormText.Name = "secondFormText";
            this.secondFormText.Size = new System.Drawing.Size(100, 23);
            this.secondFormText.TabIndex = 2;
            // 
            // thirdFormText
            // 
            this.thirdFormText.Location = new System.Drawing.Point(350, 114);
            this.thirdFormText.Name = "thirdFormText";
            this.thirdFormText.Size = new System.Drawing.Size(100, 23);
            this.thirdFormText.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(138, 322);
            this.testBox.Multiline = true;
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(504, 88);
            this.testBox.TabIndex = 5;
            // 
            // ChooseGroup
            // 
            this.ChooseGroup.FormattingEnabled = true;
            this.ChooseGroup.Items.AddRange(new object[] {
            "First group",
            "Second group",
            "Third group",
            "Fourth group",
            "Fifth group",
            "Sixth group"});
            this.ChooseGroup.Location = new System.Drawing.Point(32, 42);
            this.ChooseGroup.Name = "ChooseGroup";
            this.ChooseGroup.Size = new System.Drawing.Size(121, 23);
            this.ChooseGroup.TabIndex = 6;
            this.ChooseGroup.SelectedIndexChanged += new System.EventHandler(this.ChooseGroup_SelectedIndexChanged);
            // 
            // ruWordText
            // 
            this.ruWordText.Location = new System.Drawing.Point(32, 114);
            this.ruWordText.Name = "ruWordText";
            this.ruWordText.Size = new System.Drawing.Size(100, 23);
            this.ruWordText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "RuWord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "First form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Second form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Third form";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(32, 165);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 134);
            this.textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ruWordText);
            this.Controls.Add(this.ChooseGroup);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thirdFormText);
            this.Controls.Add(this.secondFormText);
            this.Controls.Add(this.firstFormText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstFormText;
        private System.Windows.Forms.TextBox secondFormText;
        private System.Windows.Forms.TextBox thirdFormText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.ComboBox ChooseGroup;
        private System.Windows.Forms.TextBox ruWordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

