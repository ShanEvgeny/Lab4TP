﻿namespace Лаб4ТП
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
            btnRefill = new Button();
            txtInfo = new RichTextBox();
            btnGet = new Button();
            txtOut = new RichTextBox();
            txtQueue = new RichTextBox();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(25, 27);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(423, 29);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(25, 62);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(369, 72);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(356, 140);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(92, 213);
            btnGet.TabIndex = 2;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(25, 140);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(215, 213);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            // 
            // txtQueue
            // 
            txtQueue.BorderStyle = BorderStyle.None;
            txtQueue.Location = new Point(246, 140);
            txtQueue.Name = "txtQueue";
            txtQueue.ReadOnly = true;
            txtQueue.Size = new Size(104, 231);
            txtQueue.TabIndex = 4;
            txtQueue.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 367);
            Controls.Add(txtQueue);
            Controls.Add(txtOut);
            Controls.Add(btnGet);
            Controls.Add(txtInfo);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private RichTextBox txtInfo;
        private Button btnGet;
        private RichTextBox txtOut;
        private RichTextBox txtQueue;
    }
}