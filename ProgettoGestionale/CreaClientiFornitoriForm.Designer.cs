using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace ProgettoGestionale
{
    partial class CreaClientiFornitoriForm
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

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.reference.Enabled = true;
            this.reference.updateTable();
            base.OnFormClosed(e);
        }

        protected override void OnShown(EventArgs e)
        {
            this.reference.Enabled = false;
            base.OnShown(e);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ragioneSociale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partitaIva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codiceFiscale = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cap = new System.Windows.Forms.TextBox();
            this.provincia = new System.Windows.Forms.TextBox();
            this.città = new System.Windows.Forms.TextBox();
            this.indirizzo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.creaClienteFornitore = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ragioneSociale
            // 
            this.ragioneSociale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ragioneSociale.Location = new System.Drawing.Point(103, 3);
            this.ragioneSociale.Name = "ragioneSociale";
            this.ragioneSociale.Size = new System.Drawing.Size(496, 20);
            this.ragioneSociale.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ragione sociale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Partita Iva";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partitaIva
            // 
            this.partitaIva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partitaIva.Location = new System.Drawing.Point(103, 34);
            this.partitaIva.Name = "partitaIva";
            this.partitaIva.Size = new System.Drawing.Size(496, 20);
            this.partitaIva.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codice Fiscale";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codiceFiscale
            // 
            this.codiceFiscale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codiceFiscale.Location = new System.Drawing.Point(103, 66);
            this.codiceFiscale.Name = "codiceFiscale";
            this.codiceFiscale.Size = new System.Drawing.Size(496, 20);
            this.codiceFiscale.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 502F));
            this.tableLayoutPanel1.Controls.Add(this.codiceFiscale, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.partitaIva, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ragioneSociale, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 99);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.31328F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.68671F));
            this.tableLayoutPanel2.Controls.Add(this.cap, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.provincia, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.città, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.indirizzo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 200);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.23881F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.76119F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(399, 134);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // cap
            // 
            this.cap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap.Location = new System.Drawing.Point(104, 104);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(292, 20);
            this.cap.TabIndex = 7;
            // 
            // provincia
            // 
            this.provincia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.provincia.Location = new System.Drawing.Point(104, 70);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(292, 20);
            this.provincia.TabIndex = 6;
            // 
            // città
            // 
            this.città.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.città.Location = new System.Drawing.Point(104, 38);
            this.città.Name = "città";
            this.città.Size = new System.Drawing.Size(292, 20);
            this.città.TabIndex = 5;
            // 
            // indirizzo
            // 
            this.indirizzo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indirizzo.Location = new System.Drawing.Point(104, 3);
            this.indirizzo.Name = "indirizzo";
            this.indirizzo.Size = new System.Drawing.Size(292, 20);
            this.indirizzo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Città";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Indirizzo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 34);
            this.label7.TabIndex = 2;
            this.label7.Text = "Provincia";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "CAP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sede Legale";
            // 
            // creaClienteFornitore
            // 
            this.creaClienteFornitore.Location = new System.Drawing.Point(479, 341);
            this.creaClienteFornitore.Name = "creaClienteFornitore";
            this.creaClienteFornitore.Size = new System.Drawing.Size(127, 38);
            this.creaClienteFornitore.TabIndex = 9;
            this.creaClienteFornitore.Text = "creaClienteFornitore";
            this.creaClienteFornitore.UseVisualStyleBackColor = true;
            this.creaClienteFornitore.Click += new System.EventHandler(this.creaClienteFornitore_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(23, 365);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 13);
            this.errorText.TabIndex = 10;
            // 
            // CreaClientiFornitoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 405);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.creaClienteFornitore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreaClientiFornitoriForm";
            this.Text = "CreaClienteFornitore";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ragioneSociale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partitaIva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codiceFiscale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox cap;
        private TextBox provincia;
        private TextBox città;
        private TextBox indirizzo;
        private Label label7;
        private Label label8;
        private Button creaClienteFornitore;
        private Label errorText;

        private const string INSERT_CLIENTE = "DECLARE @i INT;" +
                        "INSERT Clienti (ragione_sociale, partita_iva, codice_fiscale) " +
                        "VALUES( @ragione, @pIva, @CodF);" +
                        "SELECT @i = SCOPE_IDENTITY();" +
                        "INSERT Destinazioni (cliente, fornitore, stato, indirizzo, città, provincia, cap)" +
                        "VALUES( @i, null, 'italia', @indi, @città, @prov, @cap);";

        private const string INSERT_FORNITORE = "DECLARE @i INT;" +
                        "INSERT Fornitori (ragione_sociale, partita_iva, codice_fiscale) " +
                        "VALUES( @ragione, @pIva, @CodF);" +
                        "SELECT @i = SCOPE_IDENTITY();" +
                        "INSERT Destinazioni (cliente, fornitore, stato, indirizzo, città, provincia, cap)" +
                        "VALUES( null, @i, 'italia', @indi, @città, @prov, @cap);";

        private bool insertClienteFornitore(string ragione, string pIva, string CodF, string indi, string città, string prov, string cap)
        {
            SqlCommand command = new SqlCommand();
            reference.connection.Open();
            command.Connection = reference.connection;

            try
            {
                if (this.cliente)
                {
                    command.CommandText = INSERT_CLIENTE;
                }
                else
                {
                    command.CommandText = INSERT_FORNITORE;
                }
                    command.Parameters.AddWithValue("@ragione", ragione);
                    command.Parameters.AddWithValue("@pIva", pIva);
                    command.Parameters.AddWithValue("@CodF", CodF);
                    command.Parameters.AddWithValue("@indi", indi);
                    command.Parameters.AddWithValue("@città", città);
                    command.Parameters.AddWithValue("@prov", prov);
                    command.Parameters.AddWithValue("@cap", cap);

                int result = command.ExecuteNonQuery();
                Console.WriteLine(result);
            }catch(Exception ex)
            {
                errorText.Text = ex.Message;
                return false;
            }
            finally
            {
                reference.connection.Close();
            }
            return true;
        }
    }
}