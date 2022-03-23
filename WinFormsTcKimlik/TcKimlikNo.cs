namespace ClassesDemo1
{
    internal class TcKimlikNo
    {
        public string Dogrula(string kimlikNo) //12345678901
        {
            const string tc = "TC Kimlik No";
            string sonuc = tc + " Doğrudur";
            if (kimlikNo.Length != 11)
            {
                sonuc = tc + " 11 Hane olmalıdır!";
            }
            else
            {
                if (kimlikNo.Substring(0 ,1) == "0")
                {
                    sonuc = tc + " 0 ile başlayamaz!";
                }
                else
                {
                    double[] haneler = new double[kimlikNo.Length];
                    for (int i = 0; i < haneler.Length; i++)
                    {
                        haneler[i] = Convert.ToDouble(kimlikNo[i].ToString());
                    }
                    //double hane10toplam1 = haneler[0] + haneler[2] + haneler[4] + haneler[6] + haneler[8];
                    double hane10toplam1 = 0;
                    for (int i = 0; i <= haneler.Length - 3; i+=2)
                    {
                        hane10toplam1 += haneler[i];
                    }
                    double hane10toplam2 = 0;
                    for (int i = 1; i <=haneler.Length - 4; i+= 2)
                    {
                        hane10toplam2 += haneler[i];
                    }
                    double hane10 = (hane10toplam1 * 7 - hane10toplam2) % 10;
                    if (hane10 != haneler[9])
                    {
                        sonuc = tc + " doğru değildir.";
                    }
                    else
                    {
                        double hane11toplam = 0;
                        for (int i = 0; i <= haneler.Length - 2; i++)
                        {
                            hane11toplam += haneler[i];
                        }
                        double hane11 = hane11toplam % 10;
                        if (hane11 != haneler[10])
                        {
                            sonuc = tc + " doğru değildir.";
                        }
                    }
                }
            }
            return sonuc;
        }

    }
}
