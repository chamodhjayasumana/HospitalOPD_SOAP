using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DB_Connection
/// </summary>
public class DB_Connection
{
    public DB_Connection()
    {
    }

    public SqlConnection GetConnection()
    {
        String Connection_string = ConfigurationManager.ConnectionStrings["HospitalManagementOPD"].ConnectionString.ToString();
        SqlConnection con = new SqlConnection(Connection_string);
        return con;

    }
}