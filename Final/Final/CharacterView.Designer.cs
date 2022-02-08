namespace Final
{
    partial class CharacterView
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classAtt1Label = new System.Windows.Forms.Label();
            this.classAtt1TextBox = new System.Windows.Forms.TextBox();
            this.classAtt2Label = new System.Windows.Forms.Label();
            this.classAtt2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(117, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(117, 64);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(218, 22);
            this.classTextBox.TabIndex = 2;
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(117, 116);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(218, 22);
            this.levelTextBox.TabIndex = 3;
            // 
            // healthTextBox
            // 
            this.healthTextBox.Location = new System.Drawing.Point(117, 168);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(218, 22);
            this.healthTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "HP:";
            // 
            // classAtt1Label
            // 
            this.classAtt1Label.AutoSize = true;
            this.classAtt1Label.Location = new System.Drawing.Point(12, 223);
            this.classAtt1Label.Name = "classAtt1Label";
            this.classAtt1Label.Size = new System.Drawing.Size(71, 17);
            this.classAtt1Label.TabIndex = 9;
            this.classAtt1Label.Text = "ClassAtt1:";
            // 
            // classAtt1TextBox
            // 
            this.classAtt1TextBox.Location = new System.Drawing.Point(117, 220);
            this.classAtt1TextBox.Name = "classAtt1TextBox";
            this.classAtt1TextBox.Size = new System.Drawing.Size(218, 22);
            this.classAtt1TextBox.TabIndex = 8;
            // 
            // classAtt2Label
            // 
            this.classAtt2Label.AutoSize = true;
            this.classAtt2Label.Location = new System.Drawing.Point(12, 273);
            this.classAtt2Label.Name = "classAtt2Label";
            this.classAtt2Label.Size = new System.Drawing.Size(71, 17);
            this.classAtt2Label.TabIndex = 11;
            this.classAtt2Label.Text = "ClassAtt2:";
            // 
            // classAtt2TextBox
            // 
            this.classAtt2TextBox.Location = new System.Drawing.Point(117, 270);
            this.classAtt2TextBox.Name = "classAtt2TextBox";
            this.classAtt2TextBox.Size = new System.Drawing.Size(218, 22);
            this.classAtt2TextBox.TabIndex = 10;
            // 
            // CharacterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 307);
            this.Controls.Add(this.classAtt2Label);
            this.Controls.Add(this.classAtt2TextBox);
            this.Controls.Add(this.classAtt1Label);
            this.Controls.Add(this.classAtt1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CharacterView";
            this.Text = "CharacterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label classAtt1Label;
        private System.Windows.Forms.TextBox classAtt1TextBox;
        private System.Windows.Forms.Label classAtt2Label;
        private System.Windows.Forms.TextBox classAtt2TextBox;
    }
}