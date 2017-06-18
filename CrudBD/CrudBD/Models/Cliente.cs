using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBD.Models
{
    class Cliente
    {
        public String Cpf { get; set; }
        public String Nome { get; set; }
        public String Sexo { get; set; }
        public String EstadoCivil { get; set; }
        public String Profissao { get; set; }
        public DateTime DataNascimento { get; set; }
        public String TipoDocumento { get; set; }
        public String NumeroDocumento { get; set; }
        public String OrgaoEmissor { get; set; }
        public String Cep { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Nacionalidade { get; set; }
        public String Cidade { get; set; }
        public String Uf { get; set; }
        public String Pais { get; set; }
        public String Conjuge { get; set; }
        public String cpfConjuge { get; set; }
        public String nomepai { get; set; }
        public String nomemae { get; set; }
        public DateTime Datacadastro { get; set; }



        public Cliente(String Cpf, String Nome, String Sexo, String EstadoCivil, String Profissao, DateTime DataNascimento, String TipoDocumento, String NumeroDocumento, String OrgaoEmissor, String Cep, String Endereco, String Bairro, String Nacionalidade, String Cidade, String Uf, String Pais, String Conjuge, String cpfConjuge, String nomepai, String Nomemae, DateTime Datacadastro)
        {
            this.Cpf = Cpf;
            this.Nome = Nome;
            this.Sexo = Sexo;
            this.EstadoCivil = EstadoCivil;
            this.Profissao = Profissao;
            this.DataNascimento = DataNascimento;
            this.TipoDocumento = TipoDocumento;
            this.NumeroDocumento = NumeroDocumento;
            this.OrgaoEmissor = OrgaoEmissor;
            this.Cep = Cep;
            this.Endereco = Endereco;
            this.Bairro = Bairro;
            this.Nacionalidade = Nacionalidade;
            this.Cidade = Cidade;
            this.Uf = Uf;
            this.Pais = Pais;
            this.Conjuge = Conjuge;
            this.cpfConjuge = cpfConjuge;
            this.nomepai = nomepai;
            this.nomemae = Nomemae;
            this.Datacadastro = Datacadastro;



        }
        public Cliente()
        {

        }


        public String InsertNovoCadastro(Cliente NovoCliente)
        {
            try
            {
                MySqlConnection Conexao = Banco.GetConexao();
                MySqlCommand Comando = Banco.GetComando(Conexao);
                Comando.CommandText = "INSERT INTO cliente(cpfcliente,nome,sexo,estadocivil,profissao,datanascimento,tipodocumento,numerodedocumento,orgaoemissor,cep,endereco,nacionalidade,conjugenome,cpfcojuge,nomepai,nomemae)VALUES(@cpfcliente ,@nome ,@sexo ,@estadocivil ,@profissao ,@datanascimento ,@tipodocumento ,@numerodedocumento ,@orgaoemissor ,@cep ,@endereco ,@nacionalidade ,@conjugenome ,@cpfconjuge ,@nomepai ,@nomemae)";
                Comando.Parameters.AddWithValue("@cpfcliente", NovoCliente.Cpf);
                Comando.Parameters.AddWithValue("@nome", NovoCliente.Nome);
                Comando.Parameters.AddWithValue("@estadocivil", NovoCliente.EstadoCivil);
                Comando.Parameters.AddWithValue("@profissao", NovoCliente.Profissao);
                Comando.Parameters.AddWithValue("@datanascimento", NovoCliente.DataNascimento);
                Comando.Parameters.AddWithValue("@tipodocumento", NovoCliente.TipoDocumento);
                Comando.Parameters.AddWithValue("@numerodedocumento", NovoCliente.NumeroDocumento);
                Comando.Parameters.AddWithValue("@orgaoemissor", NovoCliente.OrgaoEmissor);
                Comando.Parameters.AddWithValue("@cep", NovoCliente.Cep);
                Comando.Parameters.AddWithValue("@endereco", NovoCliente.Endereco);
                Comando.Parameters.AddWithValue("@nacionalidade", NovoCliente.Nacionalidade);
                Comando.Parameters.AddWithValue("@conjugenome", NovoCliente.Conjuge);
                Comando.Parameters.AddWithValue("@cpfcojuge", NovoCliente.cpfConjuge);
                Comando.Parameters.AddWithValue("@nomepai", NovoCliente.nomepai);
                Comando.Parameters.AddWithValue("@nomemae", NovoCliente.nomemae);
                Comando.ExecuteNonQuery();
                Conexao.Close();

                return "Cliente Cadastrado";

            }catch(Exception)
            {
                return "Erro ao tentar cadastrar usuario contate o suporte";

            }

             

        }
        public String UpdateCliente(Cliente UpdateCliente)
        {

            try
            {
                MySqlConnection Conexao = Banco.GetConexao();
                MySqlCommand Comando = Banco.GetComando(Conexao);
                Comando.CommandText = "UPDATE cliente SET cpfcliente = @cpfcliente ,nome = @nome ,sexo = @sexo ,estadocivil = @estadocivil ,profissao = @profissao ,datanascimento = @datanascimento ,tipodocumento = @tipodocumento ,numerodedocumento = @numerodedocumento ,orgaoemissor = @orgaoemissor ,cep = @cep ,endereco = @endereco ,nacionalidade = @nacionalidade ,conjugenome = @conjugenome ,cpfconjuge =@cpfconjuge ,nomepai =@nomepai ,nomemae = @nomemae  WHERE cpfcliente = @cpfcliente;";
                Comando.Parameters.AddWithValue("@cpfcliente", UpdateCliente.Cpf);
                Comando.Parameters.AddWithValue("@nome", UpdateCliente.Nome);
                Comando.Parameters.AddWithValue("@estadocivil", UpdateCliente.EstadoCivil);
                Comando.Parameters.AddWithValue("@profissao", UpdateCliente.Profissao);
                Comando.Parameters.AddWithValue("@datanascimento", UpdateCliente.DataNascimento);
                Comando.Parameters.AddWithValue("@tipodocumento", UpdateCliente.TipoDocumento);
                Comando.Parameters.AddWithValue("@numerodedocumento", UpdateCliente.NumeroDocumento);
                Comando.Parameters.AddWithValue("@orgaoemissor", UpdateCliente.OrgaoEmissor);
                Comando.Parameters.AddWithValue("@cep", UpdateCliente.Cep);
                Comando.Parameters.AddWithValue("@endereco", UpdateCliente.Endereco);
                Comando.Parameters.AddWithValue("@nacionalidade", UpdateCliente.Nacionalidade);
                Comando.Parameters.AddWithValue("@conjugenome", UpdateCliente.Conjuge);
                Comando.Parameters.AddWithValue("@cpfcojuge", UpdateCliente.cpfConjuge);
                Comando.Parameters.AddWithValue("@nomepai", UpdateCliente.nomepai);
                Comando.Parameters.AddWithValue("@nomemae", UpdateCliente.nomemae);
                Comando.ExecuteNonQuery();
                Conexao.Close();

                return "Cliente Atualizado";

            }
            catch (Exception)
            {
                return "Erro ao tentar atualizar usuario contate o suporte";

            }


        }
        public String DeleteCliente(Cliente DeleteCliente)
        {


            try
            {
                MySqlConnection Conexao = Banco.GetConexao();
                MySqlCommand Comando = Banco.GetComando(Conexao);
                Comando.CommandText = "DELETE FROM cliente WHERE cpfcliente=@cpfcliente";
                Comando.ExecuteNonQuery();
                Conexao.Close();

                return "Cliente Deleteado";

            }
            catch (Exception)
            {
                return "Erro ao tentar Deletar cliente contate o suporte";

            }

        }
        public Cliente BuscarCliente(Cliente BuscaCliente)
        {
            try
            {
                
                MySqlConnection Conexao = Banco.GetConexao();
                MySqlCommand Comando = Banco.GetComando(Conexao);
                Comando.CommandText = "SELECT cpfcliente,nome,sexo,estadocivil,profissao,datanascimento,tipodocumento,numerodedocumento,orgaoemissor,cep,endereco,nacionalidade,conjugenome,cpfconjuge,nomepai,nomemae where cpfcliente=@cpf FROM cliente;";
                Comando.Parameters.AddWithValue("@cpf", BuscaCliente.Cpf);


                MySqlDataReader Reader = Banco.GetReader(Comando);

                while (Reader.Read())
                {
                    Cliente cliente = new Cliente(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetDateTime(5), Reader.GetString(6), Reader.GetString(7), Reader.GetString(8), Reader.GetString(9), Reader.GetString(10), Reader.GetString(11), Reader.GetString(12), Reader.GetString(13), Reader.GetString(14), Reader.GetString(15), Reader.GetString(16), Reader.GetString(17), Reader.GetString(19), Reader.GetString(20), Reader.GetDateTime(21));
                    return cliente;

                }
                Conexao.Close();
                return null;


            }
            catch (Exception)
            {
                return null;

            }


        }

      
    }
}
