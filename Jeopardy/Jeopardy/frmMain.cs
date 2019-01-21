﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            frmPlayGame playGameForm = new frmPlayGame();
            playGameForm.ShowDialog();
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            frmCreateGame createGameForm = new frmCreateGame();
            createGameForm.ShowDialog();
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            frmCreateGame createGameForm = new frmCreateGame();
            createGameForm.ShowDialog();
        }
    }
}
