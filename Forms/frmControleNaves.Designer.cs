
namespace Projeto_CShap_Com_SQL.Forms
{
    partial class frmControleNaves
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
            this.NomeNave = new System.Windows.Forms.Label();
            this.txtNomeNave = new System.Windows.Forms.TextBox();
            this.btnBuscarNave = new System.Windows.Forms.Button();
            this.NomePiloto = new System.Windows.Forms.Label();
            this.txtNomePiloto = new System.Windows.Forms.TextBox();
            this.btnBuscarPiloto = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.rdbChegando = new System.Windows.Forms.RadioButton();
            this.rdbSaindo = new System.Windows.Forms.RadioButton();
            this.dgvNaves = new System.Windows.Forms.DataGridView();
            this.dgvPilotos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeNave
            // 
            this.NomeNave.AutoSize = true;
            this.NomeNave.Location = new System.Drawing.Point(12, 19);
            this.NomeNave.Name = "NomeNave";
            this.NomeNave.Size = new System.Drawing.Size(53, 20);
            this.NomeNave.TabIndex = 0;
            this.NomeNave.Text = "Nome:";
            // 
            // txtNomeNave
            // 
            this.txtNomeNave.Location = new System.Drawing.Point(71, 12);
            this.txtNomeNave.Name = "txtNomeNave";
            this.txtNomeNave.Size = new System.Drawing.Size(631, 27);
            this.txtNomeNave.TabIndex = 1;
            // 
            // btnBuscarNave
            // 
            this.btnBuscarNave.Location = new System.Drawing.Point(712, 10);
            this.btnBuscarNave.Name = "btnBuscarNave";
            this.btnBuscarNave.Size = new System.Drawing.Size(76, 29);
            this.btnBuscarNave.TabIndex = 2;
            this.btnBuscarNave.Text = "Buscar";
            this.btnBuscarNave.UseVisualStyleBackColor = true;
            this.btnBuscarNave.Click += new System.EventHandler(this.btnBuscarNave_Click);
            // 
            // NomePiloto
            // 
            this.NomePiloto.AutoSize = true;
            this.NomePiloto.Location = new System.Drawing.Point(12, 218);
            this.NomePiloto.Name = "NomePiloto";
            this.NomePiloto.Size = new System.Drawing.Size(51, 20);
            this.NomePiloto.TabIndex = 3;
            this.NomePiloto.Text = "Piloto:";
            // 
            // txtNomePiloto
            // 
            this.txtNomePiloto.Location = new System.Drawing.Point(71, 211);
            this.txtNomePiloto.Name = "txtNomePiloto";
            this.txtNomePiloto.Size = new System.Drawing.Size(631, 27);
            this.txtNomePiloto.TabIndex = 4;
            // 
            // btnBuscarPiloto
            // 
            this.btnBuscarPiloto.Location = new System.Drawing.Point(712, 209);
            this.btnBuscarPiloto.Name = "btnBuscarPiloto";
            this.btnBuscarPiloto.Size = new System.Drawing.Size(76, 29);
            this.btnBuscarPiloto.TabIndex = 5;
            this.btnBuscarPiloto.Text = "Buscar";
            this.btnBuscarPiloto.UseVisualStyleBackColor = true;
            this.btnBuscarPiloto.Click += new System.EventHandler(this.btnBuscarPiloto_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(626, 409);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(76, 29);
            this.btnAvancar.TabIndex = 6;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // rdbChegando
            // 
            this.rdbChegando.AutoSize = true;
            this.rdbChegando.Location = new System.Drawing.Point(22, 409);
            this.rdbChegando.Name = "rdbChegando";
            this.rdbChegando.Size = new System.Drawing.Size(98, 24);
            this.rdbChegando.TabIndex = 7;
            this.rdbChegando.TabStop = true;
            this.rdbChegando.Text = "Chegando";
            this.rdbChegando.UseVisualStyleBackColor = true;
            // 
            // rdbSaindo
            // 
            this.rdbSaindo.AutoSize = true;
            this.rdbSaindo.Location = new System.Drawing.Point(210, 409);
            this.rdbSaindo.Name = "rdbSaindo";
            this.rdbSaindo.Size = new System.Drawing.Size(76, 24);
            this.rdbSaindo.TabIndex = 8;
            this.rdbSaindo.TabStop = true;
            this.rdbSaindo.Text = "Saindo";
            this.rdbSaindo.UseVisualStyleBackColor = true;
            // 
            // dgvNaves
            // 
            this.dgvNaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaves.Location = new System.Drawing.Point(71, 46);
            this.dgvNaves.Name = "dgvNaves";
            this.dgvNaves.RowHeadersWidth = 51;
            this.dgvNaves.RowTemplate.Height = 29;
            this.dgvNaves.Size = new System.Drawing.Size(717, 157);
            this.dgvNaves.TabIndex = 9;
            // 
            // dgvPilotos
            // 
            this.dgvPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilotos.Location = new System.Drawing.Point(71, 244);
            this.dgvPilotos.Name = "dgvPilotos";
            this.dgvPilotos.RowHeadersWidth = 51;
            this.dgvPilotos.RowTemplate.Height = 29;
            this.dgvPilotos.Size = new System.Drawing.Size(717, 157);
            this.dgvPilotos.TabIndex = 10;
            // 
            // frmControleNaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPilotos);
            this.Controls.Add(this.dgvNaves);
            this.Controls.Add(this.rdbSaindo);
            this.Controls.Add(this.rdbChegando);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnBuscarPiloto);
            this.Controls.Add(this.txtNomePiloto);
            this.Controls.Add(this.NomePiloto);
            this.Controls.Add(this.btnBuscarNave);
            this.Controls.Add(this.txtNomeNave);
            this.Controls.Add(this.NomeNave);
            this.Name = "frmControleNaves";
            this.Text = "Controle de Naves";
            this.Load += new System.EventHandler(this.FormControleNaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeNave;
        private System.Windows.Forms.TextBox txtNomeNave;
        private System.Windows.Forms.Button btnBuscarNave;
        private System.Windows.Forms.Label NomePiloto;
        private System.Windows.Forms.TextBox txtNomePiloto;
        private System.Windows.Forms.Button btnBuscarPiloto;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.RadioButton rdbChegando;
        private System.Windows.Forms.RadioButton rdbSaindo;
        private System.Windows.Forms.DataGridView dgvNaves;
        private System.Windows.Forms.DataGridView dgvPilotos;
    }
}