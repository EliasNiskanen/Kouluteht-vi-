﻿
namespace WindowsFormsApp1
{
    partial class LaskinLomake
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
            this.Laskin = new System.Windows.Forms.Panel();
            this.btnLaske = new System.Windows.Forms.Button();
            this.tbTulos = new System.Windows.Forms.TextBox();
            this.tbLuku2 = new System.Windows.Forms.TextBox();
            this.tbluku1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudIka = new System.Windows.Forms.NumericUpDown();
            this.cbElakkeella = new System.Windows.Forms.CheckBox();
            this.rbLeski = new System.Windows.Forms.RadioButton();
            this.rdNaimaton = new System.Windows.Forms.RadioButton();
            this.rbNaimisissa = new System.Windows.Forms.RadioButton();
            this.rbEronnut = new System.Windows.Forms.RadioButton();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lbHenkilot = new System.Windows.Forms.ListBox();
            this.btnNaytalista = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.Laskin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIka)).BeginInit();
            this.SuspendLayout();
            // 
            // Laskin
            // 
            this.Laskin.Controls.Add(this.btnLaske);
            this.Laskin.Controls.Add(this.tbTulos);
            this.Laskin.Controls.Add(this.tbLuku2);
            this.Laskin.Controls.Add(this.tbluku1);
            this.Laskin.Controls.Add(this.label3);
            this.Laskin.Controls.Add(this.label2);
            this.Laskin.Controls.Add(this.label1);
            this.Laskin.Location = new System.Drawing.Point(12, 12);
            this.Laskin.Name = "Laskin";
            this.Laskin.Size = new System.Drawing.Size(467, 360);
            this.Laskin.TabIndex = 0;
            this.Laskin.Paint += new System.Windows.Forms.PaintEventHandler(this.Laskin_Paint);
            // 
            // btnLaske
            // 
            this.btnLaske.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnLaske.Location = new System.Drawing.Point(175, 191);
            this.btnLaske.Name = "btnLaske";
            this.btnLaske.Size = new System.Drawing.Size(223, 49);
            this.btnLaske.TabIndex = 3;
            this.btnLaske.Text = "LASKE";
            this.btnLaske.UseVisualStyleBackColor = true;
            this.btnLaske.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbTulos
            // 
            this.tbTulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbTulos.Location = new System.Drawing.Point(175, 272);
            this.tbTulos.Name = "tbTulos";
            this.tbTulos.ReadOnly = true;
            this.tbTulos.Size = new System.Drawing.Size(223, 26);
            this.tbTulos.TabIndex = 4;
            this.tbTulos.TabStop = false;
            this.tbTulos.Text = "0";
            // 
            // tbLuku2
            // 
            this.tbLuku2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbLuku2.Location = new System.Drawing.Point(175, 132);
            this.tbLuku2.Name = "tbLuku2";
            this.tbLuku2.Size = new System.Drawing.Size(223, 26);
            this.tbLuku2.TabIndex = 2;
            this.tbLuku2.Text = "4";
            // 
            // tbluku1
            // 
            this.tbluku1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbluku1.Location = new System.Drawing.Point(175, 43);
            this.tbluku1.Name = "tbluku1";
            this.tbluku1.Size = new System.Drawing.Size(223, 26);
            this.tbluku1.TabIndex = 1;
            this.tbluku1.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Luku 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tulos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luku 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNaytalista);
            this.panel1.Controls.Add(this.lbHenkilot);
            this.panel1.Controls.Add(this.btnLisaa);
            this.panel1.Controls.Add(this.rbEronnut);
            this.panel1.Controls.Add(this.rbNaimisissa);
            this.panel1.Controls.Add(this.rdNaimaton);
            this.panel1.Controls.Add(this.rbLeski);
            this.panel1.Controls.Add(this.cbElakkeella);
            this.panel1.Controls.Add(this.nudIka);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbNimi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 438);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(43, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nimi";
            // 
            // tbNimi
            // 
            this.tbNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.tbNimi.Location = new System.Drawing.Point(117, 52);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(175, 26);
            this.tbNimi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(42, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ikä";
            // 
            // nudIka
            // 
            this.nudIka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nudIka.Location = new System.Drawing.Point(117, 114);
            this.nudIka.Name = "nudIka";
            this.nudIka.Size = new System.Drawing.Size(120, 26);
            this.nudIka.TabIndex = 6;
            this.nudIka.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudIka.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbElakkeella
            // 
            this.cbElakkeella.AutoSize = true;
            this.cbElakkeella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbElakkeella.Location = new System.Drawing.Point(117, 168);
            this.cbElakkeella.Name = "cbElakkeella";
            this.cbElakkeella.Size = new System.Drawing.Size(103, 24);
            this.cbElakkeella.TabIndex = 3;
            this.cbElakkeella.Text = "Eläkkeellä";
            this.cbElakkeella.UseVisualStyleBackColor = true;
            // 
            // rbLeski
            // 
            this.rbLeski.AutoSize = true;
            this.rbLeski.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbLeski.Location = new System.Drawing.Point(114, 242);
            this.rbLeski.Name = "rbLeski";
            this.rbLeski.Size = new System.Drawing.Size(67, 24);
            this.rbLeski.TabIndex = 7;
            this.rbLeski.Text = "Leski";
            this.rbLeski.UseVisualStyleBackColor = true;
            // 
            // rdNaimaton
            // 
            this.rdNaimaton.AutoSize = true;
            this.rdNaimaton.Checked = true;
            this.rdNaimaton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rdNaimaton.Location = new System.Drawing.Point(114, 205);
            this.rdNaimaton.Name = "rdNaimaton";
            this.rdNaimaton.Size = new System.Drawing.Size(98, 24);
            this.rdNaimaton.TabIndex = 8;
            this.rdNaimaton.TabStop = true;
            this.rdNaimaton.Text = "Naimaton";
            this.rdNaimaton.UseVisualStyleBackColor = true;
            // 
            // rbNaimisissa
            // 
            this.rbNaimisissa.AutoSize = true;
            this.rbNaimisissa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbNaimisissa.Location = new System.Drawing.Point(236, 205);
            this.rbNaimisissa.Name = "rbNaimisissa";
            this.rbNaimisissa.Size = new System.Drawing.Size(110, 24);
            this.rbNaimisissa.TabIndex = 9;
            this.rbNaimisissa.Text = "Naimisissa";
            this.rbNaimisissa.UseVisualStyleBackColor = true;
            // 
            // rbEronnut
            // 
            this.rbEronnut.AutoSize = true;
            this.rbEronnut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbEronnut.Location = new System.Drawing.Point(236, 242);
            this.rbEronnut.Name = "rbEronnut";
            this.rbEronnut.Size = new System.Drawing.Size(85, 24);
            this.rbEronnut.TabIndex = 10;
            this.rbEronnut.Text = "Eronnut";
            this.rbEronnut.UseVisualStyleBackColor = true;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLisaa.Location = new System.Drawing.Point(172, 288);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(83, 32);
            this.btnLisaa.TabIndex = 4;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lbHenkilot
            // 
            this.lbHenkilot.FormattingEnabled = true;
            this.lbHenkilot.Location = new System.Drawing.Point(92, 326);
            this.lbHenkilot.Name = "lbHenkilot";
            this.lbHenkilot.Size = new System.Drawing.Size(242, 82);
            this.lbHenkilot.TabIndex = 4;
            // 
            // btnNaytalista
            // 
            this.btnNaytalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnNaytalista.Location = new System.Drawing.Point(323, 288);
            this.btnNaytalista.Name = "btnNaytalista";
            this.btnNaytalista.Size = new System.Drawing.Size(75, 32);
            this.btnNaytalista.TabIndex = 11;
            this.btnNaytalista.Text = ">>";
            this.btnNaytalista.UseVisualStyleBackColor = true;
            this.btnNaytalista.Click += new System.EventHandler(this.btnNaytalista_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Syötä kokonaisluku";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipTitle = "Syötä Kokonaisluku";
            // 
            // LaskinLomake
            // 
            this.ClientSize = new System.Drawing.Size(1842, 954);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Laskin);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "LaskinLomake";
            this.Text = "Eläkkeellä?";
            this.Laskin.ResumeLayout(false);
            this.Laskin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Lomake;
        private System.Windows.Forms.Panel Laskin;
        private System.Windows.Forms.TextBox tbTulos;
        private System.Windows.Forms.TextBox tbLuku2;
        private System.Windows.Forms.TextBox tbluku1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaske;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudIka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbElakkeella;
        private System.Windows.Forms.ListBox lbHenkilot;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.RadioButton rbEronnut;
        private System.Windows.Forms.RadioButton rbNaimisissa;
        private System.Windows.Forms.RadioButton rdNaimaton;
        private System.Windows.Forms.RadioButton rbLeski;
        private System.Windows.Forms.Button btnNaytalista;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}

