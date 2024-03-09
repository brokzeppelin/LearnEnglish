using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace learn_english
{
    public partial class general : UserControl
    {
        string train_type;
        DataTable dt_wordsToLearn;
        GetFromAccess getFromAccess = new GetFromAccess();
        int random_index;
        string word_eng;
        string[] splittedEng;
        string[] splittedDef;
        Timer timer = new Timer();
        int errors = 0;
        public general()
        {
            InitializeComponent();
            train_type = "status=2";
            dt_wordsToLearn = getFromAccess.get_table(@"SELECT Words.word, Words.definition FROM Words WHERE Status = 2");
            random();
        }

        public general(int train_id)
        {            
            InitializeComponent();
            train_type = "status=1";
            DateTime currentDateTime = DateTime.Now;
            string now_full_date = currentDateTime.ToString("MM") + @"/" + currentDateTime.ToString("dd") + @"/" + currentDateTime.ToString("yyyy HH:mm:sstt");
            dt_wordsToLearn = getFromAccess.get_table(@"SELECT Words.word, Words.definition, Words.id_word FROM Words 
            WHERE ((Words.train_next_date)<=#" + now_full_date + "#) AND (Words.status=1) AND (Words.trained=No);");
            random();
        }

        void InsertLabel(Label _lbl, string tipMessage)
        {
            _lbl.Size = new Size(32, 23);
            _lbl.Font = new Font("Constantina", 10, FontStyle.Bold);
            _lbl.ForeColor = Color.RosyBrown;
            _lbl.BackColor = Color.FromArgb(64, 64, 64);
            _lbl.BorderStyle = BorderStyle.FixedSingle;

            _lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            _lbl.Text = "{..}";
            tipBrackets.SetToolTip(_lbl, tipMessage.Trim('}'));
        }

        private void random()
        {
            Random r = new Random();
            random_index = r.Next(dt_wordsToLearn.Rows.Count);
            word_eng = dt_wordsToLearn.Rows[random_index][0].ToString().ToLower();
            splittedDef = dt_wordsToLearn.Rows[random_index][1].ToString().ToLower().Split('{');
            lbl_definition.Text = splittedDef.Length > 1 ? splittedDef[0] + " {..}" : splittedDef[0];
            int x = 10;
            int y = 0;//205;

            splittedEng = word_eng.Split('{');
            //int first_to_del = word_eng.IndexOf('{');
            //if(first_to_del!=-1)
            //word_eng = word_eng.Remove(first_to_del);
            lbl_how_many_wrds_left.Text = dt_wordsToLearn.Rows.Count + " left";

            if (splittedEng.Length > 1)
            {
                Label lbl = new Label();
                InsertLabel(lbl, splittedEng[1]);
                lbl.Location = new Point(x, y);
                panel1.Controls.Add(lbl);
            x += 40;
            }

            for (int i = 0; i < splittedEng[0].Length; i++)
            {
                try
                {
                    if (splittedEng[0][i] != (int)' ')
                    {
                        TextBox tx = new TextBox();
                        tx.Name = "txtBox_" + i;
                        tx.Size = new Size(14, 23);
                        tx.Font = new Font("Constantina", 10, FontStyle.Bold);
                        tx.ForeColor = Color.White;
                        tx.BackColor = Color.FromArgb(64, 64, 64);
                        tx.TextAlign = HorizontalAlignment.Center;
                        tx.Location = new Point(x, y);
                        tx.TabIndex = i;
                        if (splittedEng[0][i] < 'a' || splittedEng[0][i] > 'z')
                            tx.Text = splittedEng[0][i].ToString();
                        tx.BorderStyle = BorderStyle.None;
                        panel1.Controls.Add(tx);
                        tx.KeyUp += new KeyEventHandler(tx_KeyUp);
                        tx.GotFocus += new EventHandler(tx_GotFocus); 
                        if (x > 700 && y == 0)
                        {
                            x = 10;
                            y = 35;
                        }
                        if (x > 700 && y == 35)
                        {
                            x = 10;
                            y = 70;
                        }
                        if (x > 700 && y == 70)
                        {
                            x = 10;
                            y = 105;
                        }
                        if (x > 700 && y == 105)
                        {
                            x = 10;
                            y = 140;
                        }
                        else x += 15;

                    }
                    else
                    {
                        x += 10;
                    }
                }
                catch { break; }
            }
            panel1.Controls["txtBox_0"].Focus();
        }

        void tx_GotFocus(object sender, EventArgs e)
        {
            TextBoxBase t = (TextBoxBase)sender;
            int tag = t.TabIndex;
            if (splittedEng[0][tag] == (splittedEng[0].Length - 1) && t.Text.Length > 0)
            {
                check_if_last_row();
            }
            if (t.Text.Length == 0)
                return;
            if (t.Text.Length > 0)
            {
                try
                {
                    panel1.Controls["txtBox_" + (t.TabIndex + 1).ToString()].Focus();
                }
                catch
                {
                    try { panel1.Controls["txtBox_" + (t.TabIndex + 2).ToString()].Focus(); }
                    catch { check_if_last_row(); }
                }
            }
        }


        void tx_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxBase t = (TextBoxBase)sender;
            lbl_error.Visible = false;

            if (t.Text != splittedEng[0][t.TabIndex].ToString())
            {
                    lbl_error.Visible = true;
                    t.Text = "";
                    timer.Interval = 4000;
                    timer.Enabled = true;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    errors++;
            }
            else
            {
                try
                {
                    panel1.Controls["txtBox_" + (t.TabIndex + 1).ToString()].Focus();
                }
                catch
                {
                    try { panel1.Controls["txtBox_" + (t.TabIndex + 2).ToString()].Focus(); }
                    catch { check_if_last_row(); }
                }
            }

        }

        void check_if_last_row()
        {
            panel1.Controls.Clear();
            DataRow dr_current = dt_wordsToLearn.Rows[random_index];
            if (errors > 0)
                dt_wordsToLearn.ImportRow(dr_current);
            else
                if (train_type == "status=1")
                {
                    DateTime tomorrow = DateTime.Now.AddHours(24);
                    getFromAccess.execute(string.Format("UPDATE Words SET trained = Yes, train_next_date = #{1}#, train_count = 1 WHERE id_word = {0}", dt_wordsToLearn.Rows[random_index][2], tomorrow.ToString("MM") + @"/" + tomorrow.ToString("dd") + @"/" + tomorrow.ToString("yyyy 08:00:sstt")));
                }
            errors = 0;
            dr_current.Delete();
            dt_wordsToLearn.AcceptChanges();
            if (dt_wordsToLearn.Rows.Count >= 1)
                random();
            else this.Parent.Parent.Hide();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            timer.Stop();
        }

        private void btn_iKnow_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataRow dr_current = dt_wordsToLearn.Rows[random_index];
            if (errors > 0)
                dt_wordsToLearn.ImportRow(dr_current);
            else
                if (train_type == "status=1")
                {
                    DateTime tomorrow = DateTime.Now.AddHours(24);
                    getFromAccess.execute(string.Format("UPDATE Words SET trained = Yes, train_next_date = #{1}#, train_count = 1 WHERE id_word = {0}", dt_wordsToLearn.Rows[random_index][2], tomorrow.ToString("MM") + @"/" + tomorrow.ToString("dd") + @"/" + tomorrow.ToString("yyyy 08:00:sstt")));
                }
            errors = 0;
            dr_current.Delete();
            dt_wordsToLearn.AcceptChanges();
            if (dt_wordsToLearn.Rows.Count >= 1)
                random();
            else this.Parent.Parent.Hide();
        }

        private void lbl_definition_DoubleClick(object sender, EventArgs e)
        {            
            if (lbl_definition.Text.Contains("{..}"))
            lbl_definition.Text = lbl_definition.Text.Replace("..}", splittedDef[1]);
            else lbl_definition.Text = lbl_definition.Text.Substring(0, lbl_definition.Text.IndexOf('{')) + "{..}";
        }
    }
}