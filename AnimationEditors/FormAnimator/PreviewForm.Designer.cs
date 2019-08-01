namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class PreviewForm
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
            Zeroit.Framework.Transitions.ZeroitFormAnimator.Grow grow1 = new Zeroit.Framework.Transitions.ZeroitFormAnimator.Grow();
            Zeroit.Framework.Transitions.ZeroitFormAnimator.Locations locations1 = new Zeroit.Framework.Transitions.ZeroitFormAnimator.Locations();
            Zeroit.Framework.Transitions.ZeroitFormAnimator.Move move1 = new Zeroit.Framework.Transitions.ZeroitFormAnimator.Move();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            Zeroit.Framework.Transitions.ZeroitFormAnimator.Opacity opacity1 = new Zeroit.Framework.Transitions.ZeroitFormAnimator.Opacity();
            Zeroit.Framework.Transitions.ZeroitFormAnimator.Positions positions1 = new Zeroit.Framework.Transitions.ZeroitFormAnimator.Positions();
            Zeroit.Framework.Transitions.ZeroitFormAnimator.Shake shake1 = new Zeroit.Framework.Transitions.ZeroitFormAnimator.Shake();
            Zeroit.Framework.Transitions.ZeroitFormAnimator.Timer timer1 = new Zeroit.Framework.Transitions.ZeroitFormAnimator.Timer();
            this.nyx1 = new Zeroit.Framework.Transitions.ThemeManagers.NYX();
            this.automaticReset_CheckBox = new System.Windows.Forms.CheckBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.startReset = new System.Windows.Forms.Button();
            this.animator = new Zeroit.Framework.Transitions.ZeroitFormAnimator.ZeroitFormAnimator(this.components);
            this.nyx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nyx1
            // 
            this.nyx1.Animated = true;
            this.nyx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.nyx1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyx1.Colors = new Zeroit.Framework.Transitions.ThemeManagers.Bloom[0];
            this.nyx1.Controls.Add(this.automaticReset_CheckBox);
            this.nyx1.Controls.Add(this.closeBtn);
            this.nyx1.Controls.Add(this.startReset);
            this.nyx1.Customization = "";
            this.nyx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nyx1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyx1.Image = null;
            this.nyx1.Location = new System.Drawing.Point(0, 0);
            this.nyx1.Movable = true;
            this.nyx1.Name = "nyx1";
            this.nyx1.NoRounding = false;
            this.nyx1.Sizable = true;
            this.nyx1.Size = new System.Drawing.Size(524, 251);
            this.nyx1.SmartBounds = true;
            this.nyx1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.nyx1.TabIndex = 0;
            this.nyx1.Text = "Preview Form";
            this.nyx1.TitleColor = System.Drawing.Color.White;
            this.nyx1.TitleFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.nyx1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nyx1.Transparent = false;
            // 
            // automaticReset_CheckBox
            // 
            this.automaticReset_CheckBox.AutoSize = true;
            this.automaticReset_CheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.automaticReset_CheckBox.ForeColor = System.Drawing.Color.White;
            this.automaticReset_CheckBox.Location = new System.Drawing.Point(14, 32);
            this.automaticReset_CheckBox.Name = "automaticReset_CheckBox";
            this.automaticReset_CheckBox.Size = new System.Drawing.Size(119, 17);
            this.automaticReset_CheckBox.TabIndex = 56;
            this.automaticReset_CheckBox.Text = "Automatic Reset";
            this.automaticReset_CheckBox.UseVisualStyleBackColor = false;
            this.automaticReset_CheckBox.Visible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeBtn.Location = new System.Drawing.Point(504, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(17, 18);
            this.closeBtn.TabIndex = 55;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // startReset
            // 
            this.startReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.startReset.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.startReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.startReset.Location = new System.Drawing.Point(186, 102);
            this.startReset.Name = "startReset";
            this.startReset.Size = new System.Drawing.Size(157, 62);
            this.startReset.TabIndex = 54;
            this.startReset.Text = "Start";
            this.startReset.UseVisualStyleBackColor = false;
            // 
            // animator
            // 
            this.animator.Animation = Zeroit.Framework.Transitions.ZeroitFormAnimator.FormAnimationTypes.LeftToRight;
            grow1.End = 100;
            grow1.EndPoint = new System.Drawing.Point(100, 100);
            grow1.FixWindowWhenGrown = true;
            grow1.Recalculate = true;
            grow1.Size = new System.Drawing.Size(100, 0);
            grow1.Start = 0;
            grow1.StartPoint = new System.Drawing.Point(0, 0);
            this.animator.Grow = grow1;
            locations1.FormLocations = Zeroit.Framework.Transitions.ZeroitFormAnimator.FormLocations.TopLeft;
            this.animator.Locations = locations1;
            move1.DirectTrajectory = true;
            move1.EndPoint = new System.Drawing.Point(100, 100);
            move1.RandomLocations = ((System.Collections.Generic.List<System.Drawing.Point>)(resources.GetObject("move1.RandomLocations")));
            move1.StartPoint = new System.Drawing.Point(0, 0);
            this.animator.Move = move1;
            this.animator.MoveToPoint = false;
            opacity1.Start = 0.5D;
            opacity1.Step = 1D;
            this.animator.Opacity = opacity1;
            positions1.End = 100;
            positions1.EndPoint = new System.Drawing.Point(100, 100);
            positions1.ShrinkToCenter = true;
            positions1.Size = new System.Drawing.Size(200, 200);
            positions1.Start = 0;
            positions1.StartPoint = new System.Drawing.Point(0, 0);
            this.animator.Positions = positions1;
            shake1.ShakeDistance = 30;
            shake1.ShakeSpeed = 20;
            shake1.ShakeType = Zeroit.Framework.Transitions.ZeroitFormAnimator.ShakeType.Horizontal;
            this.animator.Shake = shake1;
            timer1.StepX = 5;
            timer1.StepY = 5;
            timer1.Time = 20;
            this.animator.Time = timer1;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 251);
            this.Controls.Add(this.nyx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreviewForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PreviewForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.PreviewForm_Load);
            this.nyx1.ResumeLayout(false);
            this.nyx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ThemeManagers.NYX nyx1;
        public System.Windows.Forms.Button startReset;
        private System.Windows.Forms.Button closeBtn;
        public ZeroitFormAnimator.ZeroitFormAnimator animator;
        public System.Windows.Forms.CheckBox automaticReset_CheckBox;
    }
}