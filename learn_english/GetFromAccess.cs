using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using learn_english.Properties;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace learn_english
{
    class GetFromAccess
    {
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.StartupPath) + "\\_english\\Words.accdb");
        public DataTable get_table(string query){            
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            conn.Close();
            return table;
        }

        public void execute(string query) {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //da.InsertCommand = cmd;
            cmd.ExecuteNonQuery();
            conn.Close();        
        }
    }
}
