
namespace View
{
    partial class Menu_Inicial
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
            this.btnConfirmaIncluir = new System.Windows.Forms.Button();
            this.btnConfirmaBuscar = new System.Windows.Forms.Button();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirmaAtualizar = new System.Windows.Forms.Button();
            this.btnConfirmaDeletar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmaIncluir
            // 
            this.btnConfirmaIncluir.Location = new System.Drawing.Point(123, 185);
            this.btnConfirmaIncluir.Name = "btnConfirmaIncluir";
            this.btnConfirmaIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaIncluir.TabIndex = 0;
            this.btnConfirmaIncluir.Text = "Incluir";
            this.btnConfirmaIncluir.UseVisualStyleBackColor = true;
            this.btnConfirmaIncluir.Click += new System.EventHandler(this.btnConfirmaIncluir_Click);
            // 
            // btnConfirmaBuscar
            // 
            this.btnConfirmaBuscar.Location = new System.Drawing.Point(240, 45);
            this.btnConfirmaBuscar.Name = "btnConfirmaBuscar";
            this.btnConfirmaBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaBuscar.TabIndex = 1;
            this.btnConfirmaBuscar.Text = "Pesquisar";
            this.btnConfirmaBuscar.UseVisualStyleBackColor = true;
            this.btnConfirmaBuscar.Click += new System.EventHandler(this.btnConfirmaBuscar_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 50);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(29, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "Cpf: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome: ";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(12, 134);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(55, 13);
            this.lblFone.TabIndex = 4;
            this.lblFone.Text = "Telefone: ";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(77, 47);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(146, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(87, 131);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(146, 20);
            this.txtFone.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // btnConfirmaAtualizar
            // 
            this.btnConfirmaAtualizar.Location = new System.Drawing.Point(87, 185);
            this.btnConfirmaAtualizar.Name = "btnConfirmaAtualizar";
            this.btnConfirmaAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaAtualizar.TabIndex = 9;
            this.btnConfirmaAtualizar.Text = "Atualizar";
            this.btnConfirmaAtualizar.UseVisualStyleBackColor = true;
            this.btnConfirmaAtualizar.Click += new System.EventHandler(this.btnConfirmaAtualizar_Click);
            // 
            // btnConfirmaDeletar
            // 
            this.btnConfirmaDeletar.Location = new System.Drawing.Point(168, 185);
            this.btnConfirmaDeletar.Name = "btnConfirmaDeletar";
            this.btnConfirmaDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaDeletar.TabIndex = 10;
            this.btnConfirmaDeletar.Text = "Excluir";
            this.btnConfirmaDeletar.UseVisualStyleBackColor = true;
            this.btnConfirmaDeletar.Click += new System.EventHandler(this.btnConfirmaDeletar_Click);
            // 
            // Menu_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 235);
            this.Controls.Add(this.btnConfirmaDeletar);
            this.Controls.Add(this.btnConfirmaAtualizar);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.btnConfirmaBuscar);
            this.Controls.Add(this.btnConfirmaIncluir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Inicial";
            this.Text = "Menu_Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmaIncluir;
        private System.Windows.Forms.Button btnConfirmaBuscar;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.Button btnConfirmaAtualizar;
        private System.Windows.Forms.Button btnConfirmaDeletar;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
    }
}