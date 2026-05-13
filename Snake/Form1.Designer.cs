namespace Snake
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            Timer = new System.Windows.Forms.Timer(components);
            Start = new Button();
            Difficulty = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Interval = 80;
            Timer.Tick += Tick;
            // 
            // Start
            // 
            Start.BackColor = Color.Transparent;
            Start.Cursor = Cursors.Hand;
            Start.FlatAppearance.BorderSize = 0;
            Start.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Start.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Start.FlatStyle = FlatStyle.Flat;
            Start.ForeColor = Color.Transparent;
            Start.Location = new Point(244, 194);
            Start.Name = "Start";
            Start.Size = new Size(297, 73);
            Start.TabIndex = 0;
            Start.UseVisualStyleBackColor = false;
            Start.Click += button1_Click;
            // 
            // Difficulty
            // 
            Difficulty.BackColor = Color.Transparent;
            Difficulty.Cursor = Cursors.Hand;
            Difficulty.FlatAppearance.BorderSize = 0;
            Difficulty.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Difficulty.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Difficulty.FlatStyle = FlatStyle.Flat;
            Difficulty.ForeColor = Color.Transparent;
            Difficulty.Location = new Point(244, 273);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new Size(297, 80);
            Difficulty.TabIndex = 1;
            Difficulty.UseVisualStyleBackColor = false;
            Difficulty.Click += Difficulty_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(244, 359);
            button3.Name = "button3";
            button3.Size = new Size(297, 80);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(button3);
            Controls.Add(Difficulty);
            Controls.Add(Start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(801, 601);
            MinimumSize = new Size(800, 600);
            Name = "Board";
            Text = "Board";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Button Start;
        private Button Difficulty;
        private Button button3;
    }
}
