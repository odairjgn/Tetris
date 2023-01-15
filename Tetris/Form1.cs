using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.GameEngine;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private GameState gameState;

        public Form1()
        {
            InitializeComponent();
            gameState= new GameState();
            gameRenderCanvas1.GameState = gameState;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameRenderCanvas1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameState.MoveBlockDown();
            gameRenderCanvas1.Invalidate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    break;

                case Keys.Left:
                case Keys.A:
                    gameState.MoveBlockLeft();
                    break;

                case Keys.Right:
                case Keys.D:
                    gameState.MoveBlockRight();
                    break;

                case Keys.Up:
                case Keys.W:
                case Keys.E:
                    gameState.RotateBlockCW();
                    break;

                case Keys.Q:
                    gameState.RotateBlockCCW();
                    break;

                case Keys.Down:
                case Keys.S:
                    gameState.MoveBlockDown();
                    break;
            }

            gameRenderCanvas1.Invalidate();

            return base.ProcessCmdKey(ref msg, keyData);            
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
                case Keys.Shift | Keys.Right:
                case Keys.Shift | Keys.Left:
                case Keys.Shift | Keys.Up:
                case Keys.Shift | Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }
    }
}
