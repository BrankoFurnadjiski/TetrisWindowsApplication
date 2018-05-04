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
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void showText()
        {
            lblText.Text = "Tetris is a deceptively simple game to play.\nWith only a handful of moves to learn, anyone can\nbegin to enjoy Tetris in no time at all.Shapes called\nTetriminos fall from the top and come to rest at the \nbottom. Only one Tetrimino falls at a time.Using the\narrow keys, you can adjust where and how the\nTetriminos fall. By pressing the LEFT and RIGHT\nArrow keys, you can slide the falling Tetrimino from\nside to side. By pressing the UP Arrow key, you can\nrotate the Tetrimino 90 degrees.If You press the Down\nkey You can speed up yout Tetrimino. If You press Space\nthen your Tetrinimo will automatilly fall down on the\nposition You press the button. On the button P You \ncan pause the game if needed. The same button is used\nto unpause the game.You can move the\nTetriminos even after they land at the bottom and\nthe tetrimino will lock down as soon as you stop\ntrying to move it. At that point, the next Tetrimino\nwill begin to fall. Also there is multiplayer mode available\nin which the keys for Player1 are same and instead of using \nspace he will be using NUM0 and the keys for Player2 are \nA for left, D for right, W for rotate and S for speeding up \nyour Tetronimo. Player2 can use the key C to lower down the\nTetronimo fast.";
        }
    }
}
