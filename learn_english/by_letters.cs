using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;


namespace learn_english
{
    public partial class by_letters : UserControl
    {
        DataTable dt_wordsToLearn;
        GetFromAccess getFromAccess = new GetFromAccess();
        int random_index;
        string word_eng;
        string[] splittedEng;
        string[] splittedDef;
        byte currentStatus;
        Timer timer = new Timer();
        int errors = 0;
        public by_letters()
        {
            InitializeComponent();
            string now_full_date = DateTime.Now.ToString("MM") + @"/" + DateTime.Now.ToString("dd") + @"/" + DateTime.Now.ToString("yyyy HH:mm:sstt");
            dt_wordsToLearn = getFromAccess.get_table(@"SELECT Words.id_word, Words.status, Words.word, Words.definition, Words.train_next_date, Words.train_count FROM Words 
            WHERE ((Words.train_next_date)<#" + now_full_date + "#) AND (Words.status=1) AND (Words.trained=Yes);");
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
            panel1.Controls.Clear();
            Random r = new Random();
            random_index = r.Next(dt_wordsToLearn.Rows.Count);
            word_eng = dt_wordsToLearn.Rows[random_index][2].ToString().ToLower();
            splittedDef = dt_wordsToLearn.Rows[random_index][3].ToString().ToLower().Split('{');
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
                        tx.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                        tx.Location = new Point(x,y);
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

        void check_if_last_row()
        {
            panel1.Controls.Clear();
            DataRow dr_current = dt_wordsToLearn.Rows[random_index];
            int wordId = Convert.ToInt32(dt_wordsToLearn.Rows[random_index][0]);
            byte currentTrainCount = Convert.ToByte(dt_wordsToLearn.Rows[random_index][5]);
            byte newTrainCount = currentTrainCount;
            DateTime currentDateTime = DateTime.Now;
            if (errors > 0 && currentTrainCount > 0)
            {
                if (MessageBox.Show("Reset the progress?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes) // got errors? if user answers Yes we reset the progress to -1 status
                {     
                    newTrainCount = currentTrainCount == 1 ? Convert.ToByte(currentTrainCount - 1) : Convert.ToByte(currentTrainCount - 2);                    
                    dt_wordsToLearn.Rows[random_index][5] = newTrainCount;
                    dt_wordsToLearn.AcceptChanges();
                    getFromAccess.execute(string.Format("UPDATE Words SET train_count = {0} WHERE id_word = {1}", newTrainCount, wordId.ToString()));         
                }
                dt_wordsToLearn.ImportRow(dr_current);
            }
            else
            {
                string train_next_date = "";
                string date_next = currentDateTime.ToString("12") + @"/" + currentDateTime.ToString("31") + @"/" + currentDateTime.ToString("9999 10:00:sstt");
                if (currentTrainCount == 6)
                {

                    getFromAccess.execute(string.Format(
                        "UPDATE Words SET status = 2, train_next_date = '{2}', train_end_date = '{0}', train_count = 0 WHERE id_word = {1}",
                        DateTime.Now.ToString(), dt_wordsToLearn.Rows[random_index][0], date_next));
                }
                else
                {
                    DateTime nextTrainDate;
                    switch (currentTrainCount)
                    {
                        case 0:
                            nextTrainDate = DateTime.Now.AddDays(1);
                            train_next_date = nextTrainDate.ToString("MM") + @"/" + nextTrainDate.ToString("dd") + @"/" + nextTrainDate.ToString("yyyy 08:00:sstt");
                            break;
                        case 1:
                            nextTrainDate = DateTime.Now.AddDays(3);
                            train_next_date = nextTrainDate.ToString("MM") + @"/" + nextTrainDate.ToString("dd") + @"/" + nextTrainDate.ToString("yyyy 08:00:sstt");
                            break;
                        case 2:
                            nextTrainDate = DateTime.Now.AddDays(7);
                            train_next_date = nextTrainDate.ToString("MM") + @"/" + nextTrainDate.ToString("dd") + @"/" + nextTrainDate.ToString("yyyy 08:00:sstt");
                            break;
                        case 3:
                            nextTrainDate = DateTime.Now.AddDays(14);
                            train_next_date = nextTrainDate.ToString("MM") + @"/" + nextTrainDate.ToString("dd") + @"/" + nextTrainDate.ToString("yyyy 08:00:sstt");
                            break;
                        case 4:
                            nextTrainDate = DateTime.Now.AddDays(36);
                            train_next_date = nextTrainDate.ToString("MM") + @"/" + nextTrainDate.ToString("dd") + @"/" + nextTrainDate.ToString("yyyy 08:00:sstt");
                            break;
                        case 5:
                            nextTrainDate = DateTime.Now.AddDays(90);
                            train_next_date = nextTrainDate.ToString("MM") + @"/" + nextTrainDate.ToString("dd") + @"/" + nextTrainDate.ToString("yyyy 08:00:sstt");
                            break;
                    }
                    getFromAccess.execute(string.Format(
                             "UPDATE Words set train_next_date = #{0}#, train_count = {1} WHERE id_word = {2}",
                             train_next_date, currentTrainCount + 1, dt_wordsToLearn.Rows[random_index][0]));
                }
            }
            errors = 0;
            dr_current.Delete();
            dt_wordsToLearn.AcceptChanges();
            if (dt_wordsToLearn.Rows.Count >= 1)
                random();
            else
                    {
                            this.Parent.Parent.Hide();
             }
        }

        void tx_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxBase t = (TextBoxBase)sender;
            if (t.Text != splittedEng[0][t.TabIndex].ToString())
            {
                if (e.KeyValue != 27)
                {
                    lbl_error.Visible = true;
                    t.Text = "";
                    timer.Interval = 4000;
                    timer.Enabled = true;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    errors++;
                }
            }
            else {
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

        void timer_Tick(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            timer.Stop();
        }

        private void btn_putOff_Click(object sender, EventArgs e)
        {
            DataRow dr_current = dt_wordsToLearn.Rows[random_index];
            errors = 0;
            dr_current.Delete();
            dt_wordsToLearn.AcceptChanges();
            if (dt_wordsToLearn.Rows.Count >= 1)
                random();
            else
            {
                this.Parent.Parent.Hide();
            }
        }

        private void lbl_definition_DoubleClick(object sender, EventArgs e)
        {
            if (lbl_definition.Text.Contains("{..}"))
            lbl_definition.Text = lbl_definition.Text.Replace("..}", splittedDef[1]);
            else lbl_definition.Text = lbl_definition.Text.Substring(0, lbl_definition.Text.IndexOf('{')) + "{..}";
        }
    }
}
