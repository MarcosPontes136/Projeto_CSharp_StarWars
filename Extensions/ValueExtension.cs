using System.Data.SqlClient;


namespace Projeto_CShap_Com_SQL.Extensions
{
    public static class ValueExtension
    {

        public static T GetValueOrDefault<T>(this SqlDataReader reader, string campo)
        {
            try
            {
                return (T)reader[campo];
            }
            catch
            {
                return default(T);
            }
        }

    }
}
