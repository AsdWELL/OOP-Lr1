namespace Lr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yearOfOpening.Format = DateTimePickerFormat.Custom;
            yearOfOpening.CustomFormat = "dd MM yyyy";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
