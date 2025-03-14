namespace WindowsFormsApp1
{
    partial class FormHipotenusa
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
            this.TLPcontenedor = new System.Windows.Forms.TableLayoutPanel();
            this.LbCatetoA = new System.Windows.Forms.Label();
            this.txtCatetoA = new System.Windows.Forms.TextBox();
            this.LbCatetoB = new System.Windows.Forms.Label();
            this.txtCatetoB = new System.Windows.Forms.TextBox();
            this.BtCalcular = new System.Windows.Forms.Button();
            this.BtCerrar = new System.Windows.Forms.Button();
            this.lbHipotenusa = new System.Windows.Forms.Label();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.TLPcontenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPcontenedor
            // 
            this.TLPcontenedor.ColumnCount = 2;
            this.TLPcontenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPcontenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPcontenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPcontenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPcontenedor.Controls.Add(this.LbCatetoA, 0, 0);
            this.TLPcontenedor.Controls.Add(this.txtCatetoA, 1, 0);
            this.TLPcontenedor.Controls.Add(this.LbCatetoB, 0, 1);
            this.TLPcontenedor.Controls.Add(this.txtCatetoB, 1, 1);
            this.TLPcontenedor.Controls.Add(this.BtCalcular, 0, 2);
            this.TLPcontenedor.Controls.Add(this.BtCerrar, 1, 2);
            this.TLPcontenedor.Controls.Add(this.lbHipotenusa, 0, 3);
            this.TLPcontenedor.Controls.Add(this.txtHipotenusa, 1, 3);
            this.TLPcontenedor.Location = new System.Drawing.Point(33, 28);
            this.TLPcontenedor.Name = "TLPcontenedor";
            this.TLPcontenedor.RowCount = 4;
            this.TLPcontenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPcontenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPcontenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPcontenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLPcontenedor.Size = new System.Drawing.Size(416, 153);
            this.TLPcontenedor.TabIndex = 0;
            // 
            // LbCatetoA
            // 
            this.LbCatetoA.AutoSize = true;
            this.LbCatetoA.Location = new System.Drawing.Point(3, 0);
            this.LbCatetoA.Name = "LbCatetoA";
            this.LbCatetoA.Size = new System.Drawing.Size(48, 13);
            this.LbCatetoA.TabIndex = 0;
            this.LbCatetoA.Text = "Cateto A";
            this.LbCatetoA.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCatetoA
            // 
            this.txtCatetoA.Location = new System.Drawing.Point(211, 3);
            this.txtCatetoA.Name = "txtCatetoA";
            this.txtCatetoA.Size = new System.Drawing.Size(100, 20);
            this.txtCatetoA.TabIndex = 1;
            this.txtCatetoA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LbCatetoB
            // 
            this.LbCatetoB.AutoSize = true;
            this.LbCatetoB.Location = new System.Drawing.Point(3, 30);
            this.LbCatetoB.Name = "LbCatetoB";
            this.LbCatetoB.Size = new System.Drawing.Size(48, 13);
            this.LbCatetoB.TabIndex = 2;
            this.LbCatetoB.Text = "Cateto B";
            // 
            // txtCatetoB
            // 
            this.txtCatetoB.Location = new System.Drawing.Point(211, 33);
            this.txtCatetoB.Name = "txtCatetoB";
            this.txtCatetoB.Size = new System.Drawing.Size(100, 20);
            this.txtCatetoB.TabIndex = 3;
            // 
            // BtCalcular
            // 
            this.BtCalcular.Location = new System.Drawing.Point(3, 63);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtCalcular.TabIndex = 4;
            this.BtCalcular.Text = "Ca&lcular";
            this.BtCalcular.UseVisualStyleBackColor = true;
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // BtCerrar
            // 
            this.BtCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCerrar.Location = new System.Drawing.Point(211, 63);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtCerrar.TabIndex = 5;
            this.BtCerrar.Text = "&Cerrar";
            this.BtCerrar.UseVisualStyleBackColor = true;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // lbHipotenusa
            // 
            this.lbHipotenusa.AutoSize = true;
            this.lbHipotenusa.Location = new System.Drawing.Point(3, 90);
            this.lbHipotenusa.Name = "lbHipotenusa";
            this.lbHipotenusa.Size = new System.Drawing.Size(61, 13);
            this.lbHipotenusa.TabIndex = 6;
            this.lbHipotenusa.Text = "Hipotenusa";
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Location = new System.Drawing.Point(211, 93);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(100, 20);
            this.txtHipotenusa.TabIndex = 7;
            // 
            // FormHipotenusa
            // 
            this.AcceptButton = this.BtCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.BtCerrar;
            this.ClientSize = new System.Drawing.Size(482, 209);
            this.Controls.Add(this.TLPcontenedor);
            this.Name = "FormHipotenusa";
            this.Text = "Calcular Hipotenusa";
            this.TLPcontenedor.ResumeLayout(false);
            this.TLPcontenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPcontenedor;
        private System.Windows.Forms.Label LbCatetoA;
        private System.Windows.Forms.TextBox txtCatetoA;
        private System.Windows.Forms.Label LbCatetoB;
        private System.Windows.Forms.TextBox txtCatetoB;
        private System.Windows.Forms.Button BtCalcular;
        private System.Windows.Forms.Button BtCerrar;
        private System.Windows.Forms.Label lbHipotenusa;
        private System.Windows.Forms.TextBox txtHipotenusa;
    }
}