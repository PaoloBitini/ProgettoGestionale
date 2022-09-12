using System;
using System.Windows.Forms;

namespace ProgettoGestionale
{
    partial class CreaDdtFattureForm
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
            this.refer.Enabled = true;
            this.refer.updateTable();
            base.OnFormClosed(e);
        }

        protected override void OnShown(EventArgs e)
        {
            this.refer.Enabled = false;
            base.OnShown(e);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "CreaDdtFatture";
        }

        #endregion


    }
}