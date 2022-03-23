namespace WinFormsGiris
{
    public partial class Arabalar : Form
    {
        Araba _araba;
        public Arabalar()
        {
            InitializeComponent();
        }
             
        private void button1_Click(object sender, EventArgs e)
        {
            _araba = new Araba();
            _araba.Marka = tbMarka.Text;
            _araba.Model = tbModel.Text;
            _araba.KapiSayisi = Convert.ToByte(nudKapiSayisi.Value);
            _araba.BeygirGucu = short.Parse(tbBeygirGucu.Text);
            _araba.SifirYuz = Convert.ToDouble(tbSifirYuz.Text);
            _araba.UretimTarihi = dtpUretimTarihi.Value;
            _araba.IkinciEl = cbIkinciEl.Checked;
            _araba.ArabaTuru = (ArabaTuru)ddlArabaTuru.SelectedIndex;
            MessageBox.Show("Araba Olu�turuldu");
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marka: " + _araba.Marka +
                "\n" + "model: " + _araba.Model +
                "\n" + "Kap� say�s�: " + _araba.KapiSayisi + " kap�" +
                "\n" + "Beygir G�c�: " + _araba.BeygirGucu + " hp" +
                "\n" + "0-100: " + _araba.SifirYuz + " sn" +
                "\n" + "�retim Tarihi: " + _araba.UretimTarihi.ToShortDateString() +
                "\n" + "�kinci El: " + _araba.IkinciElMi);

        }
    }
}