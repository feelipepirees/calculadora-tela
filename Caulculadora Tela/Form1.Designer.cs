namespace Caulculadora_Tela
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroUm = new System.Windows.Forms.TextBox();
            this.numeroDois = new System.Windows.Forms.TextBox();
            this.somar = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.mutiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero 2:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numeroUm
            // 
            this.numeroUm.Location = new System.Drawing.Point(147, 64);
            this.numeroUm.Name = "numeroUm";
            this.numeroUm.Size = new System.Drawing.Size(116, 32);
            this.numeroUm.TabIndex = 3;
            this.numeroUm.TextChanged += new System.EventHandler(this.numeroUm_TextChanged);
            // 
            // numeroDois
            // 
            this.numeroDois.Location = new System.Drawing.Point(147, 102);
            this.numeroDois.Name = "numeroDois";
            this.numeroDois.Size = new System.Drawing.Size(116, 32);
            this.numeroDois.TabIndex = 4;
            this.numeroDois.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // somar
            // 
            this.somar.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somar.Location = new System.Drawing.Point(44, 158);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(85, 50);
            this.somar.TabIndex = 5;
            this.somar.Text = "Somar";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtrair
            // 
            this.subtrair.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrair.Location = new System.Drawing.Point(135, 158);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(71, 50);
            this.subtrair.TabIndex = 6;
            this.subtrair.Text = "Subtrair";
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.Click += new System.EventHandler(this.button2_Click);
            // 
            // mutiplicar
            // 
            this.mutiplicar.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutiplicar.Location = new System.Drawing.Point(44, 214);
            this.mutiplicar.Name = "mutiplicar";
            this.mutiplicar.Size = new System.Drawing.Size(85, 50);
            this.mutiplicar.TabIndex = 7;
            this.mutiplicar.Text = "Mutiplicar";
            this.mutiplicar.UseVisualStyleBackColor = true;
            this.mutiplicar.Click += new System.EventHandler(this.button3_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(135, 214);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(71, 50);
            this.dividir.TabIndex = 8;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.button4_Click);
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(212, 158);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(61, 106);
            this.limpar.TabIndex = 9;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.button5_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(44, 271);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(229, 32);
            this.resultado.TabIndex = 10;
            this.resultado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Software destinado a realiuzar calculos basicos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(301, 314);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.mutiplicar);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.numeroDois);
            this.Controls.Add(this.numeroUm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pagina Principal ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroUm;
        private System.Windows.Forms.TextBox numeroDois;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button mutiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.TextBox resultado;
    }
}

