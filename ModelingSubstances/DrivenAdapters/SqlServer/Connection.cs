using System.Data.SqlClient;
namespace ModelingSubstances.DrivenAdapters.SqlServer
{
    public class Connection
    {
        private string stringSQL = string.Empty;

            public Connection() 
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            stringSQL = builder.GetSection("ConnectionStrings:ModelingSubstancesConnectionString").Value;
            }

        public string getCadenaSql() 
        {
            return stringSQL;
        }
    }
}
