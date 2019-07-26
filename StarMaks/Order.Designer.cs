namespace StarMaks
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chCofee = new System.Windows.Forms.CheckBox();
            this.chJuise = new System.Windows.Forms.CheckBox();
            this.chVodka = new System.Windows.Forms.CheckBox();
            this.chChay = new System.Windows.Forms.CheckBox();
            this.txtCofee = new System.Windows.Forms.TextBox();
            this.txtJuice = new System.Windows.Forms.TextBox();
            this.txtVodka = new System.Windows.Forms.TextBox();
            this.txtChay = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckPelmeny = new System.Windows.Forms.CheckBox();
            this.ckBorsh = new System.Windows.Forms.CheckBox();
            this.ckMeat = new System.Windows.Forms.CheckBox();
            this.chCake = new System.Windows.Forms.CheckBox();
            this.txtPelmeny = new System.Windows.Forms.TextBox();
            this.txtMeat = new System.Windows.Forms.TextBox();
            this.txtBorsh = new System.Windows.Forms.TextBox();
            this.txtCake = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.txtCostOfDrink = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNew = new System.Windows.Forms.ToolStripButton();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.tooCut = new System.Windows.Forms.ToolStripButton();
            this.toolCopy = new System.Windows.Forms.ToolStripButton();
            this.toolPaste = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rReceip = new System.Windows.Forms.RichTextBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 18);
            this.panel1.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(6, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(46, 17);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StarMaks.Properties.Resources.back1;
            this.panel2.Controls.Add(this.chCofee);
            this.panel2.Controls.Add(this.chJuise);
            this.panel2.Controls.Add(this.chVodka);
            this.panel2.Controls.Add(this.chChay);
            this.panel2.Controls.Add(this.txtCofee);
            this.panel2.Controls.Add(this.txtJuice);
            this.panel2.Controls.Add(this.txtVodka);
            this.panel2.Controls.Add(this.txtChay);
            this.panel2.Location = new System.Drawing.Point(15, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 293);
            this.panel2.TabIndex = 1;
            // 
            // chCofee
            // 
            this.chCofee.AutoSize = true;
            this.chCofee.Location = new System.Drawing.Point(105, 42);
            this.chCofee.Name = "chCofee";
            this.chCofee.Size = new System.Drawing.Size(71, 21);
            this.chCofee.TabIndex = 11;
            this.chCofee.Text = "Coffee";
            this.chCofee.UseVisualStyleBackColor = true;
            this.chCofee.CheckedChanged += new System.EventHandler(this.ChCofee_CheckedChanged);
            // 
            // chJuise
            // 
            this.chJuise.AutoSize = true;
            this.chJuise.Location = new System.Drawing.Point(105, 81);
            this.chJuise.Name = "chJuise";
            this.chJuise.Size = new System.Drawing.Size(63, 21);
            this.chJuise.TabIndex = 10;
            this.chJuise.Text = "Juice";
            this.chJuise.UseVisualStyleBackColor = true;
            this.chJuise.CheckedChanged += new System.EventHandler(this.ChJuise_CheckedChanged);
            // 
            // chVodka
            // 
            this.chVodka.AutoSize = true;
            this.chVodka.Location = new System.Drawing.Point(105, 120);
            this.chVodka.Name = "chVodka";
            this.chVodka.Size = new System.Drawing.Size(54, 21);
            this.chVodka.TabIndex = 9;
            this.chVodka.Text = "Milk";
            this.chVodka.UseVisualStyleBackColor = true;
            this.chVodka.CheckedChanged += new System.EventHandler(this.ChVodka_CheckedChanged);
            // 
            // chChay
            // 
            this.chChay.AutoSize = true;
            this.chChay.Location = new System.Drawing.Point(75, 259);
            this.chChay.Name = "chChay";
            this.chChay.Size = new System.Drawing.Size(55, 21);
            this.chChay.TabIndex = 8;
            this.chChay.Text = "Tea";
            this.chChay.UseVisualStyleBackColor = true;
            this.chChay.Visible = false;
            this.chChay.CheckedChanged += new System.EventHandler(this.ChChay_CheckedChanged);
            // 
            // txtCofee
            // 
            this.txtCofee.Enabled = false;
            this.txtCofee.Location = new System.Drawing.Point(216, 42);
            this.txtCofee.Name = "txtCofee";
            this.txtCofee.Size = new System.Drawing.Size(100, 22);
            this.txtCofee.TabIndex = 3;
            // 
            // txtJuice
            // 
            this.txtJuice.Enabled = false;
            this.txtJuice.Location = new System.Drawing.Point(216, 81);
            this.txtJuice.Name = "txtJuice";
            this.txtJuice.Size = new System.Drawing.Size(100, 22);
            this.txtJuice.TabIndex = 2;
            // 
            // txtVodka
            // 
            this.txtVodka.Enabled = false;
            this.txtVodka.Location = new System.Drawing.Point(216, 118);
            this.txtVodka.Name = "txtVodka";
            this.txtVodka.Size = new System.Drawing.Size(100, 22);
            this.txtVodka.TabIndex = 1;
            // 
            // txtChay
            // 
            this.txtChay.Enabled = false;
            this.txtChay.Location = new System.Drawing.Point(186, 257);
            this.txtChay.Name = "txtChay";
            this.txtChay.Size = new System.Drawing.Size(100, 22);
            this.txtChay.TabIndex = 0;
            this.txtChay.Visible = false;
            this.txtChay.TextChanged += new System.EventHandler(this.TxtChay_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::StarMaks.Properties.Resources.back2;
            this.panel3.Controls.Add(this.ckPelmeny);
            this.panel3.Controls.Add(this.ckBorsh);
            this.panel3.Controls.Add(this.ckMeat);
            this.panel3.Controls.Add(this.chCake);
            this.panel3.Controls.Add(this.txtPelmeny);
            this.panel3.Controls.Add(this.txtMeat);
            this.panel3.Controls.Add(this.txtBorsh);
            this.panel3.Controls.Add(this.txtCake);
            this.panel3.Location = new System.Drawing.Point(371, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 293);
            this.panel3.TabIndex = 2;
            // 
            // ckPelmeny
            // 
            this.ckPelmeny.AutoSize = true;
            this.ckPelmeny.Location = new System.Drawing.Point(140, 84);
            this.ckPelmeny.Name = "ckPelmeny";
            this.ckPelmeny.Size = new System.Drawing.Size(63, 21);
            this.ckPelmeny.TabIndex = 7;
            this.ckPelmeny.Text = "Soup";
            this.ckPelmeny.UseVisualStyleBackColor = true;
            this.ckPelmeny.CheckedChanged += new System.EventHandler(this.CkPelmeny_CheckedChanged);
            // 
            // ckBorsh
            // 
            this.ckBorsh.AutoSize = true;
            this.ckBorsh.Location = new System.Drawing.Point(140, 250);
            this.ckBorsh.Name = "ckBorsh";
            this.ckBorsh.Size = new System.Drawing.Size(66, 21);
            this.ckBorsh.TabIndex = 6;
            this.ckBorsh.Text = "Salad";
            this.ckBorsh.UseVisualStyleBackColor = true;
            this.ckBorsh.Visible = false;
            this.ckBorsh.CheckedChanged += new System.EventHandler(this.CkBorsh_CheckedChanged);
            // 
            // ckMeat
            // 
            this.ckMeat.AutoSize = true;
            this.ckMeat.Location = new System.Drawing.Point(140, 121);
            this.ckMeat.Name = "ckMeat";
            this.ckMeat.Size = new System.Drawing.Size(66, 21);
            this.ckMeat.TabIndex = 5;
            this.ckMeat.Text = "Steak";
            this.ckMeat.UseVisualStyleBackColor = true;
            this.ckMeat.CheckedChanged += new System.EventHandler(this.CkMeat_CheckedChanged);
            // 
            // chCake
            // 
            this.chCake.AutoSize = true;
            this.chCake.Location = new System.Drawing.Point(140, 42);
            this.chCake.Name = "chCake";
            this.chCake.Size = new System.Drawing.Size(62, 21);
            this.chCake.TabIndex = 4;
            this.chCake.Text = "Cake";
            this.chCake.UseVisualStyleBackColor = true;
            this.chCake.CheckedChanged += new System.EventHandler(this.ChCake_CheckedChanged);
            // 
            // txtPelmeny
            // 
            this.txtPelmeny.Enabled = false;
            this.txtPelmeny.Location = new System.Drawing.Point(244, 82);
            this.txtPelmeny.Name = "txtPelmeny";
            this.txtPelmeny.Size = new System.Drawing.Size(100, 22);
            this.txtPelmeny.TabIndex = 3;
            // 
            // txtMeat
            // 
            this.txtMeat.Enabled = false;
            this.txtMeat.Location = new System.Drawing.Point(244, 121);
            this.txtMeat.Name = "txtMeat";
            this.txtMeat.Size = new System.Drawing.Size(100, 22);
            this.txtMeat.TabIndex = 2;
            // 
            // txtBorsh
            // 
            this.txtBorsh.Enabled = false;
            this.txtBorsh.Location = new System.Drawing.Point(244, 248);
            this.txtBorsh.Name = "txtBorsh";
            this.txtBorsh.Size = new System.Drawing.Size(100, 22);
            this.txtBorsh.TabIndex = 1;
            this.txtBorsh.Visible = false;
            // 
            // txtCake
            // 
            this.txtCake.Enabled = false;
            this.txtCake.Location = new System.Drawing.Point(244, 41);
            this.txtCake.Name = "txtCake";
            this.txtCake.Size = new System.Drawing.Size(100, 22);
            this.txtCake.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(654, 417);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 62);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(511, 417);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(99, 62);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(332, 437);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(129, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // txtTaxes
            // 
            this.txtTaxes.Location = new System.Drawing.Point(83, 430);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(121, 22);
            this.txtTaxes.TabIndex = 6;
            // 
            // txtCostOfDrink
            // 
            this.txtCostOfDrink.Location = new System.Drawing.Point(83, 390);
            this.txtCostOfDrink.Name = "txtCostOfDrink";
            this.txtCostOfDrink.Size = new System.Drawing.Size(114, 22);
            this.txtCostOfDrink.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNew,
            this.toolOpen,
            this.toolSave,
            this.tooCut,
            this.toolCopy,
            this.toolPaste});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(271, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNew
            // 
            this.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNew.Image = ((System.Drawing.Image)(resources.GetObject("toolNew.Image")));
            this.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNew.Name = "toolNew";
            this.toolNew.Size = new System.Drawing.Size(29, 24);
            this.toolNew.Text = "New";
            this.toolNew.Click += new System.EventHandler(this.ToolNew_Click);
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolOpen.Image")));
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(29, 24);
            this.toolOpen.Text = "Open";
            this.toolOpen.Click += new System.EventHandler(this.ToolOpen_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::StarMaks.Properties.Resources.save;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(29, 24);
            this.toolSave.Text = "Save";
            this.toolSave.Click += new System.EventHandler(this.ToolSave_Click);
            // 
            // tooCut
            // 
            this.tooCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooCut.Image = global::StarMaks.Properties.Resources.cut;
            this.tooCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooCut.Name = "tooCut";
            this.tooCut.Size = new System.Drawing.Size(29, 24);
            this.tooCut.Text = "Cut";
            this.tooCut.Click += new System.EventHandler(this.TooCut_Click);
            // 
            // toolCopy
            // 
            this.toolCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCopy.Image = global::StarMaks.Properties.Resources.copy;
            this.toolCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCopy.Name = "toolCopy";
            this.toolCopy.Size = new System.Drawing.Size(29, 24);
            this.toolCopy.Text = "Copy";
            this.toolCopy.Click += new System.EventHandler(this.ToolCopy_Click);
            // 
            // toolPaste
            // 
            this.toolPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPaste.Image = global::StarMaks.Properties.Resources.paste;
            this.toolPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPaste.Name = "toolPaste";
            this.toolPaste.Size = new System.Drawing.Size(29, 24);
            this.toolPaste.Text = "Paste";
            this.toolPaste.Click += new System.EventHandler(this.ToolPaste_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rReceip);
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Location = new System.Drawing.Point(800, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 334);
            this.panel4.TabIndex = 8;
            // 
            // rReceip
            // 
            this.rReceip.Location = new System.Drawing.Point(13, 38);
            this.rReceip.Name = "rReceip";
            this.rReceip.Size = new System.Drawing.Size(335, 426);
            this.rReceip.TabIndex = 1;
            this.rReceip.Text = "";
            this.rReceip.TextChanged += new System.EventHandler(this.RReceip_TextChanged);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(654, 485);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(94, 60);
            this.btnReceipt.TabIndex = 9;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(519, 485);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(91, 65);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Taxes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StarMaks.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1135, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtCostOfDrink);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chCofee;
        private System.Windows.Forms.CheckBox chJuise;
        private System.Windows.Forms.CheckBox chVodka;
        private System.Windows.Forms.CheckBox chChay;
        private System.Windows.Forms.TextBox txtCofee;
        private System.Windows.Forms.TextBox txtJuice;
        private System.Windows.Forms.TextBox txtVodka;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ckPelmeny;
        private System.Windows.Forms.CheckBox ckBorsh;
        private System.Windows.Forms.CheckBox ckMeat;
        private System.Windows.Forms.CheckBox chCake;
        private System.Windows.Forms.TextBox txtPelmeny;
        private System.Windows.Forms.TextBox txtMeat;
        private System.Windows.Forms.TextBox txtBorsh;
        private System.Windows.Forms.TextBox txtCake;
        private System.Windows.Forms.TextBox txtChay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTaxes;
        private System.Windows.Forms.TextBox txtCostOfDrink;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNew;
        private System.Windows.Forms.ToolStripButton toolOpen;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCopy;
        private System.Windows.Forms.ToolStripButton toolPaste;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rReceip;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.ToolStripButton tooCut;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

