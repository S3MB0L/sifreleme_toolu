using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sifreleme_Toolu
{
    public partial class Form2 : Form
    {
        //formlar arası geçiş için
        //gerekli nesneler tanımlanıyor
        public Form1 frm1;
        public Form3 frm3;

        public Form2()
        {
            InitializeComponent();
        }

        //güvenli çıkış
        //kullanıcı çıkış yapacağı
        //zaman veri tabanına bu bilgi yazılır
        private void btn_logout_Click(object sender, EventArgs e)
        {
            String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=kullanicilar;integrated security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand komut = new SqlCommand();

            komut.Connection = con;
            komut.CommandText = "update dbo.kullanici set LOGIN_STATE='FALSE' ";
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();

            Form1 frm2 = new Form1();
            frm2.Visible = true;
            Application.Exit();
        }

        //kullanıcı yönetim ekranına
        //geçiş yapar
        //admin ve moderatörler 
        //bu alana giriş yapabilir
        private void kullanıcılarıYönetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(label9.Text.Equals("GUEST     ") || label9.Text.Equals("USER      "))
            {
                MessageBox.Show("Bu Alana Giriş Yetkiniz Bulunmuyor!");
            }
            else
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }  
        }

        //şifrelenen dosyaların
        //kayıtlı bilgilerini getirir
        private void button2_Click(object sender, EventArgs e)
        {
            String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=sifreleme;integrated security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "SELECT * FROM dbo.table_sifrelenenler";
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = komut;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //form yüklenirken 
            //veri tabanına bağlanılır
            //yetkilendirmeleri
            //ve aktif kullanıcı 
            //bilgileri alınır
            Debug.Write("Form 2 yüklendi\n");
            String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=kullanicilar;integrated security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "SELECT * FROM dbo.kullanici";
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = komut;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            String[] kllnici_adi = new String[1500];
            String[] kllnici_sifre = new String[1500];
            String[] kllnici_login_state = new String[1500];
            String[] kllnici_auth = new String[1500];
            int user_id=0;
            int user_index=0;
            Debug.Write("Kullanıcı Adları\n");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                kllnici_adi[i] = Convert.ToString(dt.Rows[i]["AD"]);
                Debug.Write(kllnici_adi[i]);
                Debug.Write("\n");

            }
            Debug.Write("Kullanıcı Sifreleri\n");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                kllnici_sifre[i] = Convert.ToString(dt.Rows[i]["PASS"]);
                Debug.Write(kllnici_sifre[i]);
                Debug.Write("\n");
            }
            Debug.Write("Kullanıcı Oturum Durumları\n");
            for (int i=0; i < dt.Rows.Count; i++)
            {
                kllnici_login_state[i] = Convert.ToString(dt.Rows[i]["LOGIN_STATE"]);
                Debug.Write(kllnici_login_state[i]);
                Debug.Write("\n");
            }
            Debug.Write("Kullanıcı Yetkilendirmeleri\n");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                kllnici_auth[i] = Convert.ToString(dt.Rows[i]["AUTH"]);
                Debug.Write(kllnici_auth[i]);
                Debug.Write("\n");
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Debug.Write(kllnici_login_state[i]);
                if (kllnici_login_state[i].Equals("TRUE      "))
                {
                    
                    user_id = 100 + i;
                    user_index = i;
                    Debug.Write(i+" "+ user_id+" "+user_index+" "+ "\n");
                    break;
                }
                else
                user_id = -1;
            }
            //aktif kullanıcı
            //ile ilgili bilgiler 
            //formdaki labellere yazdırır
            label5.Text = kllnici_adi[user_index];
            label7.Text = Convert.ToString(user_id);
            label9.Text = kllnici_auth[user_index];
        }

        private void Dosya_Gozat_Click(object sender, EventArgs e)
        {
            //şifrelenecek  dosyayı
            //seçen diyalog penceresi
            //açılır
            OpenFileDialog fdlg = new OpenFileDialog();

            DialogResult result = fdlg.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fdlg.FileName;
                txtFilePath.Text = file;


            }
        }
        //şifrelenecek klasörü
        //seçen diyalog penceresi
        //açılır
        private void Klasor_Gozat_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            txtDirPath.Text = folderPath;
        }
        //tool strip ile
        //dosya seçim 
        //penceresi açılır
        private void dosyaSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            DialogResult result = fdlg.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fdlg.FileName;
                txtFilePath.Text = file;


            }
        }
        //tool strip menüsü
        //ile klasör seçim
        //penceresi açılır
        private void klasörSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            txtDirPath.Text = folderPath;
        }
        //tool strip ile
        //güvenli çıkış
        //yapar
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=kullanicilar;integrated security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand komut = new SqlCommand();

            komut.Connection = con;
            komut.CommandText = "update dbo.kullanici set LOGIN_STATE='FALSE' ";
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();

            Form1 frm2 = new Form1();
            frm2.Visible = true;
            Application.Exit();
        }
        //tool strip menüsünde
        //künyeyi gösterir
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifrele Toolu\n\n"+
                            "Programlama II Proje Ödevi\n\n"+
                            "Tarkan Dalay\n"+
                            "M. Serhan Bayar\n"+
                            "Mustafa Çankaya\n");
        }
        //tool strip ile 
        //şifrelenen içerikleri listeler
        private void şifrelenenİçerikleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=sifreleme;integrated security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "SELECT * FROM dbo.table_sifrelenenler";
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = komut;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void sifrele_Click(object sender, EventArgs e)
        {
            if (label9.Text.Equals("GUEST     "))
            {
                MessageBox.Show("Bu işlem için yetkiye sahip değilsiniz");
            }
            else 
            {
                String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=sifreleme;integrated security=true";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand komut = new SqlCommand();
                
                komut.Connection = con;
                komut.CommandText = "insert into dbo.table_sifrelenenler(Klasor, Dosya, Sifreleme_Tipi, Kullanici, Son_Erisim_Tarihi) values('" + txtDirPath.Text + "', '" + txtFilePath.Text + "', '" + encMethod.Text + "', '" + label5.Text + "', GETDATE())";
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
            }
            
        }
        //check sum dosya yolu seçer
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            DialogResult result = fdlg.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fdlg.FileName;
                textBox1.Text = file;


            }
        }
        //şifrelenen dosyayının
        //şifresini çözer
        private void button1_Click(object sender, EventArgs e)
        {
            if (label9.Text.Equals("GUEST     "))
            {
                MessageBox.Show("Bu işlem için yetkiye sahip değilsiniz");
            }
            else
            {
                String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=sifreleme;integrated security=true";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand komut = new SqlCommand();

                komut.Connection = con;
                komut.CommandText = "delete from dbo.table_sifrelenenler where ID=" + textBox2.Text;
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
            }
        }
    }
}
