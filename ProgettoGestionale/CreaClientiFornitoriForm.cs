using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGestionale
{
    public partial class CreaClientiFornitoriForm : Form
    {
        private MainForm reference;
        private bool cliente;
        public CreaClientiFornitoriForm ( MainForm refer, bool cliente)
        {
            reference = refer;
            this.cliente = cliente;

            InitializeComponent();

            if (this.cliente)
            {
                Text = "Crea Cliente";
                creaClienteFornitore.Text = "Crea Cliente";
            }
            else
            {
                Text = "Crea Fornitore";
                creaClienteFornitore.Text = "Crea Fornitore";
            }
        }

        private void creaClienteFornitore_Click(object sender, EventArgs e)
        {
            // creazione cliente database
            if (fieldControl())
            {
                bool result = insertClienteFornitore(ragioneSociale.Text,
                    partitaIva.Text,
                    codiceFiscale.Text,
                    indirizzo.Text,
                    città.Text,
                    provincia.Text,
                    cap.Text);
                if (result)
                {
                    this.Close();
                }
            }
        }

        private bool fieldControl()
        {
            if(ragioneSociale.Text == "" ||
               codiceFiscale.Text == "" ||
               partitaIva.Text == "" ||
               indirizzo.Text == "" ||
               città.Text == "" ||
               provincia.Text == "" ||
               cap.Text == "")
            {
                errorText.Text = "Non è possibile lasciare campi vuoti";
                return false;

            }
 /*           else if (!IsPAOK(partitaIva.Text))
            {
                errorText.Text = "la partita iva non è corretta";
                return false;
            }
            else if (!IsFiscalCodeOk(codiceFiscale.Text))
            {
                errorText.Text = "Il Codice fiscale non è corretto";
                return false;
            } */
            return true;
        }

        private bool IsFiscalCodeOk(string fiscalCode)
        {
            const string regex = @"/^(?:[B-DF-HJ-NP-TV-Z](?:[AEIOU]{2}|[AEIOU]X)|[AEIOU]{2}X|[B-DF-HJ-NP-TV-Z]{2}[A-Z]){2}[\dLMNP-V]{2}(?:[A-EHLMPR-T](?:[04LQ][1-9MNP-V]|[1256LMRS][\dLMNP-V])|[DHPS][37PT][0L]|[ACELMRT][37PT][01LM])(?:[A-MZ][1-9MNP-V][\dLMNP-V]{2}|[A-M][0L](?:[\dLMNP-V][1-9MNP-V]|[1-9MNP-V][0L]))[A-Z]$/i";
            if (!Regex.IsMatch(fiscalCode, regex))
                return false;

            #region static maps

            var oddMap = new Dictionary<char, int>() {
                {'0', 1},
                {'1', 0},
                {'2', 5},
                {'3', 7},
                {'4', 9},
                {'5', 13},
                {'6', 15},
                {'7', 17},
                {'8', 19},
                {'9', 21},
                {'A', 1},
                {'B', 0},
                {'C', 5},
                {'D', 7},
                {'E', 9},
                {'F', 13},
                {'G', 15},
                {'H', 17},
                {'I', 19},
                {'J', 21},
                {'K', 2},
                {'L', 4},
                {'M', 18},
                {'N', 20},
                {'O', 11},
                {'P', 3},
                {'Q', 6},
                {'R', 8},
                {'S', 12},
                {'T', 14},
                {'U', 16},
                {'V', 10},
                {'W', 22},
                {'X', 25},
                {'Y', 24},
                {'Z', 23}
            };

            var evenMap = new Dictionary<char, int>() {
                {'0', 0},
                {'1', 1},
                {'2', 2},
                {'3', 3},
                {'4', 4},
                {'5', 5},
                {'6', 6},
                {'7', 7},
                {'8', 8},
                {'9', 9},
                {'A', 0},
                {'B', 1},
                {'C', 2},
                {'D', 3},
                {'E', 4},
                {'F', 5},
                {'G', 6},
                {'H', 7},
                {'I', 8},
                {'J', 9},
                {'K', 10},
                {'L', 11},
                {'M', 12},
                {'N', 13},
                {'O', 14},
                {'P', 15},
                {'Q', 16},
                {'R', 17},
                {'S', 18},
                {'T', 19},
                {'U', 20},
                {'V', 21},
                {'W', 22},
                {'X', 23},
                {'Y', 24},
                {'Z', 25}
            };

            #endregion static maps

            int total = 0;
            for (int i = 0; i < 15; i += 2)
                total += oddMap[fiscalCode[i]];
            for (int i = 1; i < 15; i += 2)
                total += evenMap[fiscalCode[i]];

            return fiscalCode[15] == (char)('A' + total % 26);
        }

        public static bool IsPAOK(string paramPI)
        {
            paramPI = paramPI.Trim();
            try
            {
                if (paramPI.Length == 11)
                {
                    int tot = 0;
                    int dispari = 0;

                    for (int i = 0; i < 10; i += 2)
                        dispari += int.Parse(paramPI.Substring(i, 1));

                    for (int i = 1; i < 10; i += 2)
                    {
                        tot = (int.Parse(paramPI.Substring(i, 1))) * 2;
                        tot = (tot / 10) + (tot % 10);
                        dispari += tot;
                    }

                    int controllo = int.Parse(paramPI.Substring(10, 1));

                    if (((dispari % 10) == 0 && (controllo == 0))
                       || ((10 - (dispari % 10)) == controllo))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
