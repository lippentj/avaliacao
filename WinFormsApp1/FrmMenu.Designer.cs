namespace WinFormsApp1
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btncadastro = new System.Windows.Forms.Button();
            this.btnlistar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblturma = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblmedia = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.txtturma = new System.Windows.Forms.TextBox();
            this.txtsegnota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncadastro
            // 
            this.btncadastro.BackColor = System.Drawing.Color.LawnGreen;
            this.btncadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncadastro.Location = new System.Drawing.Point(754, 109);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(249, 56);
            this.btncadastro.TabIndex = 6;
            this.btncadastro.Text = "CADASTRO";
            this.btncadastro.UseVisualStyleBackColor = false;
            this.btncadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlistar
            // 
            this.btnlistar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlistar.Location = new System.Drawing.Point(754, 265);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(249, 56);
            this.btnlistar.TabIndex = 7;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = false;
            this.btnlistar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(297, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "LISTAGEM E CADASTRO DE ALUNOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nota";
            // 
            // lblturma
            // 
            this.lblturma.AutoSize = true;
            this.lblturma.Location = new System.Drawing.Point(745, 384);
            this.lblturma.Name = "lblturma";
            this.lblturma.Size = new System.Drawing.Size(38, 15);
            this.lblturma.TabIndex = 14;
            this.lblturma.Text = "label6";
            this.lblturma.Click += new System.EventHandler(this.lblturma_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(745, 428);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 15);
            this.lblnome.TabIndex = 15;
            this.lblnome.Text = "label7";
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Location = new System.Drawing.Point(754, 493);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(38, 15);
            this.lblmedia.TabIndex = 16;
            this.lblmedia.Text = "label8";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(37, 178);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 23);
            this.txtnome.TabIndex = 17;
            this.txtnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(37, 228);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 23);
            this.txtnota.TabIndex = 18;
            // 
            // txtturma
            // 
            this.txtturma.Location = new System.Drawing.Point(37, 129);
            this.txtturma.Name = "txtturma";
            this.txtturma.Size = new System.Drawing.Size(100, 23);
            this.txtturma.TabIndex = 19;
            // 
            // txtsegnota
            // 
            this.txtsegnota.Location = new System.Drawing.Point(37, 283);
            this.txtsegnota.Name = "txtsegnota";
            this.txtsegnota.Size = new System.Drawing.Size(100, 23);
            this.txtsegnota.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Segunda Nota";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(754, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 56);
            this.button1.TabIndex = 22;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(745, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "media";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsegnota);
            this.Controls.Add(this.txtturma);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblturma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.btncadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btncadastro;
        private Button btnlistar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblturma;
        private Label lblnome;
        private Label lblmedia;
        private TextBox txtnome;
        private TextBox txtnota;
        private TextBox txtturma;
        private TextBox txtsegnota;
        private Label label5;
        private Button button1;
        private Label label6;
    }
}