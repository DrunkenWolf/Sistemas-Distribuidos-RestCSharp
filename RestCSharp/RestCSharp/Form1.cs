using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44327/api/produto/GetCliente/" + textBox1.Text + textBox2.Text;
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                Console.WriteLine(objResponse.ToString());
                MessageBox.Show(objResponse.ToString());
                Console.ReadLine();
                streamDados.Close();
                resposta.Close();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e) //CONSULTAR SALDO 10 11
        {
            string url = "http://localhost:8080/WSbakREST/webresources/Clientes/" + textBox10.Text + textBox11.Text;
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                Console.WriteLine(objResponse.ToString());
                MessageBox.Show(objResponse.ToString());
                Console.ReadLine();
                streamDados.Close();
                resposta.Close();
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }


        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)  //CADASTRAR CLIENTE 13 12 14
        {
            Models.Cliente c = new Models.Cliente();
            c.Nome = textBox13.Text;
            c.Senha = Convert.ToInt32(textBox12.Text);
            c.Saldo = Convert.ToInt32(textBox14.Text);

            string DATA = JsonConvert.SerializeObject(c);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/WSbakREST/webresources/Clientes);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;
            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(DATA);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    string response = responseReader.ReadToEnd();
                    MessageBox.Show(response);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e) // ALTERAR CLIENTE 18 17 16 15
        {
            Models.Cliente c = new Models.Cliente();
            c.Id = Convert.ToInt32(textBox18.Text);
            c.Nome = textBox17.Text;
            c.Senha = Convert.ToInt32(textBox16.Text);
            c.Saldo = Convert.ToInt32(textBox15.Text);

            string DATA = JsonConvert.SerializeObject(c);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/WSbakREST/webresources/Clientes");
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;
            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(DATA);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    string response = responseReader.ReadToEnd();
                    MessageBox.Show(response);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e) //DELETAR 19
        {
            string url = "http://localhost:8080/WSbakREST/webresources/Clientes/" + textBox19.Text;
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "DELETE";

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                Console.WriteLine(objResponse.ToString());
                MessageBox.Show(objResponse.ToString());
                Console.ReadLine();
                streamDados.Close();
                resposta.Close();
            }
        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e) // SAQUE 21 20
        {
            Models.Cliente c = new Models.Cliente();
            c.Id = Convert.ToInt32(textBox21.Text);
            c.Saldo = Convert.ToInt32(textBox20.Text);

            string DATA = JsonConvert.SerializeObject(c);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/WSbakREST/webresources/Clientes/saque/");
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;
            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(DATA);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    string response = responseReader.ReadToEnd();
                    MessageBox.Show(response);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e) //DEPOSITO 23 22
        {
            Models.Cliente c = new Models.Cliente();
            c.Id = Convert.ToInt32(textBox23.Text);
            c.Saldo = Convert.ToInt32(textBox22.Text);

            string DATA = JsonConvert.SerializeObject(c);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/WSbakREST/webresources/Clientes/dep/ ");
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;
            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(DATA);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    string response = responseReader.ReadToEnd();
                    MessageBox.Show(response);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox22_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
