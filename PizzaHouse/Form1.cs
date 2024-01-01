using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaHouse
{
    public partial class PizzaHouse : Form
    {
        public PizzaHouse()
        {
            InitializeComponent();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
             
        }

        private void btn_siparisAl_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txt_adSoyad.Text);
            listBox2.Items.Add(txt_telNo.Text);
            listBox3.Items.Add(txt_adres.Text);
            listBox4.Items.Add(cmbx_boyut.Text);
            listBox5.Items.Add(cmbx_icecek.Text);
            listBox6.Items.Add(label7.Text + " " + label8.Text + " " + label9.Text + " " + label10.Text + " " + label11.Text +" " +label12.Text);
        }

        private void cbx_sucuk_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = cbx_sucuk.Text;
        }

        private void cbx_kasar_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = cbx_kasar.Text;
        }

        private void cbx_zeytin_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = cbx_zeytin.Text;
        }

        private void cbx_mantar_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = cbx_mantar.Text;
        }

        private void cbx_biber_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = cbx_biber.Text;
        }

        private void cbx_misir_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = cbx_misir.Text;
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_adSoyad.Clear();
            txt_adres.Clear();
            txt_telNo.Clear();
            cmbx_boyut.Text = " ";
            cmbx_icecek.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
        }

        private void PizzaHouse_Load(object sender, EventArgs e)
        {

        }
    }
}
