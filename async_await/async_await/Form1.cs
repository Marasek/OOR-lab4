using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wywolanie_metody();
            label1.Text = "Czekamy....";
        }

        private async void wywolanie_metody()
        {
            var result = await metoda_async("Marek");
            label1.Text = result;
        }

        private Task<string> metoda_async(string nazwa)
        {
            return Task.Factory.StartNew(() => metoda(nazwa));
        }
        private string metoda(string nazwa)
        {
            Thread.Sleep(2000);
            return "Kto chce 4? "+ Environment.NewLine + nazwa;
        }
    }
}
