
namespace Projeto_CShap_Com_SQL.Forms
{
    partial class frmRegistrarEntradaSaida
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lvAlertas = new System.Windows.Forms.ListView();
            this.lblNave = new System.Windows.Forms.Label();
            this.lblNomeNave = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblAnoNacimento = new System.Windows.Forms.Label();
            this.lblNomePiloto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(737, 12);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 36);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lvAlertas
            // 
            this.lvAlertas.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvAlertas.HideSelection = false;
            this.lvAlertas.Location = new System.Drawing.Point(12, 241);
            this.lvAlertas.Name = "lvAlertas";
            this.lvAlertas.RightToLeftLayout = true;
            this.lvAlertas.Size = new System.Drawing.Size(819, 197);
            this.lvAlertas.TabIndex = 1;
            this.lvAlertas.UseCompatibleStateImageBehavior = false;
            this.lvAlertas.View = System.Windows.Forms.View.List;
            // 
            // lblNave
            // 
            this.lblNave.AutoSize = true;
            this.lblNave.Location = new System.Drawing.Point(21, 20);
            this.lblNave.Name = "lblNave";
            this.lblNave.Size = new System.Drawing.Size(43, 20);
            this.lblNave.TabIndex = 2;
            this.lblNave.Text = "Nave";
            // 
            // lblNomeNave
            // 
            this.lblNomeNave.AutoSize = true;
            this.lblNomeNave.Location = new System.Drawing.Point(99, 57);
            this.lblNomeNave.Name = "lblNomeNave";
            this.lblNomeNave.Size = new System.Drawing.Size(0, 20);
            this.lblNomeNave.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(99, 87);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(0, 20);
            this.lblModelo.TabIndex = 4;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(99, 117);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(0, 20);
            this.lblClasse.TabIndex = 5;
            // 
            // lblAnoNacimento
            // 
            this.lblAnoNacimento.AutoSize = true;
            this.lblAnoNacimento.Location = new System.Drawing.Point(547, 87);
            this.lblAnoNacimento.Name = "lblAnoNacimento";
            this.lblAnoNacimento.Size = new System.Drawing.Size(0, 20);
            this.lblAnoNacimento.TabIndex = 7;
            // 
            // lblNomePiloto
            // 
            this.lblNomePiloto.AutoSize = true;
            this.lblNomePiloto.Location = new System.Drawing.Point(547, 57);
            this.lblNomePiloto.Name = "lblNomePiloto";
            this.lblNomePiloto.Size = new System.Drawing.Size(0, 20);
            this.lblNomePiloto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Piloto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Classe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome:";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(547, 117);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(0, 20);
            this.lblPlaneta.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Planeta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ano Nasc.:";
            // 
            // frmRegistrarEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 446);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNomePiloto);
            this.Controls.Add(this.lblAnoNacimento);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNomeNave);
            this.Controls.Add(this.lblNave);
            this.Controls.Add(this.lvAlertas);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "frmRegistrarEntradaSaida";
            this.Text = "Registro de Entrada e Saida";
            this.Load += new System.EventHandler(this.frmRegistrarEntradaSaida_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView lvAlertas;
        private System.Windows.Forms.Label lblNave;
        private System.Windows.Forms.Label lblNomeNave;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblAnoNacimento;
        private System.Windows.Forms.Label lblNomePiloto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}