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

namespace Tetris.Controls
{
    public partial class GameRenderCanvas : UserControl
    {
        public GameRenderCanvas()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private readonly Dictionary<int, Color> colors = new Dictionary<int, Color>
        {
            { 0, Color.Transparent },
            { 1, Color.Purple}, 
            { 2, Color.Red }, 
            { 3, Color.Blue }, 
            { 4, Color.Yellow },
            { 5, Color.Green },
            { 6, Color.Orange },
            { 7, Color.Fuchsia },
        };

        public Color BackGridColor { get; set; } = Color.Black;
        public Color OutlineColor { get; set; } = Color.White;

        public float SquareSize { get; set; } = 20;
        public float SquareBorder { get; set; } = 1;

        public Point OffSet { get; set; }


        public GameState GameState { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if(GameState == null)
            {
                return;
            }

            RenderGame(e.Graphics);
        }

        private void RenderGame(Graphics graphics)
        {
            foreach(var p in GameState.GameGrid.GetAllPositions())
            {
                DrawSquare(graphics, p.r, p.c, colors[p.id]);
            }

            var cor = ControlPaint.Light(colors[GameState.CurrentBlock.Id]);

            foreach (var p in GameState.CurrentBlock.TilePositions())
            {
                DrawSquare(graphics, p.Row, p.Column, cor);
            }
        }

        private void DrawSquare(Graphics graphics, int r, int c, Color color)
        {
            if (r < 2) return;

            var x = SquareSize * (float)c;
            var y = SquareSize * (float)(r - 2);
            var rect = new RectangleF(x + (float)OffSet.X, y +  (float)OffSet.Y, SquareSize, SquareSize);

            using (var fill = new SolidBrush(color))
            {
                graphics.FillRectangle(fill, rect);
            }

            using (var outline = new Pen(OutlineColor) { Width = SquareBorder })
            {
                graphics.DrawRectangle(outline, rect.X,  rect.Y, rect.Width, rect.Height);
            }
        }
    }
}
