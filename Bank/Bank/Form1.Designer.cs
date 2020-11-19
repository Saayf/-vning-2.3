
namespace Bank
{
    partial class formBank
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
            this.gbxInsättningUttag = new System.Windows.Forms.GroupBox();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.btnUttag = new System.Windows.Forms.Button();
            this.btnInsättning = new System.Windows.Forms.Button();
            this.lblBelopp = new System.Windows.Forms.Label();
            this.gbxÖppnaKonto = new System.Windows.Forms.GroupBox();
            this.lblKredit = new System.Windows.Forms.Label();
            this.lblRäntesats = new System.Windows.Forms.Label();
            this.tbxKredit = new System.Windows.Forms.TextBox();
            this.tbxRänteSats = new System.Windows.Forms.TextBox();
            this.tbxPersonNr = new System.Windows.Forms.TextBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.lblPersonNr = new System.Windows.Forms.Label();
            this.lbxKonton = new System.Windows.Forms.ListBox();
            this.btnÅrsRänta = new System.Windows.Forms.Button();
            this.gbxInsättningUttag.SuspendLayout();
            this.gbxÖppnaKonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInsättningUttag
            // 
            this.gbxInsättningUttag.Controls.Add(this.tbxBelopp);
            this.gbxInsättningUttag.Controls.Add(this.btnUttag);
            this.gbxInsättningUttag.Controls.Add(this.btnInsättning);
            this.gbxInsättningUttag.Controls.Add(this.lblBelopp);
            this.gbxInsättningUttag.Location = new System.Drawing.Point(12, 12);
            this.gbxInsättningUttag.Name = "gbxInsättningUttag";
            this.gbxInsättningUttag.Size = new System.Drawing.Size(169, 191);
            this.gbxInsättningUttag.TabIndex = 0;
            this.gbxInsättningUttag.TabStop = false;
            this.gbxInsättningUttag.Text = "Insättning/Uttag";
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(47, 36);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(100, 20);
            this.tbxBelopp.TabIndex = 3;
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(88, 153);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(75, 23);
            this.btnUttag.TabIndex = 2;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            this.btnUttag.Click += new System.EventHandler(this.btnUttag_Click);
            // 
            // btnInsättning
            // 
            this.btnInsättning.Location = new System.Drawing.Point(88, 124);
            this.btnInsättning.Name = "btnInsättning";
            this.btnInsättning.Size = new System.Drawing.Size(75, 23);
            this.btnInsättning.TabIndex = 1;
            this.btnInsättning.Text = "Insättning";
            this.btnInsättning.UseVisualStyleBackColor = true;
            this.btnInsättning.Click += new System.EventHandler(this.btnInsättning_Click);
            // 
            // lblBelopp
            // 
            this.lblBelopp.AutoSize = true;
            this.lblBelopp.Location = new System.Drawing.Point(6, 39);
            this.lblBelopp.Name = "lblBelopp";
            this.lblBelopp.Size = new System.Drawing.Size(40, 13);
            this.lblBelopp.TabIndex = 0;
            this.lblBelopp.Text = "Belopp";
            // 
            // gbxÖppnaKonto
            // 
            this.gbxÖppnaKonto.Controls.Add(this.lblKredit);
            this.gbxÖppnaKonto.Controls.Add(this.lblRäntesats);
            this.gbxÖppnaKonto.Controls.Add(this.tbxKredit);
            this.gbxÖppnaKonto.Controls.Add(this.tbxRänteSats);
            this.gbxÖppnaKonto.Controls.Add(this.tbxPersonNr);
            this.gbxÖppnaKonto.Controls.Add(this.btnRegistrera);
            this.gbxÖppnaKonto.Controls.Add(this.lblPersonNr);
            this.gbxÖppnaKonto.Location = new System.Drawing.Point(201, 12);
            this.gbxÖppnaKonto.Name = "gbxÖppnaKonto";
            this.gbxÖppnaKonto.Size = new System.Drawing.Size(169, 191);
            this.gbxÖppnaKonto.TabIndex = 4;
            this.gbxÖppnaKonto.TabStop = false;
            this.gbxÖppnaKonto.Text = "Öppna Konto";
            // 
            // lblKredit
            // 
            this.lblKredit.AutoSize = true;
            this.lblKredit.Location = new System.Drawing.Point(15, 96);
            this.lblKredit.Name = "lblKredit";
            this.lblKredit.Size = new System.Drawing.Size(34, 13);
            this.lblKredit.TabIndex = 7;
            this.lblKredit.Text = "Kredit";
            // 
            // lblRäntesats
            // 
            this.lblRäntesats.AutoSize = true;
            this.lblRäntesats.Location = new System.Drawing.Point(6, 67);
            this.lblRäntesats.Name = "lblRäntesats";
            this.lblRäntesats.Size = new System.Drawing.Size(55, 13);
            this.lblRäntesats.TabIndex = 6;
            this.lblRäntesats.Text = "Räntesats";
            // 
            // tbxKredit
            // 
            this.tbxKredit.Location = new System.Drawing.Point(63, 91);
            this.tbxKredit.Name = "tbxKredit";
            this.tbxKredit.Size = new System.Drawing.Size(100, 20);
            this.tbxKredit.TabIndex = 5;
            // 
            // tbxRänteSats
            // 
            this.tbxRänteSats.Location = new System.Drawing.Point(63, 65);
            this.tbxRänteSats.Name = "tbxRänteSats";
            this.tbxRänteSats.Size = new System.Drawing.Size(100, 20);
            this.tbxRänteSats.TabIndex = 4;
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.Location = new System.Drawing.Point(63, 36);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonNr.TabIndex = 3;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(6, 153);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(157, 23);
            this.btnRegistrera.TabIndex = 1;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // lblPersonNr
            // 
            this.lblPersonNr.AutoSize = true;
            this.lblPersonNr.Location = new System.Drawing.Point(6, 39);
            this.lblPersonNr.Name = "lblPersonNr";
            this.lblPersonNr.Size = new System.Drawing.Size(51, 13);
            this.lblPersonNr.TabIndex = 0;
            this.lblPersonNr.Text = "PersonNr";
            // 
            // lbxKonton
            // 
            this.lbxKonton.FormattingEnabled = true;
            this.lbxKonton.Location = new System.Drawing.Point(376, 17);
            this.lbxKonton.Name = "lbxKonton";
            this.lbxKonton.Size = new System.Drawing.Size(222, 186);
            this.lbxKonton.TabIndex = 4;
            // 
            // btnÅrsRänta
            // 
            this.btnÅrsRänta.Location = new System.Drawing.Point(376, 207);
            this.btnÅrsRänta.Name = "btnÅrsRänta";
            this.btnÅrsRänta.Size = new System.Drawing.Size(222, 23);
            this.btnÅrsRänta.TabIndex = 6;
            this.btnÅrsRänta.Text = "Uppdatera med årsränta";
            this.btnÅrsRänta.UseVisualStyleBackColor = true;
            this.btnÅrsRänta.Click += new System.EventHandler(this.btnÅrsRänta_Click);
            // 
            // formBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 242);
            this.Controls.Add(this.btnÅrsRänta);
            this.Controls.Add(this.lbxKonton);
            this.Controls.Add(this.gbxÖppnaKonto);
            this.Controls.Add(this.gbxInsättningUttag);
            this.Name = "formBank";
            this.Text = "Bank";
            this.gbxInsättningUttag.ResumeLayout(false);
            this.gbxInsättningUttag.PerformLayout();
            this.gbxÖppnaKonto.ResumeLayout(false);
            this.gbxÖppnaKonto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInsättningUttag;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.Button btnInsättning;
        private System.Windows.Forms.Label lblBelopp;
        private System.Windows.Forms.GroupBox gbxÖppnaKonto;
        private System.Windows.Forms.Label lblKredit;
        private System.Windows.Forms.Label lblRäntesats;
        private System.Windows.Forms.TextBox tbxKredit;
        private System.Windows.Forms.TextBox tbxRänteSats;
        private System.Windows.Forms.TextBox tbxPersonNr;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Label lblPersonNr;
        private System.Windows.Forms.ListBox lbxKonton;
        private System.Windows.Forms.Button btnÅrsRänta;
    }
}

