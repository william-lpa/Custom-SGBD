namespace SGBD_CP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEquipe = new System.Windows.Forms.Button();
            this.btCompilar = new System.Windows.Forms.Button();
            this.btGerarCodigo = new System.Windows.Forms.Button();
            this.btRecortar = new System.Windows.Forms.Button();
            this.btColar = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cbDataBases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SomeText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumbers_For_RichTextBox1 = new LineNumbers.LineNumbers_For_RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEquipe);
            this.panel1.Controls.Add(this.btCompilar);
            this.panel1.Controls.Add(this.btGerarCodigo);
            this.panel1.Controls.Add(this.btRecortar);
            this.panel1.Controls.Add(this.btColar);
            this.panel1.Controls.Add(this.btCopiar);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btAbrir);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 559);
            this.panel1.TabIndex = 0;
            // 
            // btEquipe
            // 
            this.btEquipe.Image = ((System.Drawing.Image)(resources.GetObject("btEquipe.Image")));
            this.btEquipe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEquipe.Location = new System.Drawing.Point(-1, 495);
            this.btEquipe.Name = "btEquipe";
            this.btEquipe.Size = new System.Drawing.Size(144, 69);
            this.btEquipe.TabIndex = 2;
            this.btEquipe.Text = "equipe [F1]";
            this.btEquipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEquipe.UseVisualStyleBackColor = true;
            this.btEquipe.Click += new System.EventHandler(this.btEquipe_Click);
            // 
            // btCompilar
            // 
            this.btCompilar.Image = ((System.Drawing.Image)(resources.GetObject("btCompilar.Image")));
            this.btCompilar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCompilar.Location = new System.Drawing.Point(-1, 371);
            this.btCompilar.Name = "btCompilar";
            this.btCompilar.Size = new System.Drawing.Size(144, 64);
            this.btCompilar.TabIndex = 2;
            this.btCompilar.Text = "compilar [F8]";
            this.btCompilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCompilar.UseVisualStyleBackColor = true;
            this.btCompilar.Click += new System.EventHandler(this.btCompilar_Click);
            // 
            // btGerarCodigo
            // 
            this.btGerarCodigo.Image = ((System.Drawing.Image)(resources.GetObject("btGerarCodigo.Image")));
            this.btGerarCodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGerarCodigo.Location = new System.Drawing.Point(-1, 433);
            this.btGerarCodigo.Name = "btGerarCodigo";
            this.btGerarCodigo.Size = new System.Drawing.Size(144, 64);
            this.btGerarCodigo.TabIndex = 1;
            this.btGerarCodigo.Text = "gerar código [F9]";
            this.btGerarCodigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGerarCodigo.UseVisualStyleBackColor = true;
            this.btGerarCodigo.Click += new System.EventHandler(this.btGerarCodigo_Click);
            // 
            // btRecortar
            // 
            this.btRecortar.Image = ((System.Drawing.Image)(resources.GetObject("btRecortar.Image")));
            this.btRecortar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRecortar.Location = new System.Drawing.Point(0, 308);
            this.btRecortar.Name = "btRecortar";
            this.btRecortar.Size = new System.Drawing.Size(144, 64);
            this.btRecortar.TabIndex = 1;
            this.btRecortar.Text = "recortar [ctrl-v]";
            this.btRecortar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRecortar.UseVisualStyleBackColor = true;
            this.btRecortar.Click += new System.EventHandler(this.btRecortar_Click);
            // 
            // btColar
            // 
            this.btColar.Image = ((System.Drawing.Image)(resources.GetObject("btColar.Image")));
            this.btColar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btColar.Location = new System.Drawing.Point(0, 245);
            this.btColar.Name = "btColar";
            this.btColar.Size = new System.Drawing.Size(144, 64);
            this.btColar.TabIndex = 1;
            this.btColar.Text = "colar [ctrl-v]";
            this.btColar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btColar.UseVisualStyleBackColor = true;
            this.btColar.Click += new System.EventHandler(this.btColar_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btCopiar.Image")));
            this.btCopiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCopiar.Location = new System.Drawing.Point(0, 182);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(144, 64);
            this.btCopiar.TabIndex = 1;
            this.btCopiar.Text = "copiar [ctrl-c]";
            this.btCopiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvar.Location = new System.Drawing.Point(-1, 123);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(144, 64);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "salvar [ctrl-s]";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btAbrir.Image")));
            this.btAbrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAbrir.Location = new System.Drawing.Point(-1, 63);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(144, 64);
            this.btAbrir.TabIndex = 1;
            this.btAbrir.Text = "abrir [ctrl-a]";
            this.btAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovo.CausesValidation = false;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNovo.Location = new System.Drawing.Point(-1, 0);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(144, 64);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo [ctrl-n]";
            this.btNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(184, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(707, 515);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBox2.Location = new System.Drawing.Point(153, 563);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox2.Size = new System.Drawing.Size(1092, 110);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.WordWrap = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 961);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1245, 55);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(920, 42);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(260, 515);
            this.treeView1.TabIndex = 12;
            // 
            // cbDataBases
            // 
            this.cbDataBases.FormattingEnabled = true;
            this.cbDataBases.Location = new System.Drawing.Point(266, 12);
            this.cbDataBases.Name = "cbDataBases";
            this.cbDataBases.Size = new System.Drawing.Size(625, 24);
            this.cbDataBases.TabIndex = 13;
            this.cbDataBases.SelectedIndexChanged += new System.EventHandler(this.cbDataBases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Base Ativa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SomeText});
            this.dataGridView1.Location = new System.Drawing.Point(12, 699);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 243);
            this.dataGridView1.TabIndex = 15;
            // 
            // SomeText
            // 
            this.SomeText.HeaderText = "Some Text";
            this.SomeText.Name = "SomeText";
            // 
            // lineNumbers_For_RichTextBox1
            // 
            this.lineNumbers_For_RichTextBox1._SeeThroughMode_ = false;
            this.lineNumbers_For_RichTextBox1.AutoSizing = false;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers_For_RichTextBox1.BorderLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.BorderLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_RichTextBox1.GridLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.GridLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.lineNumbers_For_RichTextBox1.LineNrs_AntiAlias = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_AsHexadecimal = false;
            this.lineNumbers_For_RichTextBox1.LineNrs_ClippedByItemRectangle = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_LeadingZeroes = false;
            this.lineNumbers_For_RichTextBox1.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.lineNumbers_For_RichTextBox1.Location = new System.Drawing.Point(152, 42);
            this.lineNumbers_For_RichTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers_For_RichTextBox1.MarginLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.lineNumbers_For_RichTextBox1.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers_For_RichTextBox1.MarginLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.Name = "lineNumbers_For_RichTextBox1";
            this.lineNumbers_For_RichTextBox1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lineNumbers_For_RichTextBox1.ParentRichTextBox = this.richTextBox1;
            this.lineNumbers_For_RichTextBox1.Show_BackgroundGradient = true;
            this.lineNumbers_For_RichTextBox1.Show_BorderLines = true;
            this.lineNumbers_For_RichTextBox1.Show_GridLines = true;
            this.lineNumbers_For_RichTextBox1.Show_LineNrs = true;
            this.lineNumbers_For_RichTextBox1.Show_MarginLines = true;
            this.lineNumbers_For_RichTextBox1.Size = new System.Drawing.Size(31, 515);
            this.lineNumbers_For_RichTextBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 986);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDataBases);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lineNumbers_For_RichTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEquipe;
        private System.Windows.Forms.Button btCompilar;
        private System.Windows.Forms.Button btGerarCodigo;
        private System.Windows.Forms.Button btRecortar;
        private System.Windows.Forms.Button btColar;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private LineNumbers.LineNumbers_For_RichTextBox lineNumbers_For_RichTextBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox cbDataBases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SomeText;
    }
}

