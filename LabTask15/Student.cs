namespace LabTask15
{
    internal class Student
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Fakulte { get; set; }
        public int[] Bal { get; set; } = new int[5];
        public char[] Netice { get; set; } = new char[5];
        public string[] ImtahanAdi { get; set; } = new string[5];
        public int[] ImtahanBali { get; set; } = new int[5];


        public Student(string ad, string soyad, string fakulte, int[] bal)
        {
            Ad = ad;
            Soyad = soyad;
            Fakulte = fakulte;
            Bal = bal;
        }

        public void CheckExam(int[] imtahanBali, string[] imtahanAdi)
        {
            for (int i = 0; i < 5; i++)
            {
                ImtahanAdi[i] = imtahanAdi[i];
                ImtahanBali[i] = imtahanBali[i];
                if (imtahanBali[i] >= 17)
                {
                    if (imtahanBali[i] + Bal[i] > 50 && imtahanBali[i] + Bal[i] <= 60)
                        Netice[i] = 'E';
                    else if (imtahanBali[i] + Bal[i] > 60 && imtahanBali[i] + Bal[i] <= 70)
                        Netice[i] = 'D';
                    else if (imtahanBali[i] + Bal[i] > 70 && imtahanBali[i] + Bal[i] <= 80)
                        Netice[i] = 'C';
                    else if (imtahanBali[i] + Bal[i] > 80 && imtahanBali[i] + Bal[i] <= 90)
                        Netice[i] = 'B';
                    else if (imtahanBali[i] + Bal[i] > 90 && imtahanBali[i] + Bal[i] <= 100)
                        Netice[i] = 'A';
                    else
                        Netice[i] = 'F';
                }
                else
                    Netice[i] = 'F';
            }
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Ad = {Ad}, Soyad = {Soyad}, Fakulte = {Fakulte}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"ImtahanAdi = {ImtahanAdi[i]}, GirishBali = {Bal[i]}, ImtahanBali = {ImtahanBali[i]}, Netice = { Netice[i]}");
            }
        }
    }
}
