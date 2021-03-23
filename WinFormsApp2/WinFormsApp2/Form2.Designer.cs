
namespace WinFormsApp2
{
    partial class Form2
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
            this.b2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Tomato;
            this.b2.Location = new System.Drawing.Point(12, 12);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(98, 28);
            this.b2.TabIndex = 0;
            this.b2.Text = "VOLTAR";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.SeaShell;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "NOME\t\tPAÍS\t\tDESCRIÇÃO\t\tPREÇO",
            "",
            "",
            "- XFeijoada\t  BR\t\tHamburger de feijoada\t  R$ 15,00",
            "",
            "- XBacon\t\t  BR/EUA\t\tHamburger de bacon\t  R$20,00/ $3,63",
            "",
            "- XAcarajé\t   BR\t\tHamburger de acarajé\t  R$ 10,00",
            "",
            "- ZéPicanha\t   BR/ARG\t\tHamburger de picanha\t  R$10,99/ $182,72",
            "",
            "- XParrilla\t\t   ARG\t\tHamburger de parrilla\t  R$ 200,00",
            "",
            "- XCheddar\t   JP/EUA\t\tHamburger de chedar\t  $ 1,84/ ¥200",
            "",
            "- XSushi\t\t   JP\t\tHamburger de sushi\t\t   ¥600"});
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 379);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.b2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.ListBox listBox1;
    }
}