namespace Lr1
{
    partial class StationsInfoForm
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
            StationsInfoTextBox = new TextBox();
            SuspendLayout();
            // 
            // StationsInfoTextBox
            // 
            StationsInfoTextBox.Cursor = Cursors.AppStarting;
            StationsInfoTextBox.Dock = DockStyle.Fill;
            StationsInfoTextBox.Font = new Font("Segoe UI", 12F);
            StationsInfoTextBox.Location = new Point(0, 0);
            StationsInfoTextBox.Multiline = true;
            StationsInfoTextBox.Name = "StationsInfoTextBox";
            StationsInfoTextBox.ReadOnly = true;
            StationsInfoTextBox.ScrollBars = ScrollBars.Vertical;
            StationsInfoTextBox.Size = new Size(582, 553);
            StationsInfoTextBox.TabIndex = 0;
            // 
            // StationsInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(StationsInfoTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StationsInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Станции";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox StationsInfoTextBox;
    }
}