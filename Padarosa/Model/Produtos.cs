using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyEncryption;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padarosa.Model
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public  double preco { get; set; }
        public int id_categoria { get; set; }
        public int id_respCadastro { get; set; }


        public bool Cadatrar()
        {
            string comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) " +
                "VALUES (@nome, @preco, @id_categoria, @id_respcadastro)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", id_respCadastro);
            cmd.Prepare();
            // para impedir que o programa quebre 
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            // se der erro, ele ira desconectar do bd
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public DataTable Listar()
        {
            string comando = "SELECT  id, nome, preco, id_categoria, id_respcadastro FROM produtos;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Remover()
        {
            string comando = "DELETE FROM  produtos  WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);

            cmd.Prepare();
            // para impedir que o programa quebre 
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            // se der erro, ele ira desconectar do bd
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool Modificar()
        {
            string comando = "UPDATE produtos SET nome = @nome, " +
         "preco = @preco, id_categoria = @id_categoria, id_respcadastro = @id_respcadastro  WHERE id = @id";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", id_respCadastro);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            // para impedir que o programa quebre 
            //try
            //{
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            //}
            //// se der erro, ele ira desconectar do bd
            //catch
            //{
            //    conexaoBD.Desconectar(con);
            //    return false;
            //}
        }
    }

}
