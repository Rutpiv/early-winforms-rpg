
namespace Jogo
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.txtLogJogo = new System.Windows.Forms.TextBox();
            this.tLCaixaAções = new System.Windows.Forms.TableLayoutPanel();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.btnMultiataque = new System.Windows.Forms.Button();
            this.btnCura = new System.Windows.Forms.Button();
            this.btnDefesa = new System.Windows.Forms.Button();
            this.pbInimigo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tLCaixaAções.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogJogo
            // 
            this.txtLogJogo.Location = new System.Drawing.Point(12, 311);
            this.txtLogJogo.Multiline = true;
            this.txtLogJogo.Name = "txtLogJogo";
            this.txtLogJogo.ReadOnly = true;
            this.txtLogJogo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogJogo.Size = new System.Drawing.Size(333, 238);
            this.txtLogJogo.TabIndex = 2;
            this.txtLogJogo.Visible = false;
            // 
            // tLCaixaAções
            // 
            this.tLCaixaAções.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLCaixaAções.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tLCaixaAções.ColumnCount = 2;
            this.tLCaixaAções.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.81685F));
            this.tLCaixaAções.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.18315F));
            this.tLCaixaAções.Controls.Add(this.btnAtaque, 0, 0);
            this.tLCaixaAções.Controls.Add(this.btnMultiataque, 1, 0);
            this.tLCaixaAções.Controls.Add(this.btnCura, 0, 1);
            this.tLCaixaAções.Controls.Add(this.btnDefesa, 1, 1);
            this.tLCaixaAções.Location = new System.Drawing.Point(351, 311);
            this.tLCaixaAções.Name = "tLCaixaAções";
            this.tLCaixaAções.RowCount = 2;
            this.tLCaixaAções.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLCaixaAções.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLCaixaAções.Size = new System.Drawing.Size(521, 238);
            this.tLCaixaAções.TabIndex = 4;
            this.tLCaixaAções.Visible = false;
            // 
            // btnAtaque
            // 
            this.btnAtaque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAtaque.Location = new System.Drawing.Point(3, 3);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(253, 113);
            this.btnAtaque.TabIndex = 0;
            this.btnAtaque.Text = "Ataque";
            this.btnAtaque.UseVisualStyleBackColor = true;
            // 
            // btnMultiataque
            // 
            this.btnMultiataque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiataque.Location = new System.Drawing.Point(262, 3);
            this.btnMultiataque.Name = "btnMultiataque";
            this.btnMultiataque.Size = new System.Drawing.Size(256, 113);
            this.btnMultiataque.TabIndex = 1;
            this.btnMultiataque.Text = "Multiataque";
            this.btnMultiataque.UseVisualStyleBackColor = true;
            // 
            // btnCura
            // 
            this.btnCura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCura.Location = new System.Drawing.Point(3, 122);
            this.btnCura.Name = "btnCura";
            this.btnCura.Size = new System.Drawing.Size(253, 113);
            this.btnCura.TabIndex = 2;
            this.btnCura.Text = "Curar";
            this.btnCura.UseVisualStyleBackColor = true;
            // 
            // btnDefesa
            // 
            this.btnDefesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDefesa.Location = new System.Drawing.Point(262, 122);
            this.btnDefesa.Name = "btnDefesa";
            this.btnDefesa.Size = new System.Drawing.Size(256, 113);
            this.btnDefesa.TabIndex = 3;
            this.btnDefesa.Text = "Defender";
            this.btnDefesa.UseVisualStyleBackColor = true;
            // 
            // pbInimigo
            // 
            this.pbInimigo.Image = ((System.Drawing.Image)(resources.GetObject("pbInimigo.Image")));
            this.pbInimigo.Location = new System.Drawing.Point(93, 58);
            this.pbInimigo.Name = "pbInimigo";
            this.pbInimigo.Size = new System.Drawing.Size(200, 200);
            this.pbInimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInimigo.TabIndex = 6;
            this.pbInimigo.TabStop = false;
            this.pbInimigo.Visible = false;
            this.pbInimigo.Click += new System.EventHandler(this.pbInimigo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 293);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(591, 58);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(200, 200);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 8;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(591, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(131, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(728, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 23);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(162, 264);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(131, 23);
            this.progressBar2.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(93, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 23);
            this.panel2.TabIndex = 11;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbInimigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tLCaixaAções);
            this.Controls.Add(this.txtLogJogo);
            this.Name = "FrmGame";
            this.Text = "FrmGame";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.tLCaixaAções.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogJogo;
        private System.Windows.Forms.TableLayoutPanel tLCaixaAções;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.Button btnMultiataque;
        private System.Windows.Forms.Button btnCura;
        private System.Windows.Forms.Button btnDefesa;
        private System.Windows.Forms.PictureBox pbInimigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Panel panel2;
    }
}