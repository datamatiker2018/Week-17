using System.Windows.Forms;

namespace CustomButtons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void defaultButton1_Click(object sender, System.EventArgs e)
        {
            // Create a new object of the form you want to show/open
            // In this case I pass a string value to the "Secondary" form
            SecondaryForm secondaryForm = new SecondaryForm(textBox1.Text);
            // Call the "Show" method to show the form.
            secondaryForm.Show();
        }
    }
}
