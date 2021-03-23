
namespace WinFormsApp2
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
            this.b1 = new System.Windows.Forms.Button();
            this.comoBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JAPAO = new System.Windows.Forms.ListBox();
            this.BRASIL = new System.Windows.Forms.ListBox();
            this.ARGENTINA = new System.Windows.Forms.ListBox();
            this.ESTADOSUNIDOS = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Tomato;
            this.b1.Location = new System.Drawing.Point(489, 136);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(149, 31);
            this.b1.TabIndex = 0;
            this.b1.Text = "TODOS CARDÁPIOS";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // comoBox1
            // 
            this.comoBox1.BackColor = System.Drawing.Color.SeaShell;
            this.comoBox1.FormattingEnabled = true;
            this.comoBox1.Items.AddRange(new object[] {
            "",
            "BRASIL",
            "ARGENTINA ",
            "ESTADOS UNIDOS",
            "JAPÃO"});
            this.comoBox1.Location = new System.Drawing.Point(183, 66);
            this.comoBox1.Name = "comoBox1";
            this.comoBox1.Size = new System.Drawing.Size(300, 23);
            this.comoBox1.TabIndex = 2;
            this.comoBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECIONE UM PAÍS:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.JAPAO);
            this.groupBox1.Controls.Add(this.BRASIL);
            this.groupBox1.Controls.Add(this.ARGENTINA);
            this.groupBox1.Controls.Add(this.ESTADOSUNIDOS);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CARDÁPIO";
            // 
            // JAPAO
            // 
            this.JAPAO.BackColor = System.Drawing.Color.Bisque;
            this.JAPAO.FormattingEnabled = true;
            this.JAPAO.ItemHeight = 15;
            this.JAPAO.Items.AddRange(new object[] {
            "NOME\t\t\t|DESCRIÇÃO\t\t\t|PREÇO",
            "",
            "Xsushi\t\t  \t  Hamburger de Sushi\t\t  ¥ 600",
            "Xcheddar\t\t\t  Hamburger de Cheddar\t\t  ¥ 200"});
            this.JAPAO.Location = new System.Drawing.Point(6, 22);
            this.JAPAO.Name = "JAPAO";
            this.JAPAO.Size = new System.Drawing.Size(459, 124);
            this.JAPAO.TabIndex = 6;
            this.JAPAO.Visible = false;
            this.JAPAO.SelectedIndexChanged += new System.EventHandler(this.JAPAO_SelectedIndexChanged);
            // 
            // BRASIL
            // 
            this.BRASIL.BackColor = System.Drawing.Color.Bisque;
            this.BRASIL.FormattingEnabled = true;
            this.BRASIL.ItemHeight = 15;
            this.BRASIL.Items.AddRange(new object[] {
            "NOME\t\t\t|DESCRIÇÃO\t\t\t|PREÇO",
            "",
            "Xfeijoada\t\t\t  Hamburger de Feijoada\t\t  R$ 15,00",
            "Xbacon\t\t\t  Hamburger de Bacon\t\t  R$ 20,00",
            "Xacarajé\t\t\t  Hamburger de Acarajé\t\t  R$ 10,00",
            "ZéPicanha\t\t  Hamburger de Picanha\t\t  R$ 10,99"});
            this.BRASIL.Location = new System.Drawing.Point(6, 22);
            this.BRASIL.Name = "BRASIL";
            this.BRASIL.Size = new System.Drawing.Size(459, 124);
            this.BRASIL.TabIndex = 3;
            this.BRASIL.Visible = false;
            // 
            // ARGENTINA
            // 
            this.ARGENTINA.BackColor = System.Drawing.Color.Bisque;
            this.ARGENTINA.FormattingEnabled = true;
            this.ARGENTINA.ItemHeight = 15;
            this.ARGENTINA.Items.AddRange(new object[] {
            "NOME\t\t\t|DESCRIÇÃO\t\t\t|PREÇO",
            "",
            "Xnachos\t\t\t  Hamburger de Nachos\t\t  $ 200,00",
            "Xparrilla\t\t\t  Hamburger de parrila\t\t  $ 182,72"});
            this.ARGENTINA.Location = new System.Drawing.Point(6, 22);
            this.ARGENTINA.Name = "ARGENTINA";
            this.ARGENTINA.Size = new System.Drawing.Size(459, 124);
            this.ARGENTINA.TabIndex = 4;
            this.ARGENTINA.Visible = false;
            // 
            // ESTADOSUNIDOS
            // 
            this.ESTADOSUNIDOS.BackColor = System.Drawing.Color.Bisque;
            this.ESTADOSUNIDOS.FormattingEnabled = true;
            this.ESTADOSUNIDOS.ItemHeight = 15;
            this.ESTADOSUNIDOS.Items.AddRange(new object[] {
            "NOME\t\t\t|DESCRIÇÃO\t\t\t|PREÇO",
            "",
            "Xcheddar\t\t\t  Hamburger de Cheddar\t\t  $ 1,84",
            "Xbacon\t\t\t  Hamburger de Bacon\t\t  $ 3,63"});
            this.ESTADOSUNIDOS.Location = new System.Drawing.Point(6, 22);
            this.ESTADOSUNIDOS.Name = "ESTADOSUNIDOS";
            this.ESTADOSUNIDOS.Size = new System.Drawing.Size(459, 124);
            this.ESTADOSUNIDOS.TabIndex = 5;
            this.ESTADOSUNIDOS.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(222, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "ZÉ LANCHE\'S";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Tomato;
            this.b3.Location = new System.Drawing.Point(489, 173);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(149, 31);
            this.b3.TabIndex = 6;
            this.b3.Text = "COMPRAR";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Tomato;
            this.b2.Location = new System.Drawing.Point(518, 325);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(149, 31);
            this.b2.TabIndex = 7;
            this.b2.Text = "SAIR";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(679, 368);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comoBox1);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ComboBox comoBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ESTADOSUNIDOS;
        private System.Windows.Forms.ListBox BRASIL;
        private System.Windows.Forms.ListBox JAPAO;
        private System.Windows.Forms.ListBox ARGENTINA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
    }
}

