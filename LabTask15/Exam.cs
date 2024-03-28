using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask15
{
    internal class Exam
    {
        public string[] ImtahanAdi { get; set; } = new string[5];
        public int[] ImtahanBali { get; set; } = new int[5];

        public Exam(string[] ad, int[] bal)
        {
            ImtahanAdi = ad;
            ImtahanBali = bal;
        }
    }
}
