using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Pendukung_Keputusan
{
    public partial class Preferensi_Pengguna : Form
    {
        double jarak, biaya, keamanan, rating, fasilitas, 
                kedalaman, kebersihan, pelayanan, totbobot = 0, totalSi;
        double bbtjarak, bbtbiaya, bbtkeamanan, bbtrating, bbtfasilitas,
                bbtkedalaman, bbtkebersihan, bbtpelayanan;

        double[] array = new double[18];
        string[] nama = {"Kolam Renang Stadion Gajayana",
                         "Permata Jingga Swimming Pool & Café",
                         "Taman Wisata Lembah Dieng",
                         "Araya Family Club House Swimming Pool",
                         "Taman Rekreasi Tlogomas",
                         "Kolam Renang Tirta Alam",
                         "Kolam Renang Kalimeri",
                         "Kolam Renang In Jaya",
                         "Kolam Renang Wiroto",
                         "Kolam Renang Simpang Sulfat Selatan",
                         "Kolam Renang dan Pemancingan Sumber Beling",
                         "Kolam Renang Ukhuwah",
                         "Kolam Renang Warna",
                         "Kolam Renang Tirta Marabunta",
                         "Rogonoto Pool",
                         "Hawai Waterpark",
                         "Sengkaling Water Park",
                         "Tirtasari Water Park"};

        String[] nama2 = new String[18];
        double[] array2 = new double[18];

       

        private void txtboxTotal_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void ClearData()
        {
            Jaraktxtbx.Text = "";
            Biayatxtbx.Text = "";
            Keamanantxtbx.Text = "";
            Ratingtxtbx.Text = "";
            Fasilitastxtbx.Text = "";
            Kedalamantxtbx.Text = "";
            Kebersihantxtbx.Text = "";
            Pelayanantxtbx.Text = "";


        }

        

        private void Kedalamantxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        

        private void Kebersihantxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void Pelayanantxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

       

        private void Fasilitastxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void Ratingtxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void Keamanantxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        

        private void Biayatxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        

        private void Jaraktxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            jarak = Convert.ToDouble(Jaraktxtbx.Text);
            biaya = Convert.ToDouble(Biayatxtbx.Text);
            keamanan = Convert.ToDouble(Keamanantxtbx.Text);
            rating = Convert.ToDouble(Ratingtxtbx.Text);
            fasilitas = Convert.ToDouble(Fasilitastxtbx.Text);
            kedalaman = Convert.ToDouble(Kedalamantxtbx.Text);
            kebersihan = Convert.ToDouble(Kebersihantxtbx.Text);
            pelayanan = Convert.ToDouble(Pelayanantxtbx.Text);

            totbobot = jarak + biaya + keamanan + rating + fasilitas + kedalaman + kebersihan + pelayanan;

            bbtjarak = -(jarak / totbobot);
            bbtbiaya = -(biaya / totbobot);
            bbtkeamanan = keamanan / totbobot;
            bbtrating = rating / totbobot;
            bbtfasilitas = fasilitas / totbobot;
            bbtkedalaman = kedalaman / totbobot;
            bbtkebersihan = kebersihan / totbobot;
            bbtpelayanan = pelayanan / totbobot;

            txtboxTotal.Text = totbobot.ToString();

            //Form mc = new Pemilihan_Tempat();
            //mc.Show();
            //this.Hide();
        }

      



       

        public Preferensi_Pengguna()
        {
            InitializeComponent();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                double c1_jarak = 4.4, c1_biaya = 10000, c1_keamanan = 3.8, c1_rating = 4.1,
                    c1_fasilitas = 4.3, c1_kedalaman = 2, c1_kebersihan = 4.2, c1_pelayanan = 3.9;
                c1_jarak = Math.Pow (c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[0] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[0] = 0;
            }
        }

      

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                double c1_jarak = 3.6, c1_biaya = 35000, c1_keamanan = 4, c1_rating = 4.3,
                    c1_fasilitas = 4.6, c1_kedalaman = 1.5, c1_kebersihan = 4.3, c1_pelayanan = 4.5;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[1] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[1] = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                double c1_jarak = 5.1, c1_biaya = 15000, c1_keamanan = 4, c1_rating = 4.3,
                    c1_fasilitas = 4.5, c1_kedalaman = 4.2, c1_kebersihan = 4, c1_pelayanan = 4.4;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[2] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[2] = 0;
            }
        }

        

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                double c1_jarak = 8, c1_biaya = 40000, c1_keamanan = 4.1, c1_rating = 4.4,
                    c1_fasilitas = 4.5, c1_kedalaman = 1.5, c1_kebersihan = 4.3, c1_pelayanan = 4.3;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[3] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[3] = 0;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                double c1_jarak = 3.3, c1_biaya = 50000, c1_keamanan = 3.7, c1_rating = 4,
                    c1_fasilitas = 3.9, c1_kedalaman = 3.5, c1_kebersihan = 4, c1_pelayanan = 3.9;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[4] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[4] = 0;
            }
        }

        

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                double c1_jarak = 9, c1_biaya = 8000, c1_keamanan = 3.4, c1_rating = 3.7,
                    c1_fasilitas = 3.9, c1_kedalaman = 2, c1_kebersihan = 3.6, c1_pelayanan = 3.8;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[5] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[5] = 0;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                double c1_jarak = 14.6, c1_biaya = 10000, c1_keamanan = 3.5, c1_rating = 3.8,
                    c1_fasilitas = 4, c1_kedalaman = 2, c1_kebersihan = 4, c1_pelayanan = 4;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[6] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[6] = 0;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                double c1_jarak = 7, c1_biaya = 15000, c1_keamanan = 1.7, c1_rating = 2,
                    c1_fasilitas = 1.9, c1_kedalaman = 3, c1_kebersihan = 1.8, c1_pelayanan = 2;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[7] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[7] = 0;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                double c1_jarak = 7.6, c1_biaya = 10000, c1_keamanan = 3.5, c1_rating = 3.7,
                    c1_fasilitas = 4.1, c1_kedalaman = 2, c1_kebersihan = 3.7, c1_pelayanan = 3.9;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[8] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[8] = 0;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                double c1_jarak = 8.4, c1_biaya = 10000, c1_keamanan = 3.4, c1_rating = 3.7,
                    c1_fasilitas = 4, c1_kedalaman = 1.5, c1_kebersihan = 3.8, c1_pelayanan = 4;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[9] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[9] = 0;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                double c1_jarak = 7, c1_biaya = 3000, c1_keamanan = 3.8, c1_rating = 4,
                    c1_fasilitas = 3.9, c1_kedalaman = 2, c1_kebersihan = 4, c1_pelayanan = 4.1;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[10] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[10] = 0;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox12.Checked == true)
            {
                double c1_jarak = 4.6, c1_biaya = 12000, c1_keamanan = 4.5, c1_rating = 4.7,
                    c1_fasilitas = 4.8, c1_kedalaman = 2, c1_kebersihan = 4.7, c1_pelayanan = 4.1;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[11] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[11] = 0;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                double c1_jarak = 5, c1_biaya = 10000, c1_keamanan = 3.7, c1_rating = 4,
                    c1_fasilitas = 4, c1_kedalaman = 2, c1_kebersihan = 4, c1_pelayanan = 3.9;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[12] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[12] = 0;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                double c1_jarak = 6.4, c1_biaya = 15000, c1_keamanan = 4.3, c1_rating = 4.4,
                    c1_fasilitas = 4.3, c1_kedalaman = 2.5, c1_kebersihan = 4.3, c1_pelayanan = 4.5;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[13] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[13] = 0;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                double c1_jarak = 11, c1_biaya = 10000, c1_keamanan = 3.7, c1_rating = 3.9,
                    c1_fasilitas = 4.1, c1_kedalaman = 2, c1_kebersihan = 3.8, c1_pelayanan = 4.2;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[14] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[14] = 0;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                double c1_jarak = 11, c1_biaya = 75000, c1_keamanan = 4, c1_rating = 4.3,
                    c1_fasilitas = 4.7, c1_kedalaman = 1.5, c1_kebersihan = 4.2, c1_pelayanan = 4.4;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[15] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[15] = 0;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                double c1_jarak = 8.2, c1_biaya = 25000, c1_keamanan = 3.8, c1_rating = 4.1,
                    c1_fasilitas = 4.4, c1_kedalaman = 1.5, c1_kebersihan = 4, c1_pelayanan = 4.3;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[16] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[16] = 0;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                double c1_jarak = 6.8, c1_biaya = 20000, c1_keamanan = 3.9, c1_rating = 4.2,
                    c1_fasilitas = 4.5, c1_kedalaman = 1.5, c1_kebersihan = 4.1, c1_pelayanan = 4.2;
                c1_jarak = Math.Pow(c1_jarak, bbtjarak);
                c1_biaya = Math.Pow(c1_biaya, bbtbiaya);
                c1_keamanan = Math.Pow(c1_keamanan, bbtkeamanan);
                c1_rating = Math.Pow(c1_rating, bbtrating);
                c1_fasilitas = Math.Pow(c1_fasilitas, bbtfasilitas);
                c1_kedalaman = Math.Pow(c1_kedalaman, bbtkedalaman);
                c1_kebersihan = Math.Pow(c1_kebersihan, bbtkebersihan);
                c1_pelayanan = Math.Pow(c1_pelayanan, bbtpelayanan);

                array[17] = c1_jarak * c1_biaya * c1_keamanan * c1_rating * c1_fasilitas * c1_kedalaman * c1_kebersihan * c1_pelayanan;
            }
            else
            {
                array[17] = 0;
            }
        }

        private void btnCentang_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
            checkBox14.Checked = true;
            checkBox15.Checked = true;
            checkBox16.Checked = true;
            checkBox17.Checked = true;
            checkBox18.Checked = true;
        }

        private void btnUlang_Click(object sender, EventArgs e)
        {

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void btnSimpantot_Click(object sender, EventArgs e)
        {
            totalSi = 0;
            for (int i = 0; i < 18; i++)
            {
                totalSi = totalSi + array[i];
            }
            for (int i = 0; i < 18; i++)
            {
                array[i] = array[i] / totalSi;
                array2[i] = array[i];
            }
            Array.Sort(array2);
            for (int i = 0; i < 18; i++)
                for (int j = 0; j < 18; j++)
                {
                    {
                        if (array2[i] == array[j])
                        {
                            nama2[i] = nama[j];
                        }
                    }
                }
            txtbxHasil1.Text = nama2[17];
            txtbxHasil2.Text = nama2[16];
            txtbxHasil3.Text = nama2[15];
            txtbxNilai1.Text = array2[17].ToString();
            txtbxNilai2.Text = array2[16].ToString();
            txtbxNilai3.Text = array2[15].ToString();
        }




    }
   
}
