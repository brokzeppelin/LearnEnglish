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
    public partial class train_frm : Form
    {
        GetFromAccess getFromAccess = new GetFromAccess();
        public train_frm(string control_name)
        {
            InitializeComponent();
            switch (control_name)
            {
                case "by_letters": 
                    by_letters c_by_letters = new by_letters();
                    panel_main.Controls.Add(c_by_letters);
                    panel_main.Controls[0].Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                    break;
                case "general": 
                    general c_general = new general();
                    panel_main.Controls.Add(c_general);
                    break;
            }
            panel_main.Controls[0].Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
        }

        public train_frm(int train_id)
        {
            InitializeComponent();
            general c_general = new general(train_id);
            panel_main.Controls.Add(c_general);
        }
    }
}
