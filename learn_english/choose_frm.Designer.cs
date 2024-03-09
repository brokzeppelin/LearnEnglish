namespace learn_english
{
    partial class choose_form
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
            this.lbl_word = new System.Windows.Forms.Label();
            this.lbl_definition = new System.Windows.Forms.Label();
            this.btn_add_word_to_train = new System.Windows.Forms.Button();
            this.btn_next_word = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_word
            // 
            this.lbl_word.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_word.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word.ForeColor = System.Drawing.Color.White;
            this.lbl_word.Location = new System.Drawing.Point(55, 67);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(785, 57);
            this.lbl_word.TabIndex = 0;
            this.lbl_word.Text = "lbl_word";
            // 
            // lbl_definition
            // 
            this.lbl_definition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_definition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_definition.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_definition.ForeColor = System.Drawing.Color.White;
            this.lbl_definition.Location = new System.Drawing.Point(56, 133);
            this.lbl_definition.Name = "lbl_definition";
            this.lbl_definition.Size = new System.Drawing.Size(785, 57);
            this.lbl_definition.TabIndex = 1;
            this.lbl_definition.Text = "lbl_definition";
            // 
            // btn_add_word_to_train
            // 
            this.btn_add_word_to_train.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_word_to_train.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add_word_to_train.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_add_word_to_train.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_add_word_to_train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_word_to_train.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_word_to_train.ForeColor = System.Drawing.Color.White;
            this.btn_add_word_to_train.Location = new System.Drawing.Point(508, 289);
            this.btn_add_word_to_train.Name = "btn_add_word_to_train";
            this.btn_add_word_to_train.Size = new System.Drawing.Size(175, 41);
            this.btn_add_word_to_train.TabIndex = 2;
            this.btn_add_word_to_train.Text = "Add to train";
            this.btn_add_word_to_train.UseVisualStyleBackColor = false;
            this.btn_add_word_to_train.Click += new System.EventHandler(this.btn_add_word_to_train_Click);
            // 
            // btn_next_word
            // 
            this.btn_next_word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next_word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_next_word.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_next_word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next_word.ForeColor = System.Drawing.Color.White;
            this.btn_next_word.Location = new System.Drawing.Point(840, 101);
            this.btn_next_word.Name = "btn_next_word";
            this.btn_next_word.Size = new System.Drawing.Size(25, 25);
            this.btn_next_word.TabIndex = 3;
            this.btn_next_word.Text = ">";
            this.btn_next_word.UseVisualStyleBackColor = false;
            this.btn_next_word.Click += new System.EventHandler(this.btn_next_word_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(690, 289);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 41);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start  >>";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // choose_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(894, 356);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btn_next_word);
            this.Controls.Add(this.btn_add_word_to_train);
            this.Controls.Add(this.lbl_definition);
            this.Controls.Add(this.lbl_word);
            this.Name = "choose_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "choose_new_words";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Label lbl_definition;
        private System.Windows.Forms.Button btn_add_word_to_train;
        private System.Windows.Forms.Button btn_next_word;
        private System.Windows.Forms.Button btnStart;
    }
}