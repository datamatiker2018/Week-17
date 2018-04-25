using System.Windows.Forms;

namespace CustomButtons
{
    public partial class SecondaryForm : Form
    {
        public SecondaryForm(string text)
        {
            InitializeComponent();
            defaultButton1.Text = text;
        }
    }
}



