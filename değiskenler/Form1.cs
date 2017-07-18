using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace değiskenler
{
    public partial class Form1 : Form
    {
        //değişkenler,verileri kaydettiğimiz alanlardır

        //sayısal veri tipleri

        byte sayi; //bu sayıya 0-255 arası bir değer ataması yapılabilir.
        string metin;
        public Form1()
        {
            InitializeComponent();


            sayi = 5;
            metin = "2017 yılındayız.";
       
            
        }
        
        private void button1_Click(object sender,EventArgs e)
        {
            MessageBox.Show(sayi.ToString());
            sayi = 10;
            MessageBox.Show(sayi.ToString());
            MessageBox.Show(metin);
        


        }
    }
}
