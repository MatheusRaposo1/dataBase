using System;
using System.Windows.Forms;
using System.IO;
//SQL serve CE
using System.Data.SqlServerCe;
//SQLite
using System.Data.SQLite;
//MySQL
using MySql.Data.MySqlClient;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQLserve CE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'" ;
            //SqlCeEngine db = new SqlCeEngine(strConection);

            //if (!File.Exists(baseDados))
            //{
            //    db.CreateDatabase();
            //}

            //db.Dispose();

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            ////conexao.ConnectionString = strConection;
            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "Conectado SQLserve CE";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar SQLserve CE\n" + ex;
            //}
            //finally 
            //{
            //conexao.Close();
            //}
            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";


            //if (!File.Exists(baseDados))
            //{
            //    SQLiteConnection.CreateFile(baseDados);
            //}


            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            ////conexao.ConnectionString = strConection;
            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "Conectado SQLite CE";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar SQLite \n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySQL

            string strConnection = "server=127.0.0.1;User Id=root; password=";
            string strConnection2 = "server=127.0.0.1;user Id=root; database=curso_database; password=";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            //conexao.ConnectionString = strConnection
            try
            {
                conexao.Open();
                labelResultado.Text = "Conectou o MySql";

                MySqlCommand comando = new MySqlCommand();
                
                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db ";

                comando.ExecuteNonQuery();
                labelResultado.Text = "Base de dados criada com sucesso.";

                comando.Dispose();
            }
            catch (Exception ex )
            {

                labelResultado.Text = "Erro ao conectar MySql\n" + ex;
            }
            finally 
            { 
                conexao.Close(); 
            }


            #endregion

        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            #region SqlServeCE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            //try
            //{
            //    conexao.Open();
            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE TABLE pessoa (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela criada SqlServerCE";

            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{

            //    labelResultado.Text = ex.Message;
            //}
            //finally 
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";
            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            //try
            //{
            //    conexao.Open();
            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE TABLE pessoa (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela criada SQLite";

            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{

            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql
            string strConnection = "server=127.0.0.1;User Id=root;database=curso_db; password="; 
            MySqlConnection conexao = new MySqlConnection(strConnection);
            
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE pessoa (id INT NOT NULL , nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
                comando.ExecuteNonQuery();

                labelResultado.Text = "Tabela criada MySql";

                comando.Dispose();
            }
            catch (Exception ex)
            {

                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SqlServerCE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            //try
            //{
            //    conexao.Open();
            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0,1000);
            //    string nome = txtName.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoa VALUES(" +id + ",'"+ nome + "','" + email + "')";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido  SqlServerCE";

            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{

            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            //try
            //{
            //    conexao.Open();
            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtName.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoa VALUES(" + id + ",'" + nome + "','" + email + "')";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido  SQLite";

            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{

            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql
            string strConnection = "server=127.0.0.1;User Id=root;database=curso_db; password=";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtName.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoa VALUES(" + id + ",'" + nome + "','" + email + "')";
                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro inserido  MySql";

                comando.Dispose();
            }
            catch (Exception ex)
            {

                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }
    }
}
