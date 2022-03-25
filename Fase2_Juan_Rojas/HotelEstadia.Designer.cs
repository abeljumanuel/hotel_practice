
namespace Fase2_Juan_Rojas
{
    partial class HotelEstadia
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.cmbtproom = new System.Windows.Forms.ComboBox();
            this.grpsex = new System.Windows.Forms.GroupBox();
            this.optwoman = new System.Windows.Forms.RadioButton();
            this.optman = new System.Windows.Forms.RadioButton();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.grpsex.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres y Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de habitación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo de habitación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Días de hospedaje";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(176, 53);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 23);
            this.txtid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(176, 97);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(160, 23);
            this.txtname.TabIndex = 6;
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(176, 188);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.ReadOnly = true;
            this.txtvalue.Size = new System.Drawing.Size(100, 23);
            this.txtvalue.TabIndex = 7;
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(474, 142);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(92, 23);
            this.txtdays.TabIndex = 8;
            // 
            // cmbtproom
            // 
            this.cmbtproom.FormattingEnabled = true;
            this.cmbtproom.Items.AddRange(new object[] {
            "Sencilla",
            "Doble",
            "Especial"});
            this.cmbtproom.Location = new System.Drawing.Point(176, 141);
            this.cmbtproom.Name = "cmbtproom";
            this.cmbtproom.Size = new System.Drawing.Size(100, 23);
            this.cmbtproom.TabIndex = 9;
            this.cmbtproom.SelectedIndexChanged += new System.EventHandler(this.cmbtproom_SelectedIndexChanged);
            // 
            // grpsex
            // 
            this.grpsex.Controls.Add(this.optwoman);
            this.grpsex.Controls.Add(this.optman);
            this.grpsex.Location = new System.Drawing.Point(366, 53);
            this.grpsex.Name = "grpsex";
            this.grpsex.Size = new System.Drawing.Size(200, 67);
            this.grpsex.TabIndex = 10;
            this.grpsex.TabStop = false;
            this.grpsex.Text = "Genero";
            // 
            // optwoman
            // 
            this.optwoman.AutoSize = true;
            this.optwoman.Location = new System.Drawing.Point(6, 42);
            this.optwoman.Name = "optwoman";
            this.optwoman.Size = new System.Drawing.Size(78, 19);
            this.optwoman.TabIndex = 1;
            this.optwoman.TabStop = true;
            this.optwoman.Text = "Femenino";
            this.optwoman.UseVisualStyleBackColor = true;
            // 
            // optman
            // 
            this.optman.AutoSize = true;
            this.optman.Location = new System.Drawing.Point(6, 22);
            this.optman.Name = "optman";
            this.optman.Size = new System.Drawing.Size(80, 19);
            this.optman.TabIndex = 0;
            this.optman.TabStop = true;
            this.optman.Text = "Masculino";
            this.optman.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(48, 253);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(139, 23);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Guardar Registro";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(245, 253);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(152, 23);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calcular Valor Estadia";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(452, 253);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 23);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Salir Aplicación";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // HotelEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 286);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.grpsex);
            this.Controls.Add(this.cmbtproom);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HotelEstadia";
            this.Text = "HotelEstadia";
            this.Load += new System.EventHandler(this.HotelEstadia_Load);
            this.grpsex.ResumeLayout(false);
            this.grpsex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.ComboBox cmbtproom;
        private System.Windows.Forms.GroupBox grpsex;
        private System.Windows.Forms.RadioButton optwoman;
        private System.Windows.Forms.RadioButton optman;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
    }
}