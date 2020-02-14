using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employes
{
    public class DBHelper
    {
        public static string sqlConnectionString = "Data Source=<default>;Initial Catalog=<default>;Persist Security Info=<default>;User ID=<default>;Password=<default>";
        public bool connectionOnline = false;
        public SqlConnection sqlConnection = null;
        public DBHelper(string _DataSource, string _InitialCatalog, string _User, string _Password)
        {
            string AssebledConnectionString =
                    "Data Source=" + _DataSource + ";" +
                    "Initial Catalog=" + _InitialCatalog + ";" +
                    "Persist Security Info=True;" +
                    "User ID=" + _User + ";" +
                    "Password=" + _Password;
            connectionOnline = false;
            InitializeConnection(AssebledConnectionString);

        }
        public DBHelper()
        {
            connectionOnline = false;
            InitializeConnection(sqlConnectionString);
        }
        public DBHelper(string sqlCustomConnectionString = null)
        {
            connectionOnline = false;
            InitializeConnection(sqlCustomConnectionString);
        }
        public void Dispose()
        {
            this.DisengageConnection();
            sqlConnection = null;
        }
        void InitializeConnection(string sqlCustomConnectionString = null)
        {
            try
            {
                if ((connectionOnline) || (sqlConnection != null)) return;
                sqlConnection = new SqlConnection(sqlCustomConnectionString ?? sqlConnectionString);
                sqlConnection.Open();
                connectionOnline = true;
            }
            catch
            {
                connectionOnline = false;
                
                //Не удалось соединиться с базой данных
            }
        }
        void DisengageConnection()
        {
            if ((!connectionOnline) || (sqlConnection == null)) return;
            sqlConnection.Close();
            connectionOnline = false;
        }
        public SqlCommand AddEmployer(Forms.NewEmploye emp)
        {
            // string str = String.Format("insert into dbo.Employes (FullName, Sex, Birthday) Values ({0}, {1}, {2})", emp.NewEmployer.NewFullName, emp.NewEmployer.NewSex, emp.NewEmployer.NewBirthday);
            string str = "select * from dbo.Employes";
            SqlCommand sqlCommand = new SqlCommand(str, sqlConnection)
            {
                CommandType = CommandType.Text
            };
            var ex = sqlCommand.ExecuteNonQuery();
            return sqlCommand;
        }

 /*       public SqlCommand DeleteEmployer(Forms.NewEmploye emp)
        {
            SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            return sqlCommand;
        }

        public SqlCommand UpdateEmployer(Forms.NewEmploye emp)
        {
            SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            return sqlCommand;
        }

        public SqlCommand FindEmployer(Forms.NewEmploye emp)
        {
            SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            return sqlCommand;
        }

    */
    }
}
