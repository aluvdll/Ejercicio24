namespace Ejercicio24
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_InsertarItem_Form3 = new System.Windows.Forms.TextBox();
            this.btn_Aceptar_Form3 = new System.Windows.Forms.Button();
            this.btn_Cerrar_Form3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce el nombre:";
            // 
            // txtBox_InsertarItem_Form3
            // 
            this.txtBox_InsertarItem_Form3.Location = new System.Drawing.Point(128, 89);
            this.txtBox_InsertarItem_Form3.Name = "txtBox_InsertarItem_Form3";
            this.txtBox_InsertarItem_Form3.Size = new System.Drawing.Size(155, 26);
            this.txtBox_InsertarItem_Form3.TabIndex = 1;
            // 
            // btn_Aceptar_Form3
            // 
            this.btn_Aceptar_Form3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Aceptar_Form3.Location = new System.Drawing.Point(63, 168);
            this.btn_Aceptar_Form3.Name = "btn_Aceptar_Form3";
            this.btn_Aceptar_Form3.Size = new System.Drawing.Size(110, 41);
            this.btn_Aceptar_Form3.TabIndex = 2;
            this.btn_Aceptar_Form3.Text = "Aceptar";
            this.btn_Aceptar_Form3.UseVisualStyleBackColor = true;
            this.btn_Aceptar_Form3.Click += new System.EventHandler(this.btn_Aceptar_Form3_Click_1);
            // 
            // btn_Cerrar_Form3
            // 
            this.btn_Cerrar_Form3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cerrar_Form3.Location = new System.Drawing.Point(238, 168);
            this.btn_Cerrar_Form3.Name = "btn_Cerrar_Form3";
            this.btn_Cerrar_Form3.Size = new System.Drawing.Size(108, 41);
            this.btn_Cerrar_Form3.TabIndex = 3;
            this.btn_Cerrar_Form3.Text = "Cerrar";
            this.btn_Cerrar_Form3.UseVisualStyleBackColor = true;
            this.btn_Cerrar_Form3.Click += new System.EventHandler(this.btn_Cerrar_Form3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 258);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cerrar_Form3);
            this.Controls.Add(this.btn_Aceptar_Form3);
            this.Controls.Add(this.txtBox_InsertarItem_Form3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Nombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cerrar_Form3;
        public System.Windows.Forms.Button btn_Aceptar_Form3;
        public System.Windows.Forms.TextBox txtBox_InsertarItem_Form3;
    }
}