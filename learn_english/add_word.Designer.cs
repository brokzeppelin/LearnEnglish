namespace learn_english
{
    partial class add_word
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
            this.tb_Word = new System.Windows.Forms.TextBox();
            this.tb_Def = new System.Windows.Forms.TextBox();
            this.lbl_Word = new System.Windows.Forms.Label();
            this.lbl_Def = new System.Windows.Forms.Label();
            this.btn_AddWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Word
            // 
            this.tb_Word.BackColor = System.Drawing.Color.White;
            this.tb_Word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Word.ForeColor = System.Drawing.Color.Black;
            this.tb_Word.Location = new System.Drawing.Point(27, 39);
            this.tb_Word.Name = "tb_Word";
            this.tb_Word.Size = new System.Drawing.Size(919, 20);
            this.tb_Word.TabIndex = 0;
            // 
            // tb_Def
            // 
            this.tb_Def.BackColor = System.Drawing.Color.White;
            this.tb_Def.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Def.ForeColor = System.Drawing.Color.Black;
            this.tb_Def.Location = new System.Drawing.Point(27, 93);
            this.tb_Def.Name = "tb_Def";
            this.tb_Def.Size = new System.Drawing.Size(919, 20);
            this.tb_Def.TabIndex = 1;
            // 
            // lbl_Word
            // 
            this.lbl_Word.AutoSize = true;
            this.lbl_Word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Word.ForeColor = System.Drawing.Color.White;
            this.lbl_Word.Location = new System.Drawing.Point(27, 20);
            this.lbl_Word.Name = "lbl_Word";
            this.lbl_Word.Size = new System.Drawing.Size(33, 13);
            this.lbl_Word.TabIndex = 1;
            this.lbl_Word.Text = "Word";
            // 
            // lbl_Def
            // 
            this.lbl_Def.AutoSize = true;
            this.lbl_Def.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Def.ForeColor = System.Drawing.Color.White;
            this.lbl_Def.Location = new System.Drawing.Point(24, 77);
            this.lbl_Def.Name = "lbl_Def";
            this.lbl_Def.Size = new System.Drawing.Size(51, 13);
            this.lbl_Def.TabIndex = 1;
            this.lbl_Def.Text = "Definitoin";
            // 
            // btn_AddWord
            // 
            this.btn_AddWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AddWord.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_AddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddWord.ForeColor = System.Drawing.Color.White;
            this.btn_AddWord.Location = new System.Drawing.Point(816, 139);
            this.btn_AddWord.Name = "btn_AddWord";
            this.btn_AddWord.Size = new System.Drawing.Size(130, 23);
            this.btn_AddWord.TabIndex = 2;
            this.btn_AddWord.Text = "Submit";
            this.btn_AddWord.UseVisualStyleBackColor = false;
            this.btn_AddWord.Click += new System.EventHandler(this.btn_AddWord_Click);
            // 
            // add_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(980, 189);
            this.Controls.Add(this.btn_AddWord);
            this.Controls.Add(this.lbl_Def);
            this.Controls.Add(this.lbl_Word);
            this.Controls.Add(this.tb_Def);
            this.Controls.Add(this.tb_Word);
            this.Name = "add_word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Word;
        private System.Windows.Forms.TextBox tb_Def;
        private System.Windows.Forms.Label lbl_Word;
        private System.Windows.Forms.Label lbl_Def;
        private System.Windows.Forms.Button btn_AddWord;
    }
}