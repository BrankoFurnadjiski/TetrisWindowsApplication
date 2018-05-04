using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisProject
{
    public partial class Top10Form : Form
    {
        public Top10Form(List<int> players)
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder();
            for(int i=0; i < players.Count; ++i)
            {
                sb.Append((i+1).ToString() + ".\t" + players[i].ToString() + "\n");
            }
            lblTop10.Text = sb.ToString();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
    }
}
