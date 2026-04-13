namespace SuporteApp
{
    partial class NovoAtendimentoForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblIdCliente;
        private TextBox txtIdCliente;
        private Label lblProtocoloExterno;
        private TextBox txtProtocoloExterno;
        private Label lblOrigem;
        private ComboBox cbOrigem;
        private Label lblPrioridade;
        private ComboBox cbPrioridade;
        private Label lblCanal;
        private ComboBox cbCanal;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private Label lblAssunto;
        private TextBox txtAssunto;
        private Label lblDescricaoInicial;
        private TextBox txtDescricaoInicial;
        private Label lblSistemaAfetado;
        private TextBox txtSistemaAfetado;
        private Label lblTelaAfetada;
        private TextBox txtTelaAfetada;
        private Button btnSalvar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblIdCliente = new Label();
            txtIdCliente = new TextBox();
            lblProtocoloExterno = new Label();
            txtProtocoloExterno = new TextBox();
            lblOrigem = new Label();
            cbOrigem = new ComboBox();
            lblPrioridade = new Label();
            cbPrioridade = new ComboBox();
            lblCanal = new Label();
            cbCanal = new ComboBox();
            lblCategoria = new Label();
            cbCategoria = new ComboBox();
            lblAssunto = new Label();
            txtAssunto = new TextBox();
            lblDescricaoInicial = new Label();
            txtDescricaoInicial = new TextBox();
            lblSistemaAfetado = new Label();
            txtSistemaAfetado = new TextBox();
            lblTelaAfetada = new Label();
            txtTelaAfetada = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();

            // lblIdCliente
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(20, 20);
            lblIdCliente.Text = "ID Cliente";

            // txtIdCliente
            txtIdCliente.Location = new Point(20, 40);
            txtIdCliente.Size = new Size(120, 23);

            // lblProtocoloExterno
            lblProtocoloExterno.AutoSize = true;
            lblProtocoloExterno.Location = new Point(160, 20);
            lblProtocoloExterno.Text = "Protocolo Externo";

            // txtProtocoloExterno
            txtProtocoloExterno.Location = new Point(160, 40);
            txtProtocoloExterno.Size = new Size(180, 23);

            // lblOrigem
            lblOrigem.AutoSize = true;
            lblOrigem.Location = new Point(360, 20);
            lblOrigem.Text = "Origem";

            // cbOrigem
            cbOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrigem.Location = new Point(360, 40);
            cbOrigem.Size = new Size(160, 23);

            // lblPrioridade
            lblPrioridade.AutoSize = true;
            lblPrioridade.Location = new Point(20, 80);
            lblPrioridade.Text = "Prioridade";

            // cbPrioridade
            cbPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrioridade.Location = new Point(20, 100);
            cbPrioridade.Size = new Size(160, 23);

            // lblCanal
            lblCanal.AutoSize = true;
            lblCanal.Location = new Point(200, 80);
            lblCanal.Text = "Canal";

            // cbCanal
            cbCanal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCanal.Location = new Point(200, 100);
            cbCanal.Size = new Size(160, 23);

            // lblCategoria
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(380, 80);
            lblCategoria.Text = "Categoria";

            // cbCategoria
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Location = new Point(380, 100);
            cbCategoria.Size = new Size(200, 23);

            // lblAssunto
            lblAssunto.AutoSize = true;
            lblAssunto.Location = new Point(20, 140);
            lblAssunto.Text = "Assunto";

            // txtAssunto
            txtAssunto.Location = new Point(20, 160);
            txtAssunto.Size = new Size(560, 23);

            // lblDescricaoInicial
            lblDescricaoInicial.AutoSize = true;
            lblDescricaoInicial.Location = new Point(20, 200);
            lblDescricaoInicial.Text = "Descrição Inicial";

            // txtDescricaoInicial
            txtDescricaoInicial.Location = new Point(20, 220);
            txtDescricaoInicial.Multiline = true;
            txtDescricaoInicial.ScrollBars = ScrollBars.Vertical;
            txtDescricaoInicial.Size = new Size(560, 100);

            // lblSistemaAfetado
            lblSistemaAfetado.AutoSize = true;
            lblSistemaAfetado.Location = new Point(20, 340);
            lblSistemaAfetado.Text = "Sistema Afetado";

            // txtSistemaAfetado
            txtSistemaAfetado.Location = new Point(20, 360);
            txtSistemaAfetado.Size = new Size(270, 23);

            // lblTelaAfetada
            lblTelaAfetada.AutoSize = true;
            lblTelaAfetada.Location = new Point(310, 340);
            lblTelaAfetada.Text = "Tela Afetada";

            // txtTelaAfetada
            txtTelaAfetada.Location = new Point(310, 360);
            txtTelaAfetada.Size = new Size(270, 23);

            // btnSalvar
            btnSalvar.Location = new Point(20, 410);
            btnSalvar.Size = new Size(130, 35);
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;

            // btnCancelar
            btnCancelar.Location = new Point(170, 410);
            btnCancelar.Size = new Size(130, 35);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            // NovoAtendimentoForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 470);
            Controls.Add(lblIdCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(lblProtocoloExterno);
            Controls.Add(txtProtocoloExterno);
            Controls.Add(lblOrigem);
            Controls.Add(cbOrigem);
            Controls.Add(lblPrioridade);
            Controls.Add(cbPrioridade);
            Controls.Add(lblCanal);
            Controls.Add(cbCanal);
            Controls.Add(lblCategoria);
            Controls.Add(cbCategoria);
            Controls.Add(lblAssunto);
            Controls.Add(txtAssunto);
            Controls.Add(lblDescricaoInicial);
            Controls.Add(txtDescricaoInicial);
            Controls.Add(lblSistemaAfetado);
            Controls.Add(txtSistemaAfetado);
            Controls.Add(lblTelaAfetada);
            Controls.Add(txtTelaAfetada);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Name = "NovoAtendimentoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Atendimento";
            Load += NovoAtendimentoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}