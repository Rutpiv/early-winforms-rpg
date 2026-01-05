
namespace Jogo
{
    partial class FrmMenu
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
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.BtnLoadGame = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogo de RPG Windows Forms";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Location = new System.Drawing.Point(19, 339);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(129, 42);
            this.BtnNewGame.TabIndex = 2;
            this.BtnNewGame.Text = "New Game";
            this.BtnNewGame.UseVisualStyleBackColor = true;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // BtnLoadGame
            // 
            this.BtnLoadGame.Location = new System.Drawing.Point(19, 387);
            this.BtnLoadGame.Name = "BtnLoadGame";
            this.BtnLoadGame.Size = new System.Drawing.Size(129, 42);
            this.BtnLoadGame.TabIndex = 3;
            this.BtnLoadGame.Text = "Load Game";
            this.BtnLoadGame.UseVisualStyleBackColor = true;
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(19, 435);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(129, 42);
            this.BtnQuit.TabIndex = 4;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnLoadGame);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Button BtnLoadGame;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

