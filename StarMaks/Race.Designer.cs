namespace StarMaks
{
    partial class Race
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Race));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnConitue = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.picBorderRight = new System.Windows.Forms.PictureBox();
            this.picBorderLeft = new System.Windows.Forms.PictureBox();
            this.picLine3 = new System.Windows.Forms.PictureBox();
            this.picLine2 = new System.Windows.Forms.PictureBox();
            this.picLine1 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(26, 13);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(85, 27);
            this.lblCoins.TabIndex = 27;
            this.lblCoins.Text = "Coins:0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(120, 223);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(119, 27);
            this.lblGameOver.TabIndex = 22;
            this.lblGameOver.Text = "GameOver";
            // 
            // btnConitue
            // 
            this.btnConitue.Location = new System.Drawing.Point(426, 29);
            this.btnConitue.Name = "btnConitue";
            this.btnConitue.Size = new System.Drawing.Size(115, 92);
            this.btnConitue.TabIndex = 30;
            this.btnConitue.Text = "Continue";
            this.btnConitue.UseVisualStyleBackColor = true;
            this.btnConitue.Visible = false;
            this.btnConitue.Click += new System.EventHandler(this.BtnConitue_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(584, 34);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(116, 83);
            this.btnMainMenu.TabIndex = 31;
            this.btnMainMenu.Text = "Mein Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Visible = false;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(94, 29);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(80, 109);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 28;
            this.enemy3.TabStop = false;
            this.enemy3.Visible = false;
            // 
            // picBorderRight
            // 
            this.picBorderRight.BackColor = System.Drawing.Color.White;
            this.picBorderRight.Location = new System.Drawing.Point(382, -9);
            this.picBorderRight.Name = "picBorderRight";
            this.picBorderRight.Size = new System.Drawing.Size(11, 466);
            this.picBorderRight.TabIndex = 18;
            this.picBorderRight.TabStop = false;
            // 
            // picBorderLeft
            // 
            this.picBorderLeft.BackColor = System.Drawing.Color.White;
            this.picBorderLeft.Location = new System.Drawing.Point(12, -5);
            this.picBorderLeft.Name = "picBorderLeft";
            this.picBorderLeft.Size = new System.Drawing.Size(11, 466);
            this.picBorderLeft.TabIndex = 17;
            this.picBorderLeft.TabStop = false;
            // 
            // picLine3
            // 
            this.picLine3.BackColor = System.Drawing.Color.White;
            this.picLine3.Location = new System.Drawing.Point(180, 345);
            this.picLine3.Name = "picLine3";
            this.picLine3.Size = new System.Drawing.Size(13, 96);
            this.picLine3.TabIndex = 16;
            this.picLine3.TabStop = false;
            // 
            // picLine2
            // 
            this.picLine2.BackColor = System.Drawing.Color.White;
            this.picLine2.Location = new System.Drawing.Point(180, 207);
            this.picLine2.Name = "picLine2";
            this.picLine2.Size = new System.Drawing.Size(13, 96);
            this.picLine2.TabIndex = 15;
            this.picLine2.TabStop = false;
            // 
            // picLine1
            // 
            this.picLine1.BackColor = System.Drawing.Color.White;
            this.picLine1.Location = new System.Drawing.Point(180, 12);
            this.picLine1.Name = "picLine1";
            this.picLine1.Size = new System.Drawing.Size(13, 96);
            this.picLine1.TabIndex = 14;
            this.picLine1.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(221, 46);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(54, 62);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 26;
            this.coin3.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(48, 366);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(54, 62);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 25;
            this.coin1.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(48, 277);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(54, 62);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 24;
            this.coin4.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(311, 265);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(54, 62);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 23;
            this.coin2.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(285, 119);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(80, 109);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 21;
            this.enemy2.TabStop = false;
            this.enemy2.Visible = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(29, 123);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(85, 104);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 20;
            this.enemy1.TabStop = false;
            this.enemy1.Visible = false;
            // 
            // car1
            // 
            this.car1.Image = ((System.Drawing.Image)(resources.GetObject("car1.Image")));
            this.car1.Location = new System.Drawing.Point(174, 332);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(65, 96);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 19;
            this.car1.TabStop = false;
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 469);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnConitue);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.picBorderRight);
            this.Controls.Add(this.picBorderLeft);
            this.Controls.Add(this.picLine3);
            this.Controls.Add(this.picLine2);
            this.Controls.Add(this.picLine1);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car1);
            this.Name = "Race";
            this.Text = "Race";
            this.Load += new System.EventHandler(this.Race_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Race_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBorderRight;
        private System.Windows.Forms.PictureBox picBorderLeft;
        private System.Windows.Forms.PictureBox picLine3;
        private System.Windows.Forms.PictureBox picLine2;
        private System.Windows.Forms.PictureBox picLine1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Button btnConitue;
        private System.Windows.Forms.Button btnMainMenu;
    }
}