namespace learn_english
{
    partial class by_letters
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_definition = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_how_many_wrds_left = new System.Windows.Forms.Label();
            this.btn_putOff = new System.Windows.Forms.Button();
            this.tipBrackets = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_definition
            // 
            this.lbl_definition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_definition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_definition.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_definition.ForeColor = System.Drawing.Color.White;
            this.lbl_definition.Location = new System.Drawing.Point(7, 69);
            this.lbl_definition.Name = "lbl_definition";
            this.lbl_definition.Size = new System.Drawing.Size(1038, 94);
            this.lbl_definition.TabIndex = 501;
            this.lbl_definition.Text = "lbl_definition";
            this.lbl_definition.DoubleClick += new System.EventHandler(this.lbl_definition_DoubleClick);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_error.ForeColor = System.Drawing.Color.RosyBrown;
            this.lbl_error.Location = new System.Drawing.Point(457, 163);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(187, 33);
            this.lbl_error.TabIndex = 502;
            this.lbl_error.Text = "Wrong letter!";
            this.lbl_error.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 396);
            this.panel1.TabIndex = 503;
            // 
            // lbl_how_many_wrds_left
            // 
            this.lbl_how_many_wrds_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_how_many_wrds_left.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_how_many_wrds_left.ForeColor = System.Drawing.Color.White;
            this.lbl_how_many_wrds_left.Location = new System.Drawing.Point(898, 12);
            this.lbl_how_many_wrds_left.Name = "lbl_how_many_wrds_left";
            this.lbl_how_many_wrds_left.Size = new System.Drawing.Size(132, 23);
            this.lbl_how_many_wrds_left.TabIndex = 504;
            this.lbl_how_many_wrds_left.Text = "left";
            this.lbl_how_many_wrds_left.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_putOff
            // 
            this.btn_putOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_putOff.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_putOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_putOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_putOff.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.btn_putOff.ForeColor = System.Drawing.Color.White;
            this.btn_putOff.Location = new System.Drawing.Point(11, 12);
            this.btn_putOff.Name = "btn_putOff";
            this.btn_putOff.Size = new System.Drawing.Size(91, 30);
            this.btn_putOff.TabIndex = 510;
            this.btn_putOff.Text = "Put off";
            this.btn_putOff.UseVisualStyleBackColor = false;
            this.btn_putOff.Click += new System.EventHandler(this.btn_putOff_Click);
            // 
            // tipBrackets
            // 
            this.tipBrackets.AutomaticDelay = 100;
            this.tipBrackets.AutoPopDelay = 20000;
            this.tipBrackets.InitialDelay = 100;
            this.tipBrackets.ReshowDelay = 20;
            // 
            // by_letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btn_putOff);
            this.Controls.Add(this.lbl_how_many_wrds_left);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_definition);
            this.Name = "by_letters";
            this.Size = new System.Drawing.Size(1053, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_definition;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_how_many_wrds_left;
        private System.Windows.Forms.Button btn_putOff;
        private System.Windows.Forms.ToolTip tipBrackets;
    }
}
