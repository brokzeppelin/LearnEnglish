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
    public partial class choose_form : Form
    {
        int number_of_chosen = 0;//количество выбранных слов для изучения
        DataTable dt_wordsToLearn;
        int random_index;
        List<int> viewedWordsIds = new List<int> ();
        Random r = new Random();
        GetFromAccess getFromAccess = new GetFromAccess();

        public choose_form()
        {
            InitializeComponent();
            dt_wordsToLearn = getFromAccess.get_table("Select * from Words where Status = 0");

            if (dt_wordsToLearn.Rows.Count > 0)
                btn_next_word_Click(null, null);
            else SetWindowsForEmptyTable();            
        }

        private void SetWindowsForEmptyTable()
        {
            lbl_word.Text = "There are no words to be learned";
            lbl_definition.Text = String.Empty;
            btn_add_word_to_train.Visible = false;
            btn_next_word.Visible = false;
            btnStart.Visible = false;
        }

        private void btn_add_word_to_train_Click(object sender, EventArgs e)
        {
            number_of_chosen++;

            btnStart.Text = "Start " + number_of_chosen.ToString() + " >>";
            getFromAccess.execute(string.Format("UPDATE Words SET status = 1, train_start_date = #{0}#, train_next_date = #{0}# WHERE id_word = {1}", 
                DateTime.Now.ToString("MM") + @"/" + DateTime.Now.ToString("dd") + @"/" + DateTime.Now.ToString("yyyy HH:mm:sstt"), dt_wordsToLearn.Rows[random_index][0].ToString()));

            dt_wordsToLearn = getFromAccess.get_table("Select * from Words where Status = 0");
                btn_next_word_Click(null, null);
        }

        private void btn_next_word_Click(object sender, EventArgs e)
        {
            random_index = r.Next(dt_wordsToLearn.Rows.Count); 

            while (viewedWordsIds.Contains(random_index))
            {
                if (dt_wordsToLearn.Rows.Count == viewedWordsIds.Count)
                {
                    viewedWordsIds.Clear();
                }
                random_index = r.Next(dt_wordsToLearn.Rows.Count); 
            }

            viewedWordsIds.Add(random_index);

            lbl_word.Text = dt_wordsToLearn.Rows[random_index][1].ToString();
            lbl_definition.Text = dt_wordsToLearn.Rows[random_index][2].ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {  
                this.Close();
                train_frm train_form = new train_frm(0);
                train_form.Show();                    
        }           
    }
}
