﻿namespace Lr1
{
    partial class MessageForm
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
            MessageTextBox = new TextBox();
            SuspendLayout();
            // 
            // MessageTextBox
            // 
            MessageTextBox.Dock = DockStyle.Fill;
            MessageTextBox.Font = new Font("Segoe UI", 12F);
            MessageTextBox.Location = new Point(0, 0);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(282, 253);
            MessageTextBox.TabIndex = 0;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(MessageTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сообщение";
            FormClosing += MessageForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MessageTextBox;
    }
}