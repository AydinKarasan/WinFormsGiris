using ClassesDemo1;

namespace WinFormsTcKimlik
{
    public partial class TcKimlikDoðrulama : Form
    {
        public TcKimlikDoðrulama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcKimlikNo tcKimlikNo = new TcKimlikNo();
            MessageBox.Show(tcKimlikNo.Dogrula(tbKimlik.Text));

        }
    }
}