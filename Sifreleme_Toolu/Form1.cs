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
    public partial class Form1 : Form
    {
        // diğer formlara geçiş için 
        // arayüz nesneleri tanımlanıyor
        public Form2 frm2;
        public Form3 frm3;

        public Form1()
        {
            // from iki nesnesi
            // oluşturuluyor
            frm2 = new Form2();
            InitializeComponent();
            frm2.frm1 = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        //hatalı giriş sayısını 
        //hesaplamak için 
        //global sayaç değişkeni
        int button_click_count=0;
        //kullanıcı yetkilendirmesi
        //için global_id 
        public int user_id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int user_index = 0;
            //veri tabanı bağlantı parametreleri
            String constring = "server=MUSTAFAPC\\SQLEXPRESS;database=kullanicilar;integrated security=true";
            //bağlantı nesnesi oluşturur
            SqlConnection con = new SqlConnection(constring);
            //bağlantıyı açar
            con.Open();
            //text tabanlı komut arayüzü
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            //kullanıcı listeleri alınır
            komut.CommandText = "SELECT * FROM dbo.kullanici";
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = komut;
            DataTable dt = new DataTable();
            //kullanıcı listeleri veri tablolarına alınır
            adap.Fill(dt);
            //girilen verilerin eşleşmelerini
            //kontrol etmek için gerekli string 
            //dizileri
            String[] kllnici_adi=new String[1500];
            String[] kllnici_sifre = new String[1500];
            //veri tabanından veriler okunur
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                kllnici_adi[i] = Convert.ToString(dt.Rows[i]["AD"]);
                Debug.Write(kllnici_adi[i]);
                Debug.Write("\n");


            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                kllnici_sifre[i] = Convert.ToString(dt.Rows[i]["PASS"]);

            }
            //kullanıcı adı kontrol ediliyor
            //eşleşme olmazsa user_id -1 değerini alır
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (kllnici_adi[i].Equals(kullanici_adi.Text))
                {
                    user_id = 100 + i;
                    user_index = i;
                    Debug.Write(i + "\n");
                    break;
                }
                user_id = -1;
            }
            if (user_id == -1)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                button_click_count++;
                label4.Text = "Başarısız giriş denemesi!!!";
                label5.Text = Convert.ToString(3 - button_click_count) + " Deneme hakkınız kaldı";
                if (button_click_count > 2)
                    Application.Exit();


            }
            else
            {
                //şifre kontrol edilir
                //eşleşme olursa 
                //veritabanına oturum bilgileri kaydedilir
                if (kllnici_sifre[user_index].Equals(sifre.Text))
                {
                    komut.Connection = con;
                    komut.CommandText = "update dbo.kullanici set LOGIN_STATE='TRUE' WHERE ID="+Convert.ToString( user_id);
                    komut.CommandType = CommandType.Text;
                    komut.ExecuteNonQuery();
                    adap.SelectCommand = komut;
                    MessageBox.Show("correct");
                    this.Hide();
                    //Form2 frm2 = new Form2();
                    //frm2.label
                    
                    frm2.Show();
                }
                //üç başarısız giriş denemsinden
                //sonra program otomatik kapanır
                else
                {
                    button_click_count++;
                    label4.Text = "Başarısız giriş denemesi!!!";
                    label5.Text = Convert.ToString(3 - button_click_count) + " Deneme hakkınız kaldı";
                    if (button_click_count > 2)
                        Application.Exit();

                    MessageBox.Show("Şifre hatalı");
                }
            }

        }
        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            sifre.PasswordChar = '*';
            

        }

        private void kullanici_adi_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
