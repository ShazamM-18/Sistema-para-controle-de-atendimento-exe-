namespace SuporteApp
{
    partial class AtendimentosForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblProtocolo;
        private TextBox txtProtocolo;
        private Label lblProtocoloExterno;
        private TextBox txtProtocoloExterno;
        private Label lblOrigem;
        private ComboBox cbOrigem;
        private Button btnPesquisar;
        private Button btnNovo;
        private Button btnDetalhes;
        private DataGridView dgvAtendimentos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblProtocolo = new Label();
            txtProtocolo = new TextBox();
            lblProtocoloExterno = new Label();
            txtProtocoloExterno = new TextBox();
            lblOrigem = new Label();
            cbOrigem = new ComboBox();
            btnPesquisar = new Button();
            btnNovo = new Button();
            btnDetalhes = new Button();
            dgvAtendimentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAtendimentos).BeginInit();
            SuspendLayout();

            // lblProtocolo
            lblProtocolo.AutoSize = true;
            lblProtocolo.Location = new Point(20, 20);
            lblProtocolo.Name = "lblProtocolo";
            lblProtocolo.Size = new Size(57, 15);
            lblProtocolo.Text = "Protocolo";

            // txtProtocolo
            txtProtocolo.Location = new Point(20, 40);
            txtProtocolo.Name = "txtProtocolo";
            txtProtocolo.Size = new Size(150, 23);

            // lblProtocoloExterno
            lblProtocoloExterno.AutoSize = true;
            lblProtocoloExterno.Location = new Point(190, 20);
            lblProtocoloExterno.Name = "lblProtocoloExterno";
            lblProtocoloExterno.Size = new Size(98, 15);
            lblProtocoloExterno.Text = "Protocolo Externo";

            // txtProtocoloExterno
            txtProtocoloExterno.Location = new Point(190, 40);
            txtProtocoloExterno.Name = "txtProtocoloExterno";
            txtProtocoloExterno.Size = new Size(160, 23);

            // lblOrigem
            lblOrigem.AutoSize = true;
            lblOrigem.Location = new Point(370, 20);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(46, 15);
            lblOrigem.Text = "Origem";

            // cbOrigem
            cbOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrigem.Location = new Point(370, 40);
            cbOrigem.Name = "cbOrigem";
            cbOrigem.Size = new Size(150, 23);

            // btnPesquisar
            btnPesquisar.Location = new Point(540, 38);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(100, 27);
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;

            // btnNovo
            btnNovo.Location = new Point(660, 38);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(90, 27);
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;

            // btnDetalhes
            btnDetalhes.Location = new Point(770, 38);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(90, 27);
            btnDetalhes.Text = "Detalhes";
            btnDetalhes.UseVisualStyleBackColor = true;
            btnDetalhes.Click += btnDetalhes_Click;

            // dgvAtendimentos
            dgvAtendimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtendimentos.Location = new Point(20, 85);
            dgvAtendimentos.Name = "dgvAtendimentos";
            dgvAtendimentos.Size = new Size(840, 400);
            dgvAtendimentos.TabIndex = 0;

            // AtendimentosForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(lblProtocolo);
            Controls.Add(txtProtocolo);
            Controls.Add(lblProtocoloExterno);
            Controls.Add(txtProtocoloExterno);
            Controls.Add(lblOrigem);
            Controls.Add(cbOrigem);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnDetalhes);
            Controls.Add(dgvAtendimentos);
            Name = "AtendimentosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atendimentos";
            Load += AtendimentosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtendimentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}