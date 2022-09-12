using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProgettoGestionale
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gestionaleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionaleDataSet = new ProgettoGestionale.gestionaleDataSet();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.paginaClienti = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaFornitori = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaDdt = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaFatture = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaMagazzino = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaPagamenti = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoCliente = new System.Windows.Forms.Button();
            this.eliminaCliente = new System.Windows.Forms.Button();
            this.nuovoFornitore = new System.Windows.Forms.Button();
            this.eliminaFornitore = new System.Windows.Forms.Button();
            this.nuovoDdt = new System.Windows.Forms.Button();
            this.eliminaDdt = new System.Windows.Forms.Button();
            this.nuovaFattura = new System.Windows.Forms.Button();
            this.eliminaFattura = new System.Windows.Forms.Button();
            this.nuovoProdotto = new System.Windows.Forms.Button();
            this.eliminaProdotto = new System.Windows.Forms.Button();
            this.nuovoPagamento = new System.Windows.Forms.Button();
            this.eliminaPagamento = new System.Windows.Forms.Button();
            this.contenitoreBottoni = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomePagina = new System.Windows.Forms.Label();
            this.contenitore = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gestionaleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionaleDataSet)).BeginInit();
            this.menu.SuspendLayout();
            this.contenitoreBottoni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contenitore.SuspendLayout();
            this.SuspendLayout();
            // gestionaleDataSetBindingSource
            // 
            this.gestionaleDataSetBindingSource.DataSource = this.gestionaleDataSet;
            this.gestionaleDataSetBindingSource.Position = 0;
            // 
            // gestionaleDataSet
            // 
            this.gestionaleDataSet.DataSetName = "gestionaleDataSet";
            this.gestionaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaClienti,
            this.paginaFornitori,
            this.paginaDdt,
            this.paginaFatture,
            this.paginaMagazzino,
            this.paginaPagamenti});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(895, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // paginaClienti
            // 
            this.paginaClienti.Name = "paginaClienti";
            this.paginaClienti.Size = new System.Drawing.Size(53, 20);
            this.paginaClienti.Text = "Clienti";
            this.paginaClienti.Click += new System.EventHandler(this.paginaClienti_Click);
            // 
            // paginaFornitori
            // 
            this.paginaFornitori.Name = "paginaFornitori";
            this.paginaFornitori.Size = new System.Drawing.Size(64, 20);
            this.paginaFornitori.Text = "Fornitori";
            this.paginaFornitori.Click += new System.EventHandler(this.paginaFornitori_Click);
            // 
            // paginaDdt
            // 
            this.paginaDdt.Name = "paginaDdt";
            this.paginaDdt.Size = new System.Drawing.Size(142, 20);
            this.paginaDdt.Text = "Documenti di trasporto";
            this.paginaDdt.Click += new System.EventHandler(this.paginaDdt_Click);
            // 
            // paginaFatture
            // 
            this.paginaFatture.Name = "paginaFatture";
            this.paginaFatture.Size = new System.Drawing.Size(56, 20);
            this.paginaFatture.Text = "Fatture";
            this.paginaFatture.Click += new System.EventHandler(this.paginaFatture_Click);
            // 
            // paginaMagazzino
            // 
            this.paginaMagazzino.Name = "paginaMagazzino";
            this.paginaMagazzino.Size = new System.Drawing.Size(76, 20);
            this.paginaMagazzino.Text = "Magazzino";
            this.paginaMagazzino.Click += new System.EventHandler(this.paginaMagazzino_Click);
            // 
            // paginaPagamenti
            // 
            this.paginaPagamenti.Name = "paginaPagamenti";
            this.paginaPagamenti.Size = new System.Drawing.Size(76, 20);
            this.paginaPagamenti.Text = "Pagamenti";
            this.paginaPagamenti.Click += new System.EventHandler(this.paginaPagamenti_Click);
            // 
            // nuovoCliente
            // 
            this.nuovoCliente.AutoSize = true;
            this.nuovoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nuovoCliente.Location = new System.Drawing.Point(3, 3);
            this.nuovoCliente.Name = "nuovoCliente";
            this.nuovoCliente.Size = new System.Drawing.Size(84, 23);
            this.nuovoCliente.TabIndex = 2;
            this.nuovoCliente.Text = "Nuovo Cliente";
            this.nuovoCliente.UseVisualStyleBackColor = true;
            this.nuovoCliente.Click += new System.EventHandler(this.nuovoCliente_Click);
            // 
            // eliminaCliente
            // 
            this.eliminaCliente.AutoSize = true;
            this.eliminaCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminaCliente.Location = new System.Drawing.Point(94, 3);
            this.eliminaCliente.Name = "eliminaCliente";
            this.eliminaCliente.Size = new System.Drawing.Size(85, 23);
            this.eliminaCliente.TabIndex = 3;
            this.eliminaCliente.Text = "Elimina Cliente";
            this.eliminaCliente.UseVisualStyleBackColor = true;
            this.eliminaCliente.Click += new System.EventHandler(this.eliminaCliente_Click);
            // 
            // nuovoFornitore
            // 
            this.nuovoFornitore.AutoSize = true;
            this.nuovoFornitore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nuovoFornitore.Location = new System.Drawing.Point(0, 0);
            this.nuovoFornitore.Name = "nuovoFornitore";
            this.nuovoFornitore.Size = new System.Drawing.Size(75, 23);
            this.nuovoFornitore.TabIndex = 2;
            this.nuovoFornitore.Text = "Nuovo Fornitore";
            this.nuovoFornitore.UseVisualStyleBackColor = true;
            this.nuovoFornitore.Click += new System.EventHandler(this.nuovoFornitore_Click);
            // 
            // eliminaFornitore
            // 
            this.eliminaFornitore.AutoSize = true;
            this.eliminaFornitore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminaFornitore.Location = new System.Drawing.Point(0, 0);
            this.eliminaFornitore.Name = "eliminaFornitore";
            this.eliminaFornitore.Size = new System.Drawing.Size(75, 23);
            this.eliminaFornitore.TabIndex = 3;
            this.eliminaFornitore.Text = "Elimina Fornitore";
            this.eliminaFornitore.UseVisualStyleBackColor = true;
            // 
            // nuovoDdt
            // 
            this.nuovoDdt.AutoSize = true;
            this.nuovoDdt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nuovoDdt.Location = new System.Drawing.Point(0, 0);
            this.nuovoDdt.Name = "nuovoDdt";
            this.nuovoDdt.Size = new System.Drawing.Size(75, 23);
            this.nuovoDdt.TabIndex = 2;
            this.nuovoDdt.Text = "Nuovo Ddt";
            this.nuovoDdt.UseVisualStyleBackColor = true;
            this.nuovoDdt.Click += new System.EventHandler(this.nuovoDdt_Click);
            // 
            // eliminaDdt
            // 
            this.eliminaDdt.AutoSize = true;
            this.eliminaDdt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminaDdt.Location = new System.Drawing.Point(0, 0);
            this.eliminaDdt.Name = "eliminaDdt";
            this.eliminaDdt.Size = new System.Drawing.Size(75, 23);
            this.eliminaDdt.TabIndex = 3;
            this.eliminaDdt.Text = "Elimina Ddt";
            this.eliminaDdt.UseVisualStyleBackColor = true;
            // 
            // nuovaFattura
            // 
            this.nuovaFattura.AutoSize = true;
            this.nuovaFattura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nuovaFattura.Location = new System.Drawing.Point(0, 0);
            this.nuovaFattura.Name = "nuovaFattura";
            this.nuovaFattura.Size = new System.Drawing.Size(75, 23);
            this.nuovaFattura.TabIndex = 2;
            this.nuovaFattura.Text = "Nuova Fattura";
            this.nuovaFattura.UseVisualStyleBackColor = true;
            this.nuovaFattura.Click += new System.EventHandler(this.nuovaFattura_Click);
            // 
            // eliminaFattura
            // 
            this.eliminaFattura.AutoSize = true;
            this.eliminaFattura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminaFattura.Location = new System.Drawing.Point(0, 0);
            this.eliminaFattura.Name = "eliminaFattura";
            this.eliminaFattura.Size = new System.Drawing.Size(75, 23);
            this.eliminaFattura.TabIndex = 3;
            this.eliminaFattura.Text = "Elimina Fattura";
            this.eliminaFattura.UseVisualStyleBackColor = true;
            // 
            // nuovoProdotto
            // 
            this.nuovoProdotto.AutoSize = true;
            this.nuovoProdotto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nuovoProdotto.Location = new System.Drawing.Point(0, 0);
            this.nuovoProdotto.Name = "nuovoProdotto";
            this.nuovoProdotto.Size = new System.Drawing.Size(75, 23);
            this.nuovoProdotto.TabIndex = 2;
            this.nuovoProdotto.Text = "Nuovo Prodotto";
            this.nuovoProdotto.UseVisualStyleBackColor = true;
            // 
            // eliminaProdotto
            // 
            this.eliminaProdotto.AutoSize = true;
            this.eliminaProdotto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminaProdotto.Location = new System.Drawing.Point(0, 0);
            this.eliminaProdotto.Name = "eliminaProdotto";
            this.eliminaProdotto.Size = new System.Drawing.Size(75, 23);
            this.eliminaProdotto.TabIndex = 3;
            this.eliminaProdotto.Text = "Elimina Prodotto";
            this.eliminaProdotto.UseVisualStyleBackColor = true;
            // 
            // nuovoPagamento
            // 
            this.nuovoPagamento.AutoSize = true;
            this.nuovoPagamento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nuovoPagamento.Location = new System.Drawing.Point(0, 0);
            this.nuovoPagamento.Name = "nuovoPagamento";
            this.nuovoPagamento.Size = new System.Drawing.Size(75, 23);
            this.nuovoPagamento.TabIndex = 2;
            this.nuovoPagamento.Text = "Nuovo Pagamento";
            this.nuovoPagamento.UseVisualStyleBackColor = true;
            // 
            // eliminaPagamento
            // 
            this.eliminaPagamento.AutoSize = true;
            this.eliminaPagamento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminaPagamento.Location = new System.Drawing.Point(0, 0);
            this.eliminaPagamento.Name = "eliminaPagamento";
            this.eliminaPagamento.Size = new System.Drawing.Size(75, 23);
            this.eliminaPagamento.TabIndex = 3;
            this.eliminaPagamento.Text = "Elimina Pagamento";
            this.eliminaPagamento.UseVisualStyleBackColor = true;
            // 
            // contenitoreBottoni
            // 
            this.contenitoreBottoni.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contenitoreBottoni.AutoSize = true;
            this.contenitoreBottoni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contenitoreBottoni.ColumnCount = 2;
            this.contenitoreBottoni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contenitoreBottoni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contenitoreBottoni.Controls.Add(this.nuovoCliente);
            this.contenitoreBottoni.Controls.Add(this.eliminaCliente);
            this.contenitoreBottoni.Location = new System.Drawing.Point(686, 470);
            this.contenitoreBottoni.Name = "contenitoreBottoni";
            this.contenitoreBottoni.RowCount = 1;
            this.contenitoreBottoni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contenitoreBottoni.Size = new System.Drawing.Size(182, 29);
            this.contenitoreBottoni.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomePagina
            // 
            this.nomePagina.AutoSize = true;
            this.nomePagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePagina.Location = new System.Drawing.Point(3, 0);
            this.nomePagina.Name = "nomePagina";
            this.nomePagina.Size = new System.Drawing.Size(138, 24);
            this.nomePagina.TabIndex = 1;
            this.nomePagina.Text = "Pagina Clienti";
            this.pagina = Pagine.pagCli;
            // 
            // contenitore
            // 
            this.contenitore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenitore.ColumnCount = 1;
            this.contenitore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.contenitore.Controls.Add(this.dataGridView1);
            this.contenitore.Controls.Add(this.contenitoreBottoni);
            this.contenitore.Controls.Add(this.nomePagina, 0, 0);
            this.contenitore.Location = new System.Drawing.Point(12, 27);
            this.contenitore.Name = "contenitore";
            this.contenitore.RowCount = 3;
            this.contenitore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.contenitore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contenitore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.contenitore.Size = new System.Drawing.Size(871, 504);
            this.contenitore.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 543);
            this.Controls.Add(this.contenitore);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(911, 582);
            this.Name = "MainForm";
            this.Text = "Gestionale";
            ((System.ComponentModel.ISupportInitialize)(this.gestionaleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionaleDataSet)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contenitoreBottoni.ResumeLayout(false);
            this.contenitoreBottoni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contenitore.ResumeLayout(false);
            this.contenitore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void interrogazioniSelect(string selectQuery)
        {
            SqlCommand comando = new SqlCommand(selectQuery, this.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            this.dataGridView1.DataSource = bs;

        }

        private System.Windows.Forms.BindingSource gestionaleDataSetBindingSource;
        private gestionaleDataSet gestionaleDataSet;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem paginaFornitori;
        private System.Windows.Forms.ToolStripMenuItem paginaMagazzino;
        private System.Windows.Forms.ToolStripMenuItem paginaDdt;
        private System.Windows.Forms.ToolStripMenuItem paginaFatture;
        private System.Windows.Forms.ToolStripMenuItem paginaPagamenti;
        private System.Windows.Forms.ToolStripMenuItem paginaClienti;
        private System.Windows.Forms.Button nuovoCliente;
        private System.Windows.Forms.Button eliminaCliente;
        private System.Windows.Forms.Button nuovoFornitore;
        private System.Windows.Forms.Button eliminaFornitore;
        private System.Windows.Forms.Button nuovoDdt;
        private System.Windows.Forms.Button eliminaDdt;
        private System.Windows.Forms.Button nuovaFattura;
        private System.Windows.Forms.Button eliminaFattura;
        private System.Windows.Forms.Button nuovoProdotto;
        private System.Windows.Forms.Button eliminaProdotto;
        private System.Windows.Forms.Button nuovoPagamento;
        private System.Windows.Forms.Button eliminaPagamento;
        private TableLayoutPanel contenitoreBottoni;
        private DataGridView dataGridView1;
        private Label nomePagina;
        private TableLayoutPanel contenitore;
        public SqlConnection connection;
        private const string connectionString = "Data Source=LAPTOP-GL39A9LL\\SQLEXPRESS;Initial Catalog=gestionale;Integrated Security=True";

        // Interrogazioni

        // SELECTS

        private const string datiClienti = "SELECT id as 'Identificativo', ragione_sociale as 'Ragione Sociale', partita_iva as 'Partita Iva', codice_fiscale as 'Codice Fiscale'  FROM Clienti";
        private const string datiFornitori = "SELECT id as 'Identificativo', ragione_sociale as 'Ragione Sociale', partita_iva as 'Partita Iva', codice_fiscale as 'Codice Fiscale' FROM Fornitori";
        private const string datiDdt = "SELECT id as 'Identificativo', numero as 'Numero', data as 'Data', cliente as 'Cliente', porto as 'Porto', destinazione as 'Destinazione'  FROM Ddt";
        private const string datiFatture = "SELECT id as 'Identificativo', numero as 'Numero', data as 'Data', cliente as 'Cliente', porto as 'Porto', destinazione as 'Destinazione' FROM Fatture";
        private const string datiMagazzino = "SELECT id as 'Identificativo', codice as 'Codice', descrizione as 'Descrizione', misura as 'Misura', giacenza as 'Giacenza' FROM Prodotti";
        private const string datiPagamenti = "SELECT tipologia as 'Tipologia Pagamenti' FROM Pagamenti";

    }
}

