using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifreleme_Toolu
{
    public partial class Form3 : Form
    {
        String user_auth;
        int user_id;
        int user_index;

        public Form3()
        {
            InitializeComponent();
            
        }
        //kullanıcıları listeler
        private void button1_Click(object sender, EventArgs e)
        {
            
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
                dataGridView1.DataSource = dt;
            
        }
        //oturum durumundan
        //aktif kullanıcıyı 
        //ve yetkilerini
        //yükler
        private void Form3_Load(object sender, EventArgs e)
        {
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
            dataGridView1.DataSource = dt;
            String[] kllnici_login_state = new String[1500];
            String[] kllnici_auth = new String[1500];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                kllnici_login_state[i] = Convert.ToString(dt.Rows[i]["LOGIN_STATE"]);
                Debug.Write(kllnici_login_state[i]);
                Debug.Write("\n");
            }
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
                    user_auth = kllnici_auth[i];
                    Debug.Write(i + " " + user_id + " " + user_index + " " + "\n");
                    break;
                }
                else
                    user_id = -1;
            }

        }
        //kullanıcıları ekler
        private void button2_Click(object sender, EventArgs e)
        {

             if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz!");
            }
            else if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Şifre Kısmı Boş Bırakılamaz!");
            }
            else if (!textBox2.Text.Equals (textBox3.Text))
            {
                MessageBox.Show("Şifreler Eşleşmiyor");
            }
            else if (comboBox1.Text.Equals("ADMIN") && (!user_auth.Equals("ADMIN     ")))
            {
                MessageBox.Show("Admin kullanıcıyı sadece Admin ekleyebilir!");
            }
            else
            {
                //eğer gerekli koşullar sağlanırsa 
                //kullanıcıyı ekler
                String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=kullanicilar;integrated security=true";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand komut = new SqlCommand();

                komut.Connection = con;
                komut.CommandText = "insert into dbo.kullanici (AD, PASS, LOGIN_STATE,AUTH) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', 'FALSE', '" + comboBox1.Text + "') ";
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
            }
        }
        //kullanıcıyı siler
        private void button3_Click(object sender, EventArgs e)
        {
            //kullanıcı silme işlemini
            //sadece admin yapabilir
            if (!user_auth.Equals("ADMIN     "))
            {
                MessageBox.Show("Kullanıcı Silme Yetkiniz Bulunmuyor");
            }
            else
            {
                String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=kullanicilar;integrated security=true";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand komut = new SqlCommand();

                komut.Connection = con;
                komut.CommandText = "delete from dbo.kullanici where ID="+ textBox4.Text;
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
            }

            
        }
        //kullanıcıyı güncelleştirir
        private void button4_Click(object sender, EventArgs e)
        {
            // güncelleme işlemi UID üzerinden yapılır
            String updstring = "update dbo.kullanici SET ";
            String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=kullanicilar;integrated security=true";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;

            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("UID Girmelisiniz!");
            }
            else if ((!textBox1.Text.Equals("")) && (!textBox2.Text.Equals("")) && (!comboBox1.Text.Equals("")))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    komut.CommandText = "update dbo.kullanici SET AD = '" + textBox1.Text + "',  PASS = '" + textBox3.Text + "',  AUTH = '" + comboBox1.Text + "' WHERE ID = " + textBox4.Text;
                    komut.CommandType = CommandType.Text;
                    komut.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Şifreler eşleşmiyor");
            }


            else if ((textBox1.Text.Equals("")) && (!textBox2.Text.Equals("")) && (!comboBox1.Text.Equals("")))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    komut.CommandText = "update dbo.kullanici SET  PASS = '" + textBox3.Text + "',  AUTH = '" + comboBox1.Text + "' WHERE ID = " + textBox4.Text;
                    komut.CommandType = CommandType.Text;
                    komut.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Şifreler eşleşmiyor");
            }
            else if ((!textBox1.Text.Equals("")) && (textBox2.Text.Equals("")) && (!comboBox1.Text.Equals("")))
            {
                komut.CommandText = "update dbo.kullanici SET AD = '" + textBox1.Text + "',  AUTH = '" + comboBox1.Text + "' WHERE ID = " + textBox4.Text;
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
            }
            else if ((!textBox1.Text.Equals("")) && (!textBox2.Text.Equals("")) && (comboBox1.Text.Equals("")))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    komut.CommandText = "update dbo.kullanici SET AD = '" + textBox1.Text + "',  PASS = '" + textBox3.Text + "' WHERE ID = " + textBox4.Text;
                    komut.CommandType = CommandType.Text;
                    komut.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Şifreler eşleşmiyor");
            }
            else if ((textBox1.Text.Equals("")) && (textBox2.Text.Equals("")) && (!comboBox1.Text.Equals("")))
            {
                komut.CommandText = "update dbo.kullanici SET AUTH = '" + comboBox1.Text + "' WHERE ID = " + textBox4.Text;
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
            }
            else if ((textBox1.Text.Equals("")) && (!textBox2.Text.Equals("")) && (comboBox1.Text.Equals("")))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                { 
                    komut.CommandText = "update dbo.kullanici SET  PASS = '" + textBox3.Text + "' WHERE ID = " + textBox4.Text;
                    komut.CommandType = CommandType.Text;
                    komut.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Şifreler eşleşmiyor");
            }
            else if ((!textBox1.Text.Equals("")) && (textBox2.Text.Equals("")) && (comboBox1.Text.Equals("")))
            {
                komut.CommandText = "update dbo.kullanici SET AD = '" + textBox1.Text + "' WHERE ID = " + textBox4.Text;
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
            }


          
            
        }
    }
}
