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
    public partial class start_frm : Form
    {
        GetFromAccess getFromAccess = new GetFromAccess();
        int fixed_pixels_for_cols;
        Int32 how_many;
                public start_frm()
        {
            InitializeComponent();
            start_frm_Activate();
        }
        
        private void start_frm_Activate()
        {
            grid_for_words.DataSource = getFromAccess.get_table(String.Format(@"Select word as Words, definition as Definitions, status as S, train_count as Train_number, train_next_date as Next_train, id_word as ID FROM Words WHERE word LIKE '%{0}%' or definition LIKE '%{0}%' ORDER BY train_next_date, status, train_count ASC", tb_filter.Text));
            int learned = (Int32)getFromAccess.get_table("SELECT count(1) FROM Words WHERE status = 2").Rows[0][0];
            int being_learned = (Int32)getFromAccess.get_table("SELECT count(1) FROM Words WHERE status = 1").Rows[0][0];
            int not_learned = (Int32)getFromAccess.get_table("SELECT count(1) FROM Words WHERE status = 0").Rows[0][0];
            int total = (Int32)getFromAccess.get_table("SELECT count(1) FROM Words").Rows[0][0];
            grid_for_words.Columns["S"].Width = 16;
            grid_for_words.Columns["Train_number"].Width = 16;
            grid_for_words.Columns["Next_train"].Width = 92;
            grid_for_words.Columns["ID"].Width = 32;
            fixed_pixels_for_cols = grid_for_words.Columns[2].Width + grid_for_words.Columns[3].Width +
                grid_for_words.Columns["Next_train"].Width + grid_for_words.Columns[5].Width;
            grid_for_words.Columns["Words"].Width = (this.Width - fixed_pixels_for_cols - 40) / 2;
            grid_for_words.Columns["Definitions"].Width = grid_for_words.Columns[0].Width;

            grid_for_words.Columns[0].DefaultCellStyle.ForeColor = Color.FromArgb(64,64,64);

            string now_full_date = DateTime.Now.ToString("MM") + @"/" + DateTime.Now.ToString("dd") + @"/" + DateTime.Now.ToString("yyyy HH:mm:sstt");
            how_many = (Int32)(getFromAccess.get_table(@"SELECT count(*) FROM Words 
            WHERE ((Words.train_next_date)<#" + now_full_date + "#) AND (Words.status=1) AND (Words.trained=Yes);").Rows[0][0]);

            lbl_how_many_to_train.Text = "Ready for training: " + how_many;
            lbl_statistics.Text = String.Format("Learned: {0}\nBeing learned: {1}\nNot learned: {2} (~{4}%)\nTotal: {3}", learned, being_learned, not_learned, total, Math.Round(((double)not_learned / (double)total * 100)));
        }

        private void createNewTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose_form choose_new_form = new choose_form();
            choose_new_form.Show();
        }

        private void repeatLearnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            train_frm train_form = new train_frm("general");
            train_form.Show();
        }

        private void trainAllAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            train_frm train_form = new train_frm("by_letters");
            train_form.Show();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_frm_Activate();
        }

        private void AddStripMenuItem_Click(object sender, EventArgs e)
        {
            add_word add_word = new add_word();
            add_word.Show();
        }

        private void EditStripMenuItem_Click(object sender, EventArgs e)
        {
            add_word edit_word = new add_word(grid_for_words.CurrentRow);
            edit_word.Show();
        }

        private void RemoveStripMenuItem_Click(object sender, EventArgs e)
        {
            int id_word = (int)grid_for_words.CurrentRow.Cells[5].Value;
            getFromAccess.execute(String.Format("DELETE FROM Words WHERE id_word = {0}", id_word));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (grid_for_words.DataSource as DataTable).DefaultView.RowFilter =
    string.Format("Words LIKE '%{0}%' OR Definitions LIKE '%{0}%'", tb_filter.Text);
        }

        private void btn_learn_Click(object sender, EventArgs e)
        {
            choose_form choose_new_form = new choose_form();
            choose_new_form.Show();
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            train_frm train_form = new train_frm("general");
            train_form.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            start_frm_Activate();
        }

        private void btn_add_word_Click(object sender, EventArgs e)
        {
            add_word add_word = new add_word();
            add_word.Show();
        }

        private void btn_edit_word_Click(object sender, EventArgs e)
        {
            add_word edit_word = new add_word(grid_for_words.CurrentRow);
            edit_word.Show();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int id_word = (int)grid_for_words.CurrentRow.Cells[5].Value;
            getFromAccess.execute(String.Format("DELETE FROM Words WHERE id_word = {0}", id_word));
            start_frm_Activate();
        }

        private void lbl_how_many_to_train_Click(object sender, EventArgs e)
        {
            if (how_many > 0)
            {
                train_frm train_form = new train_frm("by_letters");
                train_form.Show();
            }
        }

        private void btn_reschedule_for_Click(object sender, EventArgs e)
        {
            month_cal.Visible = !month_cal.Visible;
        }

        private void month_cal_DateSelected(object sender, DateRangeEventArgs e)
        {
            string new_date = month_cal.SelectionStart.ToString("MM") + @"/" + month_cal.SelectionStart.ToString("dd") + @"/" + month_cal.SelectionStart.ToString("yyyy 08:mm:sstt");
            foreach (DataGridViewRow r in grid_for_words.SelectedRows)
            {
                int id_word = (int)r.Cells[5].Value;
                getFromAccess.execute(String.Format("UPDATE Words SET train_next_date = #{0}# WHERE id_word = {1}", new_date, id_word));
            }
            month_cal.Visible = false;
            start_frm_Activate();
        }

        private void btn_clear_filter_Click(object sender, EventArgs e)
        {
            tb_filter.Text = String.Empty;
            start_frm_Activate();
            tb_filter.Focus();
        }

        private void start_frm_Resize(object sender, EventArgs e)
        {
            grid_for_words.Columns[0].Width = (this.Width - fixed_pixels_for_cols - 40) / 2;
            grid_for_words.Columns[1].Width = grid_for_words.Columns[0].Width;
        }
    }
}
