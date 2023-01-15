namespace Tetris
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gameRenderCanvas1 = new Tetris.Controls.GameRenderCanvas();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameRenderCanvas1
            // 
            this.gameRenderCanvas1.BackColor = System.Drawing.Color.Black;
            this.gameRenderCanvas1.BackGridColor = System.Drawing.Color.Black;
            this.gameRenderCanvas1.GameState = null;
            this.gameRenderCanvas1.Location = new System.Drawing.Point(13, 13);
            this.gameRenderCanvas1.Name = "gameRenderCanvas1";
            this.gameRenderCanvas1.OffSet = new System.Drawing.Point(5, 5);
            this.gameRenderCanvas1.OutlineColor = System.Drawing.Color.White;
            this.gameRenderCanvas1.Size = new System.Drawing.Size(211, 411);
            this.gameRenderCanvas1.SquareBorder = 1F;
            this.gameRenderCanvas1.SquareSize = 20F;
            this.gameRenderCanvas1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameRenderCanvas1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.GameRenderCanvas gameRenderCanvas1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

