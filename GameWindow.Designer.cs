
namespace GameFramework
{
    partial class GameWindow
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.Image = global::GameFramework.Properties.Resources.robberrub;
            this.picBox.Location = new System.Drawing.Point(637, 282);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(150, 150);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // picBox3
            // 
            this.picBox3.BackColor = System.Drawing.Color.Transparent;
            this.picBox3.Image = global::GameFramework.Properties.Resources.robberrub;
            this.picBox3.Location = new System.Drawing.Point(353, 282);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(150, 150);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 2;
            this.picBox3.TabStop = false;
            // 
            // picBox4
            // 
            this.picBox4.BackColor = System.Drawing.Color.Transparent;
            this.picBox4.Image = global::GameFramework.Properties.Resources.robberrub;
            this.picBox4.Location = new System.Drawing.Point(219, 282);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(150, 150);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox4.TabIndex = 3;
            this.picBox4.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BackColor = System.Drawing.Color.Transparent;
            this.picBox2.Image = global::GameFramework.Properties.Resources.robberrub;
            this.picBox2.Location = new System.Drawing.Point(492, 282);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(150, 150);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 4;
            this.picBox2.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameFramework.Properties.Resources.GameScene1__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.PictureBox picBox2;
    }
}

