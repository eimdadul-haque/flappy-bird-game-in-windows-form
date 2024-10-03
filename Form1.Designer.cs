namespace flappy_bird_game_in_windows_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GameTimer = new System.Windows.Forms.Timer(components);
            Bird = new PictureBox();
            PipeDown = new PictureBox();
            PipeUp = new PictureBox();
            Ground = new PictureBox();
            scoreBoard = new Label();
            ((System.ComponentModel.ISupportInitialize)Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // Bird
            // 
            Bird.Image = Properties.Resources.bird;
            Bird.Location = new Point(103, 219);
            Bird.Name = "Bird";
            Bird.Size = new Size(60, 53);
            Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            Bird.TabIndex = 0;
            Bird.TabStop = false;
            // 
            // PipeDown
            // 
            PipeDown.Image = Properties.Resources.pipedown;
            PipeDown.Location = new Point(541, -115);
            PipeDown.Name = "PipeDown";
            PipeDown.Size = new Size(100, 261);
            PipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeDown.TabIndex = 1;
            PipeDown.TabStop = false;
            // 
            // PipeUp
            // 
            PipeUp.Image = Properties.Resources.pipe;
            PipeUp.Location = new Point(541, 408);
            PipeUp.Name = "PipeUp";
            PipeUp.Size = new Size(100, 282);
            PipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeUp.TabIndex = 2;
            PipeUp.TabStop = false;
            // 
            // Ground
            // 
            Ground.Image = Properties.Resources.ground;
            Ground.Location = new Point(-19, 551);
            Ground.Name = "Ground";
            Ground.Size = new Size(707, 78);
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
            Ground.TabIndex = 3;
            Ground.TabStop = false;
            // 
            // scoreBoard
            // 
            scoreBoard.AutoSize = true;
            scoreBoard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreBoard.Location = new Point(12, 6);
            scoreBoard.Name = "scoreBoard";
            scoreBoard.Size = new Size(65, 21);
            scoreBoard.TabIndex = 4;
            scoreBoard.Text = "Score: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(653, 621);
            Controls.Add(scoreBoard);
            Controls.Add(Ground);
            Controls.Add(PipeUp);
            Controls.Add(PipeDown);
            Controls.Add(Bird);
            Name = "Form1";
            Text = "Flappy Bird";
            KeyDown += GameKeyIsDown;
            KeyUp += GameKeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private PictureBox Bird;
        private PictureBox PipeDown;
        private PictureBox PipeUp;
        private PictureBox Ground;
        private Label scoreBoard;
    }
}
