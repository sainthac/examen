namespace examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAreaNombreTriangulo = new System.Windows.Forms.Label();
            this.btnCrearTriangulo = new System.Windows.Forms.Button();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAreaNombreRectangulo = new System.Windows.Forms.Label();
            this.txtAlturaRectangulo = new System.Windows.Forms.TextBox();
            this.txtBaseRectangulo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCrearRectangulo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblAreaNombreParalelogramo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtAlturaParalelogramo = new System.Windows.Forms.TextBox();
            this.txtBaseParalelogramo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCrearParalelogramo = new System.Windows.Forms.Button();
            this.btmMostrarPila = new System.Windows.Forms.Button();
            this.lblPila = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 306);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAreaNombreTriangulo);
            this.tabPage1.Controls.Add(this.btnCrearTriangulo);
            this.tabPage1.Controls.Add(this.txtAlturaTriangulo);
            this.tabPage1.Controls.Add(this.txtBaseTriangulo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Triangulo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAreaNombreTriangulo
            // 
            this.lblAreaNombreTriangulo.AutoSize = true;
            this.lblAreaNombreTriangulo.Location = new System.Drawing.Point(32, 182);
            this.lblAreaNombreTriangulo.Name = "lblAreaNombreTriangulo";
            this.lblAreaNombreTriangulo.Size = new System.Drawing.Size(40, 13);
            this.lblAreaNombreTriangulo.TabIndex = 7;
            this.lblAreaNombreTriangulo.Text = "area = ";
            // 
            // btnCrearTriangulo
            // 
            this.btnCrearTriangulo.Location = new System.Drawing.Point(33, 122);
            this.btnCrearTriangulo.Name = "btnCrearTriangulo";
            this.btnCrearTriangulo.Size = new System.Drawing.Size(125, 40);
            this.btnCrearTriangulo.TabIndex = 6;
            this.btnCrearTriangulo.Text = "Crear Triangulo";
            this.btnCrearTriangulo.UseVisualStyleBackColor = true;
            this.btnCrearTriangulo.Click += new System.EventHandler(this.btnCrearTriangulo_Click);
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(81, 90);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(77, 26);
            this.txtAlturaTriangulo.TabIndex = 5;
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseTriangulo.Location = new System.Drawing.Point(81, 58);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(77, 26);
            this.txtBaseTriangulo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altura (H)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base (B)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introducir los parametros del triangulo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 222);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAreaNombreRectangulo);
            this.tabPage2.Controls.Add(this.txtAlturaRectangulo);
            this.tabPage2.Controls.Add(this.txtBaseRectangulo);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btnCrearRectangulo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rectangulo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAreaNombreRectangulo
            // 
            this.lblAreaNombreRectangulo.AutoSize = true;
            this.lblAreaNombreRectangulo.Location = new System.Drawing.Point(37, 169);
            this.lblAreaNombreRectangulo.Name = "lblAreaNombreRectangulo";
            this.lblAreaNombreRectangulo.Size = new System.Drawing.Size(37, 13);
            this.lblAreaNombreRectangulo.TabIndex = 7;
            this.lblAreaNombreRectangulo.Text = "area =";
            // 
            // txtAlturaRectangulo
            // 
            this.txtAlturaRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaRectangulo.Location = new System.Drawing.Point(113, 85);
            this.txtAlturaRectangulo.Name = "txtAlturaRectangulo";
            this.txtAlturaRectangulo.Size = new System.Drawing.Size(58, 26);
            this.txtAlturaRectangulo.TabIndex = 6;
            // 
            // txtBaseRectangulo
            // 
            this.txtBaseRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseRectangulo.Location = new System.Drawing.Point(113, 51);
            this.txtBaseRectangulo.Name = "txtBaseRectangulo";
            this.txtBaseRectangulo.Size = new System.Drawing.Size(59, 26);
            this.txtBaseRectangulo.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(203, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 220);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnCrearRectangulo
            // 
            this.btnCrearRectangulo.Location = new System.Drawing.Point(31, 115);
            this.btnCrearRectangulo.Name = "btnCrearRectangulo";
            this.btnCrearRectangulo.Size = new System.Drawing.Size(140, 32);
            this.btnCrearRectangulo.TabIndex = 3;
            this.btnCrearRectangulo.Text = "Crear Rectangulo";
            this.btnCrearRectangulo.UseVisualStyleBackColor = true;
            this.btnCrearRectangulo.Click += new System.EventHandler(this.btnCrearRectangulo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Altura (h)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Base (b)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Introducir los parametros del rectangulo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblAreaNombreParalelogramo);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.txtAlturaParalelogramo);
            this.tabPage3.Controls.Add(this.txtBaseParalelogramo);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnCrearParalelogramo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(450, 280);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Paralelogramo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblAreaNombreParalelogramo
            // 
            this.lblAreaNombreParalelogramo.AutoSize = true;
            this.lblAreaNombreParalelogramo.Location = new System.Drawing.Point(25, 167);
            this.lblAreaNombreParalelogramo.Name = "lblAreaNombreParalelogramo";
            this.lblAreaNombreParalelogramo.Size = new System.Drawing.Size(40, 13);
            this.lblAreaNombreParalelogramo.TabIndex = 7;
            this.lblAreaNombreParalelogramo.Text = "area = ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(159, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 189);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // txtAlturaParalelogramo
            // 
            this.txtAlturaParalelogramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaParalelogramo.Location = new System.Drawing.Point(95, 78);
            this.txtAlturaParalelogramo.Name = "txtAlturaParalelogramo";
            this.txtAlturaParalelogramo.Size = new System.Drawing.Size(46, 26);
            this.txtAlturaParalelogramo.TabIndex = 5;
            // 
            // txtBaseParalelogramo
            // 
            this.txtBaseParalelogramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseParalelogramo.Location = new System.Drawing.Point(96, 48);
            this.txtBaseParalelogramo.Name = "txtBaseParalelogramo";
            this.txtBaseParalelogramo.Size = new System.Drawing.Size(46, 26);
            this.txtBaseParalelogramo.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Altura (H)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Base (B)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Introducir los parametros del paralelogramo";
            // 
            // btnCrearParalelogramo
            // 
            this.btnCrearParalelogramo.Location = new System.Drawing.Point(22, 119);
            this.btnCrearParalelogramo.Name = "btnCrearParalelogramo";
            this.btnCrearParalelogramo.Size = new System.Drawing.Size(119, 29);
            this.btnCrearParalelogramo.TabIndex = 0;
            this.btnCrearParalelogramo.Text = "Cear Paralelogramo";
            this.btnCrearParalelogramo.UseVisualStyleBackColor = true;
            this.btnCrearParalelogramo.Click += new System.EventHandler(this.btnCrearParalelogramo_Click);
            // 
            // btmMostrarPila
            // 
            this.btmMostrarPila.Location = new System.Drawing.Point(516, 12);
            this.btmMostrarPila.Name = "btmMostrarPila";
            this.btmMostrarPila.Size = new System.Drawing.Size(83, 24);
            this.btmMostrarPila.TabIndex = 1;
            this.btmMostrarPila.Text = "Mostrar Pila";
            this.btmMostrarPila.UseVisualStyleBackColor = true;
            this.btmMostrarPila.Click += new System.EventHandler(this.btmMostrarPila_Click);
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.Location = new System.Drawing.Point(513, 47);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(35, 13);
            this.lblPila.TabIndex = 2;
            this.lblPila.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 330);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.btmMostrarPila);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCrearTriangulo;
        private System.Windows.Forms.TextBox txtAlturaTriangulo;
        private System.Windows.Forms.TextBox txtBaseTriangulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCrearRectangulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmMostrarPila;
        private System.Windows.Forms.Label lblPila;
        private System.Windows.Forms.TextBox txtAlturaRectangulo;
        private System.Windows.Forms.TextBox txtBaseRectangulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtAlturaParalelogramo;
        private System.Windows.Forms.TextBox txtBaseParalelogramo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCrearParalelogramo;
        private System.Windows.Forms.Label lblAreaNombreTriangulo;
        private System.Windows.Forms.Label lblAreaNombreRectangulo;
        private System.Windows.Forms.Label lblAreaNombreParalelogramo;
    }
}

