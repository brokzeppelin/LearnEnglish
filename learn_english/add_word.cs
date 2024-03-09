using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 

namespace learn_english
{    
    public partial class add_word : Form
    {
        GetFromAccess getFromAccess = new GetFromAccess();
        DataGridViewRow _r;
        public add_word()
        {
            InitializeComponent();
        }

        public add_word(DataGridViewRow r)
        {
            InitializeComponent();
            _r = r;
            tb_Word.Text = r.Cells[0].Value.ToString();
            tb_Def.Text = r.Cells[1].Value.ToString();
        }

        private void btn_AddWord_Click(object sender, EventArgs e)
        {
            if (_r != null) {
                getFromAccess.execute(String.Format(@"UPDATE Words SET word = '{0}', definition = '{1}' WHERE id_word = {2};", tb_Word.Text, tb_Def.Text, _r.Cells[5].Value));
                this.Dispose();
            } else {
                string date_next = DateTime.Now.ToString("12") + @"/" + DateTime.Now.ToString("31") + @"/" + DateTime.Now.ToString("9999 10:00:sstt");
                getFromAccess.execute(String.Format(@"INSERT INTO Words ( word, definition, status , train_next_date ) Values ('{0}' , '{1}' , 0 , #{2}#);", tb_Word.Text, tb_Def.Text, date_next)); 
                tb_Word.Text = "";
                tb_Def.Text = "";
                tb_Word.Focus();
            }
        }
    }
}
