using ClassesDemo1;

namespace WinFormsTcKimlik
{
    public partial class TcKimlikDo�rulama : Form
    {
        public TcKimlikDo�rulama()
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