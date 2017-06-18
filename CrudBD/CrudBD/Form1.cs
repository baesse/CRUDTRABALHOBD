using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtCpf_Leave(object sender, EventArgs e)
        {
            Models.Cliente Cliente = new Models.Cliente() {

                Cpf = TxtCpf.ToString().Replace(".",""),
                

            };

            Models.Endereco Endereco = new Models.Endereco()
            {
                Bairro = txtbairro.Text,
                Cidade=txtcidade.Text,               

            };
            Cliente.Cpf = Cliente.Cpf.Replace("_", "");
            Cliente= Cliente.BuscarCliente(Cliente);
            Cbbsexo.Text = Cliente.Sexo;
            textnome.Text = Cliente.Nome;
            cbbestadocivil.Text = Cliente.EstadoCivil;
            txtprofissao.Text = Cliente.Profissao;
            dateTimePicker1.Text = Cliente.DataNascimento.ToString();
            txttipodocumento.Text = Cliente.TipoDocumento;
            txtnumerodocumento.Text = Cliente.NumeroDocumento;
            txtorgaoemissor.Text = Cliente.OrgaoEmissor;
            txtcpfconjuge.Text = Cliente.cpfConjuge;
            txtnomeconjuge.Text = Cliente.Conjuge;
            txtnomemae.Text = Cliente.nomemae;
            txtnomepai.Text = Cliente.nomepai;          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Models.Cliente Cliente = new Models.Cliente()
            {

              Cpf = TxtCpf.ToString().Replace(".", ""),           
              Sexo = Cbbsexo.Text,
              Nome= textnome.Text,
              EstadoCivil = cbbestadocivil.Text,
              Profissao= txtprofissao.Text,
              DataNascimento = Convert.ToDateTime( dateTimePicker1.Text),
              TipoDocumento=txttipodocumento.Text,
              NumeroDocumento = txtnumerodocumento.Text,
             OrgaoEmissor= txtorgaoemissor.Text ,
             cpfConjuge=txtcpfconjuge.Text,
             Conjuge=txtnomeconjuge.Text,
             nomemae= txtnomemae.Text,
             nomepai= txtnomepai.Text,

             };

        


            if(Cliente.Cpf=="" || Cliente.Sexo == ""|| Cliente.Nome == "" || Cliente.EstadoCivil == "" || Cliente.Profissao == "" || Cliente.DataNascimento.Equals(null))
            {
                MessageBox.Show("Favor preencher todos os campors obrigatorios","Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }else
            {
                Cliente.InsertNovoCadastro(Cliente);
            }

         
           

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Models.Cliente Cliente = new Models.Cliente()
            {

                Cpf = TxtCpf.ToString().Replace(".", ""),
                Sexo = Cbbsexo.Text,
                Nome = textnome.Text,
                EstadoCivil = cbbestadocivil.Text,
                Profissao = txtprofissao.Text,
                DataNascimento = Convert.ToDateTime(dateTimePicker1.Text),
                TipoDocumento = txttipodocumento.Text,
                NumeroDocumento = txtnumerodocumento.Text,
                OrgaoEmissor = txtorgaoemissor.Text,
                cpfConjuge = txtcpfconjuge.Text,
                Conjuge = txtnomeconjuge.Text,
                nomemae = txtnomemae.Text,
                nomepai = txtnomepai.Text,

            };

            if (Cliente.Cpf == "" || Cliente.Sexo == "" || Cliente.Nome == "" || Cliente.EstadoCivil == "" || Cliente.Profissao == "" || Cliente.DataNascimento.Equals(null))
            {
                MessageBox.Show("Favor preencher todos os campors obrigatorios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Cliente.UpdateCliente(Cliente);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Models.Cliente Cliente = new Models.Cliente()
            {

                Cpf = TxtCpf.ToString().Replace(".", ""),
                Sexo = Cbbsexo.Text,
                Nome = textnome.Text,
                EstadoCivil = cbbestadocivil.Text,
                Profissao = txtprofissao.Text,
                DataNascimento = Convert.ToDateTime(dateTimePicker1.Text),
                TipoDocumento = txttipodocumento.Text,
                NumeroDocumento = txtnumerodocumento.Text,
                OrgaoEmissor = txtorgaoemissor.Text,
                cpfConjuge = txtcpfconjuge.Text,
                Conjuge = txtnomeconjuge.Text,
                nomemae = txtnomemae.Text,
                nomepai = txtnomepai.Text,

            };



            if (Cliente.Cpf == "" || Cliente.Sexo == "" || Cliente.Nome == "" || Cliente.EstadoCivil == "" || Cliente.Profissao == "" || Cliente.DataNascimento.Equals(null))
            {
                MessageBox.Show("Favor preencher todos os campors obrigatorios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Cliente.DeleteCliente(Cliente);
            }

          
        }
    }
}
