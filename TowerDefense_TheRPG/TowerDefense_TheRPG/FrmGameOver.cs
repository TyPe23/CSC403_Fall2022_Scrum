using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowerDefense_TheRPG.code;

namespace TowerDefense_TheRPG {
  public partial class FrmGameOver : Form {
    public FrmGameOver() {
      InitializeComponent();
    }

    private void FrmGameOver_FormClosing(object sender, FormClosingEventArgs e) {
      FormManager.ClearAndCloseFormStack();
    }

    private void Menu_Click(object sender, EventArgs e) {
       FormManager.ClearAndCloseFormStack();
       //FrmMain frm = new FrmMain();
       Application.Restart();
           
    }

        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
