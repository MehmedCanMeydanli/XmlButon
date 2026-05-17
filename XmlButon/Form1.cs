using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.IO;

namespace XmlButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Kisi
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Ad boþ olamaz");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtYas.Text))
            {
                MessageBox.Show("Yaþ boþ olamaz");
                return;
            }

            if (!int.TryParse(txtYas.Text, out int yas))
            {
                MessageBox.Show("Yaþ sayý olmalý");
                return;
            }

            Kisi kisi = new Kisi()
            {
                Ad = txtAd.Text,
                Yas = yas
            };


            XmlSerializer serializer = new XmlSerializer(typeof(Kisi));

            using (StreamWriter writer = new StreamWriter("kisi.xml"))
            {
                serializer.Serialize(writer, kisi);
            }

            MessageBox.Show("Veri  kaydedildi");
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Kisi));

            using (StreamReader reader = new StreamReader("Kisi.xml"))
            {
                Kisi kisi = (Kisi)serializer.Deserialize(reader);

                txtAd.Text = kisi.Ad;
                txtYas.Text = kisi.Yas.ToString();
            }
            MessageBox.Show("Veri yüklendi");

        }
        
    }
}
