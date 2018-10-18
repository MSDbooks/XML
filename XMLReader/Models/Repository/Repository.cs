using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace XMLReader.Models.Repository
{
    public class Repository : IRepository, IDisposable
    {

        private String strConnection;
        private SqlConnection connection;

        public Repository()
        {
            strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["NFe"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            if (connection == null)
                connection = new SqlConnection(strConnection);

            return connection;
                 
        }

        public void Dispose()
        {

            if (connection != null)
                connection.Dispose();

            connection = null;

        }
        
    }
}
