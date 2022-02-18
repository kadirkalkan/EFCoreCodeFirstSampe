using EFCoreCodeFirstSample.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreCodeFirstSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var tur = context.Turler.First();
                //tur.Kitaplar
                var kitap = context.Kitaplar.First();
                //kitap.Turler        
            }
        }
    }
}
