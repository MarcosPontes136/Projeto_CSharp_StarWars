using System;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Projeto_CShap_Com_SQL.Dao
{
    public abstract class DaoBase : IDisposable
    {
        protected readonly SqlConnection con;

        protected DaoBase()
        {
            con = new SqlConnection(@"Server=DESKTOP-0P02U63\SQLEXPRESS;Database=BancoDeDados_Curso_Java;User Id=sa ;Password=teste;");
        }

        protected async Task Insert(string comando)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            await cmd.ExecuteNonQueryAsync();
            con.Close();
        }

        protected async Task Select(string comando, Action<SqlDataReader> tratamentoLeitura)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            SqlDataReader dr = await cmd.ExecuteReaderAsync();
            tratamentoLeitura(dr);
            con.Close();
        }

        public void Dispose()
        {
            con?.Close();
            con?.Dispose();
        }
    }
}

