using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace schoolManagement
{
    class MyCon
    {
        public OleDbConnection conn()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:/SSM/SSM.mdb");
            con.Open();
            return con;
        }

        public int putData(string sqlcmd,OleDbConnection con)
        {
            OleDbCommand com = new OleDbCommand(sqlcmd, con);
            int n = com.ExecuteNonQuery();
            return n;
        }
        public OleDbDataReader getData(string sqlcmd,OleDbConnection con)
        {
            OleDbCommand com = new OleDbCommand(sqlcmd, con);
            OleDbDataReader dr = com.ExecuteReader();
            return dr;
        }

        public DataTable getTable(string sqlcmd, OleDbConnection con)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter dapt = new OleDbDataAdapter(sqlcmd,con);
            dapt.Fill(dt);
            return (dt);
        }
    }
}
