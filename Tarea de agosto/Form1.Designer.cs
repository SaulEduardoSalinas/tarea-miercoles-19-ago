using System.Windows.Forms;

namespace sistema_gestion_del_tiempo_y_la_demanada_primer_nivel
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbl = new System.Windows.Forms.Label();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.cbo3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(115, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(792, 39);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Sistema Gestion del Tiempo y la demanda primer nivel.";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(369, 64);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(266, 35);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Datos del paciente.";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(12, 120);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(208, 26);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "1.Nombre Completo:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(12, 195);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(194, 31);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "2.N Expediente:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(49, 269);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(105, 31);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "3. Edad:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(31, 354);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(125, 31);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "4.Genero:";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(518, 193);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(143, 31);
            this.lbl9.TabIndex = 8;
            this.lbl9.Text = "7.Telefono:";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(84, 503);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(207, 77);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Procesar Registro ";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(320, 503);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(207, 77);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "Verificar Expediente ";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(557, 503);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(208, 77);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "Volver A menu Principal";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(660, 200);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(150, 22);
            this.txt7.TabIndex = 13;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(226, 123);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(144, 22);
            this.txt1.TabIndex = 14;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(199, 200);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(144, 22);
            this.txt2.TabIndex = 15;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(147, 274);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(144, 22);
            this.txt3.TabIndex = 16;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(443, 359);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(239, 31);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "9. Triage/Prioridad:";
            // 
            // cbo2
            // 
            this.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Items.AddRange(new object[] {
            "Emergencia",
            "Urgencia",
            "Prioridad",
            "Estable",
            "Menor"});
            this.cbo2.Location = new System.Drawing.Point(680, 359);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(164, 24);
            this.cbo2.TabIndex = 22;
            // 
            // cbo3
            // 
            this.cbo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo3.FormattingEnabled = true;
            this.cbo3.Items.AddRange(new object[] {
            "Maculino",
            "Femenino",
            "Otro"});
            this.cbo3.Location = new System.Drawing.Point(162, 359);
            this.cbo3.Name = "cbo3";
            this.cbo3.Size = new System.Drawing.Size(164, 24);
            this.cbo3.TabIndex = 23;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(986, 581);
            this.Controls.Add(this.cbo3);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Label lbl;
        private ComboBox cbo2;
        private ComboBox cbo3;
    }
    }
