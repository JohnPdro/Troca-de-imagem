
namespace Troca_de_imagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctrBoxImagem = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.pctrBoxImagem2 = new System.Windows.Forms.PictureBox();
            this.btnMostrar2 = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnOcultar2 = new System.Windows.Forms.Button();
            this.btnOcultarTodos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxImagem2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBoxImagem
            // 
            this.pctrBoxImagem.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxImagem.Image")));
            this.pctrBoxImagem.Location = new System.Drawing.Point(23, 76);
            this.pctrBoxImagem.Name = "pctrBoxImagem";
            this.pctrBoxImagem.Size = new System.Drawing.Size(276, 406);
            this.pctrBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxImagem.TabIndex = 0;
            this.pctrBoxImagem.TabStop = false;
            this.pctrBoxImagem.Visible = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.White;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(40, 488);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(108, 57);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Imagem";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // pctrBoxImagem2
            // 
            this.pctrBoxImagem2.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxImagem2.Image")));
            this.pctrBoxImagem2.Location = new System.Drawing.Point(348, 76);
            this.pctrBoxImagem2.Name = "pctrBoxImagem2";
            this.pctrBoxImagem2.Size = new System.Drawing.Size(276, 406);
            this.pctrBoxImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxImagem2.TabIndex = 3;
            this.pctrBoxImagem2.TabStop = false;
            this.pctrBoxImagem2.Visible = false;
            this.pctrBoxImagem2.Click += new System.EventHandler(this.pctrBoxImagem2_Click);
            // 
            // btnMostrar2
            // 
            this.btnMostrar2.BackColor = System.Drawing.Color.White;
            this.btnMostrar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar2.FlatAppearance.BorderSize = 0;
            this.btnMostrar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnMostrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar2.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar2.Location = new System.Drawing.Point(366, 488);
            this.btnMostrar2.Name = "btnMostrar2";
            this.btnMostrar2.Size = new System.Drawing.Size(108, 57);
            this.btnMostrar2.TabIndex = 4;
            this.btnMostrar2.Text = "Mostrar Imagem";
            this.btnMostrar2.UseVisualStyleBackColor = false;
            this.btnMostrar2.Click += new System.EventHandler(this.btnMostrar2_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.BackColor = System.Drawing.Color.White;
            this.btnOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar.FlatAppearance.BorderSize = 0;
            this.btnOcultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultar.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultar.Location = new System.Drawing.Point(173, 488);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(108, 57);
            this.btnOcultar.TabIndex = 2;
            this.btnOcultar.Text = "Ocultar Imagem";
            this.btnOcultar.UseVisualStyleBackColor = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnOcultar2
            // 
            this.btnOcultar2.BackColor = System.Drawing.Color.White;
            this.btnOcultar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar2.FlatAppearance.BorderSize = 0;
            this.btnOcultar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnOcultar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultar2.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultar2.Location = new System.Drawing.Point(504, 488);
            this.btnOcultar2.Name = "btnOcultar2";
            this.btnOcultar2.Size = new System.Drawing.Size(108, 57);
            this.btnOcultar2.TabIndex = 5;
            this.btnOcultar2.Text = "Ocultar Imagem";
            this.btnOcultar2.UseVisualStyleBackColor = false;
            this.btnOcultar2.Click += new System.EventHandler(this.btnOcultar2_Click);
            // 
            // btnOcultarTodos
            // 
            this.btnOcultarTodos.BackColor = System.Drawing.Color.White;
            this.btnOcultarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarTodos.FlatAppearance.BorderSize = 0;
            this.btnOcultarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnOcultarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarTodos.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarTodos.Location = new System.Drawing.Point(280, 12);
            this.btnOcultarTodos.Name = "btnOcultarTodos";
            this.btnOcultarTodos.Size = new System.Drawing.Size(90, 25);
            this.btnOcultarTodos.TabIndex = 6;
            this.btnOcultarTodos.Text = "Ocultar";
            this.btnOcultarTodos.UseVisualStyleBackColor = false;
            this.btnOcultarTodos.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(280, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mostrar Imagem";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(663, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOcultarTodos);
            this.Controls.Add(this.btnOcultar2);
            this.Controls.Add(this.btnMostrar2);
            this.Controls.Add(this.pctrBoxImagem2);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.pctrBoxImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxImagem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBoxImagem;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.PictureBox pctrBoxImagem2;
        private System.Windows.Forms.Button btnMostrar2;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnOcultar2;
        private System.Windows.Forms.Button btnOcultarTodos;
        private System.Windows.Forms.Button button2;
    }
}

