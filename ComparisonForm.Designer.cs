namespace Lr1
{
    partial class ComparisonForm
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
            ListView = new ListView();
            collectionHeader = new ColumnHeader();
            seqHeader = new ColumnHeader();
            rndHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // ListView
            // 
            ListView.Columns.AddRange(new ColumnHeader[] { collectionHeader, seqHeader, rndHeader });
            ListView.Dock = DockStyle.Fill;
            ListView.Font = new Font("Segoe UI", 12F);
            ListView.GridLines = true;
            ListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListView.Location = new Point(0, 0);
            ListView.MultiSelect = false;
            ListView.Name = "ListView";
            ListView.Scrollable = false;
            ListView.Size = new Size(582, 553);
            ListView.TabIndex = 0;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            // 
            // collectionHeader
            // 
            collectionHeader.Text = "Коллекция";
            collectionHeader.Width = 120;
            // 
            // seqHeader
            // 
            seqHeader.Text = "Последовательная";
            seqHeader.TextAlign = HorizontalAlignment.Center;
            seqHeader.Width = 230;
            // 
            // rndHeader
            // 
            rndHeader.Text = "Случайная";
            rndHeader.TextAlign = HorizontalAlignment.Center;
            rndHeader.Width = 230;
            // 
            // ComparisonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(ListView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ComparisonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сравнение";
            Load += ComparisonForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView ListView;
        private ColumnHeader collectionHeader;
        private ColumnHeader seqHeader;
        private ColumnHeader rndHeader;
    }
}