namespace learn_english
{
    partial class start_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.month_cal = new System.Windows.Forms.MonthCalendar();
            this.grid_for_words = new System.Windows.Forms.DataGridView();
            this.btn_learn = new System.Windows.Forms.Button();
            this.btn_repeat = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_add_word = new System.Windows.Forms.Button();
            this.btn_edit_word = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_reschedule_for = new System.Windows.Forms.Button();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.lbl_how_many_to_train = new System.Windows.Forms.Label();
            this.tip_1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_clear_filter = new System.Windows.Forms.Button();
            this.lbl_statistics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_for_words)).BeginInit();
            this.SuspendLayout();
            // 
            // month_cal
            // 
            this.month_cal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.month_cal.Location = new System.Drawing.Point(160, 28);
            this.month_cal.Name = "month_cal";
            this.month_cal.TabIndex = 0;
            this.month_cal.Visible = false;
            this.month_cal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.month_cal_DateSelected);
            // 
            // grid_for_words
            // 
            this.grid_for_words.AllowUserToAddRows = false;
            this.grid_for_words.AllowUserToOrderColumns = true;
            this.grid_for_words.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_for_words.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grid_for_words.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_for_words.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_for_words.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_for_words.ColumnHeadersHeight = 20;
            this.grid_for_words.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_for_words.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_for_words.EnableHeadersVisualStyles = false;
            this.grid_for_words.Location = new System.Drawing.Point(6, 79);
            this.grid_for_words.Name = "grid_for_words";
            this.grid_for_words.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_for_words.RowHeadersVisible = false;
            this.grid_for_words.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_for_words.Size = new System.Drawing.Size(980, 474);
            this.grid_for_words.TabIndex = 0;
            // 
            // btn_learn
            // 
            this.btn_learn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_learn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_learn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_learn.Location = new System.Drawing.Point(2, 2);
            this.btn_learn.Name = "btn_learn";
            this.btn_learn.Size = new System.Drawing.Size(75, 22);
            this.btn_learn.TabIndex = 7;
            this.btn_learn.Text = "Learn";
            this.btn_learn.UseVisualStyleBackColor = true;
            this.btn_learn.Click += new System.EventHandler(this.btn_learn_Click);
            // 
            // btn_repeat
            // 
            this.btn_repeat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repeat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_repeat.Location = new System.Drawing.Point(81, 2);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(75, 22);
            this.btn_repeat.TabIndex = 8;
            this.btn_repeat.Text = "Repeat all";
            this.btn_repeat.UseVisualStyleBackColor = true;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(265, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(78, 22);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_add_word
            // 
            this.btn_add_word.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_add_word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_word.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_word.Location = new System.Drawing.Point(2, 28);
            this.btn_add_word.Name = "btn_add_word";
            this.btn_add_word.Size = new System.Drawing.Size(75, 22);
            this.btn_add_word.TabIndex = 10;
            this.btn_add_word.Text = "Add word";
            this.btn_add_word.UseVisualStyleBackColor = true;
            this.btn_add_word.Click += new System.EventHandler(this.btn_add_word_Click);
            // 
            // btn_edit_word
            // 
            this.btn_edit_word.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_edit_word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_word.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit_word.Location = new System.Drawing.Point(81, 28);
            this.btn_edit_word.Name = "btn_edit_word";
            this.btn_edit_word.Size = new System.Drawing.Size(75, 22);
            this.btn_edit_word.TabIndex = 11;
            this.btn_edit_word.Text = "Edit word";
            this.btn_edit_word.UseVisualStyleBackColor = true;
            this.btn_edit_word.Click += new System.EventHandler(this.btn_edit_word_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(160, 28);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(101, 22);
            this.btn_remove.TabIndex = 12;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_reschedule_for
            // 
            this.btn_reschedule_for.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_reschedule_for.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reschedule_for.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reschedule_for.Location = new System.Drawing.Point(160, 2);
            this.btn_reschedule_for.Name = "btn_reschedule_for";
            this.btn_reschedule_for.Size = new System.Drawing.Size(101, 22);
            this.btn_reschedule_for.TabIndex = 13;
            this.btn_reschedule_for.Text = "Reschedule for";
            this.btn_reschedule_for.UseVisualStyleBackColor = true;
            this.btn_reschedule_for.Click += new System.EventHandler(this.btn_reschedule_for_Click);
            // 
            // tb_filter
            // 
            this.tb_filter.BackColor = System.Drawing.Color.White;
            this.tb_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_filter.ForeColor = System.Drawing.Color.Black;
            this.tb_filter.Location = new System.Drawing.Point(160, 54);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(183, 20);
            this.tb_filter.TabIndex = 5;
            this.tb_filter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_filter.Location = new System.Drawing.Point(4, 57);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(153, 13);
            this.lbl_filter.TabIndex = 6;
            this.lbl_filter.Text = "Filter by Words and Definitions:";
            this.lbl_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_how_many_to_train
            // 
            this.lbl_how_many_to_train.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_how_many_to_train.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_how_many_to_train.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_how_many_to_train.Location = new System.Drawing.Point(816, 1);
            this.lbl_how_many_to_train.Name = "lbl_how_many_to_train";
            this.lbl_how_many_to_train.Size = new System.Drawing.Size(170, 48);
            this.lbl_how_many_to_train.TabIndex = 3;
            this.lbl_how_many_to_train.Tag = "";
            this.lbl_how_many_to_train.Text = "No words to train";
            this.lbl_how_many_to_train.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tip_1.SetToolTip(this.lbl_how_many_to_train, "Click right here to start training");
            this.lbl_how_many_to_train.Click += new System.EventHandler(this.lbl_how_many_to_train_Click);
            // 
            // tip_1
            // 
            this.tip_1.AutomaticDelay = 100;
            // 
            // btn_clear_filter
            // 
            this.btn_clear_filter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_clear_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear_filter.Location = new System.Drawing.Point(345, 54);
            this.btn_clear_filter.Name = "btn_clear_filter";
            this.btn_clear_filter.Size = new System.Drawing.Size(20, 20);
            this.btn_clear_filter.TabIndex = 14;
            this.btn_clear_filter.Text = "-";
            this.btn_clear_filter.UseVisualStyleBackColor = true;
            this.btn_clear_filter.Click += new System.EventHandler(this.btn_clear_filter_Click);
            // 
            // lbl_statistics
            // 
            this.lbl_statistics.AutoSize = true;
            this.lbl_statistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_statistics.Location = new System.Drawing.Point(412, 1);
            this.lbl_statistics.Name = "lbl_statistics";
            this.lbl_statistics.Size = new System.Drawing.Size(65, 39);
            this.lbl_statistics.TabIndex = 15;
            this.lbl_statistics.Text = "Learned: \r\nNot learned:\r\nTotal:";
            // 
            // start_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(987, 557);
            this.Controls.Add(this.lbl_statistics);
            this.Controls.Add(this.month_cal);
            this.Controls.Add(this.btn_clear_filter);
            this.Controls.Add(this.grid_for_words);
            this.Controls.Add(this.btn_learn);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.btn_reschedule_for);
            this.Controls.Add(this.lbl_filter);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_how_many_to_train);
            this.Controls.Add(this.btn_edit_word);
            this.Controls.Add(this.btn_add_word);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_repeat);
            this.MinimumSize = new System.Drawing.Size(550, 38);
            this.Name = "start_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn english words";
            this.Resize += new System.EventHandler(this.start_frm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grid_for_words)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_how_many_to_train;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.Button btn_learn;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_add_word;
        private System.Windows.Forms.Button btn_edit_word;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_reschedule_for;
        private System.Windows.Forms.DataGridView grid_for_words;
        private System.Windows.Forms.MonthCalendar month_cal;
        private System.Windows.Forms.ToolTip tip_1;
        private System.Windows.Forms.Button btn_clear_filter;
        private System.Windows.Forms.Label lbl_statistics;
    }
}

