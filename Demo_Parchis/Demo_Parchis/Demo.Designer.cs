
namespace Demo_Parchis
{
    partial class Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.Boton = new System.Windows.Forms.Button();
            this.Dado = new System.Windows.Forms.PictureBox();
            this.tablero = new System.Windows.Forms.PictureBox();
            this.rojo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton
            // 
            this.Boton.Location = new System.Drawing.Point(1001, 293);
            this.Boton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(112, 35);
            this.Boton.TabIndex = 1;
            this.Boton.Text = "Click";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.dado_Click);
            // 
            // Dado
            // 
            this.Dado.Location = new System.Drawing.Point(970, 103);
            this.Dado.Name = "Dado";
            this.Dado.Size = new System.Drawing.Size(177, 166);
            this.Dado.TabIndex = 2;
            this.Dado.TabStop = false;
            // 
            // tablero
            // 
            this.tablero.Image = ((System.Drawing.Image)(resources.GetObject("tablero.Image")));
            this.tablero.InitialImage = ((System.Drawing.Image)(resources.GetObject("tablero.InitialImage")));
            this.tablero.Location = new System.Drawing.Point(310, 35);
            this.tablero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(401, 398);
            this.tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tablero.TabIndex = 0;
            this.tablero.TabStop = false;
            this.tablero.Click += new System.EventHandler(this.tablero_Click);
            // 
            // rojo
            // 
            this.rojo.Image = ((System.Drawing.Image)(resources.GetObject("rojo.Image")));
            this.rojo.Location = new System.Drawing.Point(430, 89);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(30, 27);
            this.rojo.TabIndex = 3;
            this.rojo.TabStop = false;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.rojo);
            this.Controls.Add(this.Dado);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.tablero);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Demo";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Demo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tablero;
        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.PictureBox Dado;
        private System.Windows.Forms.PictureBox rojo;
    }
}