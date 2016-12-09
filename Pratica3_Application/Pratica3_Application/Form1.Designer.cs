namespace Pratica3_Application
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criarFormaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quadradoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triânguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tetraedroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descreverFormasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskTxtBxRaio = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBxLado = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBxBase = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBxAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBxAlturaBase = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBxAlturaTetraedroRegular = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblForma = new System.Windows.Forms.Label();
            this.mskTxtBxCoordX = new System.Windows.Forms.MaskedTextBox();
            this.lblCoordX = new System.Windows.Forms.Label();
            this.mskTxtBxCoordY = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBxCoordZ = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.mskTxtBxNome = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarFormaToolStripMenuItem,
            this.descreverFormasToolStripMenuItem,
            this.verificarToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criarFormaToolStripMenuItem
            // 
            this.criarFormaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuloToolStripMenuItem,
            this.quadradoToolStripMenuItem});
            this.criarFormaToolStripMenuItem.Name = "criarFormaToolStripMenuItem";
            this.criarFormaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.criarFormaToolStripMenuItem.Text = "Nova Forma";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuloToolStripMenuItem1,
            this.quadradoToolStripMenuItem1,
            this.triânguloToolStripMenuItem});
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.circuloToolStripMenuItem.Text = "Bidimendional";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem1
            // 
            this.circuloToolStripMenuItem1.Name = "circuloToolStripMenuItem1";
            this.circuloToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.circuloToolStripMenuItem1.Text = "Circulo";
            this.circuloToolStripMenuItem1.Click += new System.EventHandler(this.circuloToolStripMenuItem1_Click);
            // 
            // quadradoToolStripMenuItem1
            // 
            this.quadradoToolStripMenuItem1.Name = "quadradoToolStripMenuItem1";
            this.quadradoToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.quadradoToolStripMenuItem1.Text = "Quadrado";
            this.quadradoToolStripMenuItem1.Click += new System.EventHandler(this.quadradoToolStripMenuItem1_Click);
            // 
            // triânguloToolStripMenuItem
            // 
            this.triânguloToolStripMenuItem.Name = "triânguloToolStripMenuItem";
            this.triânguloToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.triânguloToolStripMenuItem.Text = "Triangulo";
            this.triânguloToolStripMenuItem.Click += new System.EventHandler(this.triânguloToolStripMenuItem_Click);
            // 
            // quadradoToolStripMenuItem
            // 
            this.quadradoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esferaToolStripMenuItem,
            this.cuboToolStripMenuItem,
            this.tetraedroToolStripMenuItem});
            this.quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            this.quadradoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.quadradoToolStripMenuItem.Text = "Tridimensional";
            this.quadradoToolStripMenuItem.Click += new System.EventHandler(this.quadradoToolStripMenuItem_Click);
            // 
            // esferaToolStripMenuItem
            // 
            this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            this.esferaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.esferaToolStripMenuItem.Text = "Esfera";
            this.esferaToolStripMenuItem.Click += new System.EventHandler(this.esferaToolStripMenuItem_Click);
            // 
            // cuboToolStripMenuItem
            // 
            this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
            this.cuboToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cuboToolStripMenuItem.Text = "Cubo";
            this.cuboToolStripMenuItem.Click += new System.EventHandler(this.cuboToolStripMenuItem_Click);
            // 
            // tetraedroToolStripMenuItem
            // 
            this.tetraedroToolStripMenuItem.Name = "tetraedroToolStripMenuItem";
            this.tetraedroToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tetraedroToolStripMenuItem.Text = "Tetraedro";
            this.tetraedroToolStripMenuItem.Click += new System.EventHandler(this.tetraédroToolStripMenuItem_Click);
            // 
            // descreverFormasToolStripMenuItem
            // 
            this.descreverFormasToolStripMenuItem.Name = "descreverFormasToolStripMenuItem";
            this.descreverFormasToolStripMenuItem.Size = new System.Drawing.Size(251, 20);
            this.descreverFormasToolStripMenuItem.Text = "Percorrer vetor e exibir descrição das formas";
            this.descreverFormasToolStripMenuItem.Click += new System.EventHandler(this.descreverFormasToolStripMenuItem_Click);
            // 
            // verificarToolStripMenuItem
            // 
            this.verificarToolStripMenuItem.Name = "verificarToolStripMenuItem";
            this.verificarToolStripMenuItem.Size = new System.Drawing.Size(202, 20);
            this.verificarToolStripMenuItem.Text = "Verificar Intercepção circulo/esfera";
            this.verificarToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Altura do Tetraedro Regular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Altura da Base";
            // 
            // mskTxtBxRaio
            // 
            this.mskTxtBxRaio.Enabled = false;
            this.mskTxtBxRaio.Location = new System.Drawing.Point(239, 177);
            this.mskTxtBxRaio.Name = "mskTxtBxRaio";
            this.mskTxtBxRaio.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBxRaio.TabIndex = 9;
            // 
            // mskTxtBxLado
            // 
            this.mskTxtBxLado.Enabled = false;
            this.mskTxtBxLado.Location = new System.Drawing.Point(370, 177);
            this.mskTxtBxLado.Name = "mskTxtBxLado";
            this.mskTxtBxLado.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBxLado.TabIndex = 10;
            // 
            // mskTxtBxBase
            // 
            this.mskTxtBxBase.Enabled = false;
            this.mskTxtBxBase.Location = new System.Drawing.Point(501, 177);
            this.mskTxtBxBase.Name = "mskTxtBxBase";
            this.mskTxtBxBase.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBxBase.TabIndex = 11;
            // 
            // mskTxtBxAltura
            // 
            this.mskTxtBxAltura.Enabled = false;
            this.mskTxtBxAltura.Location = new System.Drawing.Point(45, 240);
            this.mskTxtBxAltura.Name = "mskTxtBxAltura";
            this.mskTxtBxAltura.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBxAltura.TabIndex = 12;
            // 
            // mskTxtBxAlturaBase
            // 
            this.mskTxtBxAlturaBase.Enabled = false;
            this.mskTxtBxAlturaBase.Location = new System.Drawing.Point(176, 240);
            this.mskTxtBxAlturaBase.Name = "mskTxtBxAlturaBase";
            this.mskTxtBxAlturaBase.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBxAlturaBase.TabIndex = 13;
            // 
            // mskTxtBxAlturaTetraedroRegular
            // 
            this.mskTxtBxAlturaTetraedroRegular.Enabled = false;
            this.mskTxtBxAlturaTetraedroRegular.Location = new System.Drawing.Point(307, 240);
            this.mskTxtBxAlturaTetraedroRegular.Name = "mskTxtBxAlturaTetraedroRegular";
            this.mskTxtBxAlturaTetraedroRegular.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBxAlturaTetraedroRegular.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(222, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 20);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Criando";
            this.lblTitulo.Visible = false;
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForma.Location = new System.Drawing.Point(289, 47);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(0, 20);
            this.lblForma.TabIndex = 16;
            // 
            // mskTxtBxCoordX
            // 
            this.mskTxtBxCoordX.Enabled = false;
            this.mskTxtBxCoordX.Location = new System.Drawing.Point(55, 29);
            this.mskTxtBxCoordX.Name = "mskTxtBxCoordX";
            this.mskTxtBxCoordX.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBxCoordX.TabIndex = 18;
            // 
            // lblCoordX
            // 
            this.lblCoordX.AutoSize = true;
            this.lblCoordX.Location = new System.Drawing.Point(18, 32);
            this.lblCoordX.Name = "lblCoordX";
            this.lblCoordX.Size = new System.Drawing.Size(14, 13);
            this.lblCoordX.TabIndex = 17;
            this.lblCoordX.Text = "X";
            // 
            // mskTxtBxCoordY
            // 
            this.mskTxtBxCoordY.Enabled = false;
            this.mskTxtBxCoordY.Location = new System.Drawing.Point(242, 29);
            this.mskTxtBxCoordY.Name = "mskTxtBxCoordY";
            this.mskTxtBxCoordY.Size = new System.Drawing.Size(99, 20);
            this.mskTxtBxCoordY.TabIndex = 20;
            // 
            // mskTxtBxCoordZ
            // 
            this.mskTxtBxCoordZ.Enabled = false;
            this.mskTxtBxCoordZ.Location = new System.Drawing.Point(420, 29);
            this.mskTxtBxCoordZ.Name = "mskTxtBxCoordZ";
            this.mskTxtBxCoordZ.Size = new System.Drawing.Size(101, 20);
            this.mskTxtBxCoordZ.TabIndex = 22;
            this.mskTxtBxCoordZ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox9_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Z";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblCoordX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.mskTxtBxCoordX);
            this.groupBox1.Controls.Add(this.mskTxtBxCoordZ);
            this.groupBox1.Controls.Add(this.mskTxtBxCoordY);
            this.groupBox1.Location = new System.Drawing.Point(21, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 58);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(467, 240);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 26;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // mskTxtBxNome
            // 
            this.mskTxtBxNome.Location = new System.Drawing.Point(45, 177);
            this.mskTxtBxNome.Name = "mskTxtBxNome";
            this.mskTxtBxNome.Size = new System.Drawing.Size(159, 20);
            this.mskTxtBxNome.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 277);
            this.Controls.Add(this.mskTxtBxNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mskTxtBxAlturaTetraedroRegular);
            this.Controls.Add(this.mskTxtBxAlturaBase);
            this.Controls.Add(this.mskTxtBxAltura);
            this.Controls.Add(this.mskTxtBxBase);
            this.Controls.Add(this.mskTxtBxLado);
            this.Controls.Add(this.mskTxtBxRaio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto 3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criarFormaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quadradoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem triânguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tetraedroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descreverFormasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTxtBxRaio;
        private System.Windows.Forms.MaskedTextBox mskTxtBxLado;
        private System.Windows.Forms.MaskedTextBox mskTxtBxBase;
        private System.Windows.Forms.MaskedTextBox mskTxtBxAltura;
        private System.Windows.Forms.MaskedTextBox mskTxtBxAlturaBase;
        private System.Windows.Forms.MaskedTextBox mskTxtBxAlturaTetraedroRegular;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.MaskedTextBox mskTxtBxCoordX;
        private System.Windows.Forms.Label lblCoordX;
        private System.Windows.Forms.MaskedTextBox mskTxtBxCoordY;
        private System.Windows.Forms.MaskedTextBox mskTxtBxCoordZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.MaskedTextBox mskTxtBxNome;
        private System.Windows.Forms.Label label10;
    }
}

