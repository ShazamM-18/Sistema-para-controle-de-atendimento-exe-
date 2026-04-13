namespace SuporteApp
{
    partial class AtendimentoDetalheForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblProtocolo;
        private Label lblProtocoloValor;
        private Label lblProtocoloExterno;
        private Label lblProtocoloExternoValor;
        private Label lblOrigem;
        private Label lblOrigemValor;
        private Label lblAssunto;
        private Label lblAssuntoValor;
        private Label lblSistema;
        private Label lblSistemaValor;
        private Label lblTela;
        private Label lblTelaValor;
        private Label lblDataAbertura;
        private Label lblDataAberturaValor;
        private Label lblDescricaoInicial;
        private TextBox txtDescricaoInicial;
        private Label lblInteracoes;
        private DataGridView dgvInteracoes;
        private Label lblNovaInteracao;
        private TextBox txtNovaInteracao;
        private Label lblNovaSolucao;
        private TextBox txtNovaSolucao;
        private Button btnAdicionarInteracao;
        private Label lblSolucaoFinal;
        private TextBox txtSolucaoFinal;
        private Button btnFinalizar;

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
            lblProtocoloValor = new Label();
            lblProtocoloExterno = new Label();
            lblProtocoloExternoValor = new Label();
            lblOrigem = new Label();
            lblOrigemValor = new Label();
            lblAssunto = new Label();
            lblAssuntoValor = new Label();
            lblSistema = new Label();
            lblSistemaValor = new Label();
            lblTela = new Label();
            lblTelaValor = new Label();
            lblDataAbertura = new Label();
            lblDataAberturaValor = new Label();
            lblDescricaoInicial = new Label();
            txtDescricaoInicial = new TextBox();
            lblInteracoes = new Label();
            dgvInteracoes = new DataGridView();
            lblNovaInteracao = new Label();
            txtNovaInteracao = new TextBox();
            lblNovaSolucao = new Label();
            txtNovaSolucao = new TextBox();
            btnAdicionarInteracao = new Button();
            lblSolucaoFinal = new Label();
            txtSolucaoFinal = new TextBox();
            btnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInteracoes).BeginInit();
            SuspendLayout();

            // lblProtocolo
            lblProtocolo.AutoSize = true;
            lblProtocolo.Location = new Point(20, 20);
            lblProtocolo.Text = "Protocolo:";

            // lblProtocoloValor
            lblProtocoloValor.AutoSize = true;
            lblProtocoloValor.Location = new Point(90, 20);
            lblProtocoloValor.Text = "-";

            // lblProtocoloExterno
            lblProtocoloExterno.AutoSize = true;
            lblProtocoloExterno.Location = new Point(250, 20);
            lblProtocoloExterno.Text = "Prot. Externo:";

            // lblProtocoloExternoValor
            lblProtocoloExternoValor.AutoSize = true;
            lblProtocoloExternoValor.Location = new Point(340, 20);
            lblProtocoloExternoValor.Text = "-";

            // lblOrigem
            lblOrigem.AutoSize = true;
            lblOrigem.Location = new Point(520, 20);
            lblOrigem.Text = "Origem:";

            // lblOrigemValor
            lblOrigemValor.AutoSize = true;
            lblOrigemValor.Location = new Point(575, 20);
            lblOrigemValor.Text = "-";

            // lblAssunto
            lblAssunto.AutoSize = true;
            lblAssunto.Location = new Point(20, 50);
            lblAssunto.Text = "Assunto:";

            // lblAssuntoValor
            lblAssuntoValor.AutoSize = true;
            lblAssuntoValor.Location = new Point(90, 50);
            lblAssuntoValor.Text = "-";

            // lblSistema
            lblSistema.AutoSize = true;
            lblSistema.Location = new Point(20, 80);
            lblSistema.Text = "Sistema:";

            // lblSistemaValor
            lblSistemaValor.AutoSize = true;
            lblSistemaValor.Location = new Point(90, 80);
            lblSistemaValor.Text = "-";

            // lblTela
            lblTela.AutoSize = true;
            lblTela.Location = new Point(250, 80);
            lblTela.Text = "Tela:";

            // lblTelaValor
            lblTelaValor.AutoSize = true;
            lblTelaValor.Location = new Point(285, 80);
            lblTelaValor.Text = "-";

            // lblDataAbertura
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Location = new Point(520, 80);
            lblDataAbertura.Text = "Abertura:";

            // lblDataAberturaValor
            lblDataAberturaValor.AutoSize = true;
            lblDataAberturaValor.Location = new Point(585, 80);
            lblDataAberturaValor.Text = "-";

            // lblDescricaoInicial
            lblDescricaoInicial.AutoSize = true;
            lblDescricaoInicial.Location = new Point(20, 115);
            lblDescricaoInicial.Text = "Descrição Inicial:";

            // txtDescricaoInicial
            txtDescricaoInicial.Location = new Point(20, 135);
            txtDescricaoInicial.Multiline = true;
            txtDescricaoInicial.ReadOnly = true;
            txtDescricaoInicial.ScrollBars = ScrollBars.Vertical;
            txtDescricaoInicial.Size = new Size(840, 80);

            // lblInteracoes
            lblInteracoes.AutoSize = true;
            lblInteracoes.Location = new Point(20, 225);
            lblInteracoes.Text = "Interações:";

            // dgvInteracoes
            dgvInteracoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInteracoes.Location = new Point(20, 245);
            dgvInteracoes.Size = new Size(840, 180);

            // lblNovaInteracao
            lblNovaInteracao.AutoSize = true;
            lblNovaInteracao.Location = new Point(20, 440);
            lblNovaInteracao.Text = "Nova Interação:";

            // txtNovaInteracao
            txtNovaInteracao.Location = new Point(20, 460);
            txtNovaInteracao.Multiline = true;
            txtNovaInteracao.ScrollBars = ScrollBars.Vertical;
            txtNovaInteracao.Size = new Size(410, 80);

            // lblNovaSolucao
            lblNovaSolucao.AutoSize = true;
            lblNovaSolucao.Location = new Point(450, 440);
            lblNovaSolucao.Text = "Solução Aplicada:";

            // txtNovaSolucao
            txtNovaSolucao.Location = new Point(450, 460);
            txtNovaSolucao.Multiline = true;
            txtNovaSolucao.ScrollBars = ScrollBars.Vertical;
            txtNovaSolucao.Size = new Size(410, 80);

            // btnAdicionarInteracao
            btnAdicionarInteracao.Location = new Point(20, 550);
            btnAdicionarInteracao.Size = new Size(200, 35);
            btnAdicionarInteracao.Text = "Adicionar Interação";
            btnAdicionarInteracao.Click += btnAdicionarInteracao_Click;

            // lblSolucaoFinal
            lblSolucaoFinal.AutoSize = true;
            lblSolucaoFinal.Location = new Point(20, 600);
            lblSolucaoFinal.Text = "Solução Final:";

            // txtSolucaoFinal
            txtSolucaoFinal.Location = new Point(20, 620);
            txtSolucaoFinal.Multiline = true;
            txtSolucaoFinal.ScrollBars = ScrollBars.Vertical;
            txtSolucaoFinal.Size = new Size(610, 80);

            // btnFinalizar
            btnFinalizar.Location = new Point(650, 620);
            btnFinalizar.Size = new Size(210, 40);
            btnFinalizar.Text = "Finalizar Atendimento";
            btnFinalizar.Click += btnFinalizar_Click;

            // AtendimentoDetalheForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 721);
            Controls.Add(lblProtocolo);
            Controls.Add(lblProtocoloValor);
            Controls.Add(lblProtocoloExterno);
            Controls.Add(lblProtocoloExternoValor);
            Controls.Add(lblOrigem);
            Controls.Add(lblOrigemValor);
            Controls.Add(lblAssunto);
            Controls.Add(lblAssuntoValor);
            Controls.Add(lblSistema);
            Controls.Add(lblSistemaValor);
            Controls.Add(lblTela);
            Controls.Add(lblTelaValor);
            Controls.Add(lblDataAbertura);
            Controls.Add(lblDataAberturaValor);
            Controls.Add(lblDescricaoInicial);
            Controls.Add(txtDescricaoInicial);
            Controls.Add(lblInteracoes);
            Controls.Add(dgvInteracoes);
            Controls.Add(lblNovaInteracao);
            Controls.Add(txtNovaInteracao);
            Controls.Add(lblNovaSolucao);
            Controls.Add(txtNovaSolucao);
            Controls.Add(btnAdicionarInteracao);
            Controls.Add(lblSolucaoFinal);
            Controls.Add(txtSolucaoFinal);
            Controls.Add(btnFinalizar);
            Name = "AtendimentoDetalheForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhe do Atendimento";
            Load += AtendimentoDetalheForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInteracoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}