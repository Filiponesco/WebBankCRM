namespace BankCRM
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxImie = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxNazwisko = new System.Windows.Forms.TextBox();
            this.txtBoxPesel = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.btnZaktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnWYczysc = new System.Windows.Forms.Button();
            this.bankcrmDataSet = new BankCRM.bankcrmDataSet();
            this.bankcrmDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new BankCRM.bankcrmDataSetTableAdapters.klienciTableAdapter();
            this.klienciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankcrmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankcrmDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 289);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 278);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(61, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Imię: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(-3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nazwisko: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "E-mail: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefon: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(26, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pesel: ";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(82, 12);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(147, 20);
            this.txtBoxId.TabIndex = 23;
            // 
            // txtBoxImie
            // 
            this.txtBoxImie.Location = new System.Drawing.Point(82, 50);
            this.txtBoxImie.Name = "txtBoxImie";
            this.txtBoxImie.Size = new System.Drawing.Size(147, 20);
            this.txtBoxImie.TabIndex = 24;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(82, 130);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(147, 20);
            this.txtBoxEmail.TabIndex = 26;
            // 
            // txtBoxNazwisko
            // 
            this.txtBoxNazwisko.Location = new System.Drawing.Point(82, 88);
            this.txtBoxNazwisko.Name = "txtBoxNazwisko";
            this.txtBoxNazwisko.Size = new System.Drawing.Size(147, 20);
            this.txtBoxNazwisko.TabIndex = 25;
            // 
            // txtBoxPesel
            // 
            this.txtBoxPesel.Location = new System.Drawing.Point(82, 213);
            this.txtBoxPesel.Name = "txtBoxPesel";
            this.txtBoxPesel.Size = new System.Drawing.Size(147, 20);
            this.txtBoxPesel.TabIndex = 28;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(82, 172);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(147, 20);
            this.txtBoxTel.TabIndex = 27;
            // 
            // btnZaktualizuj
            // 
            this.btnZaktualizuj.Location = new System.Drawing.Point(82, 278);
            this.btnZaktualizuj.Name = "btnZaktualizuj";
            this.btnZaktualizuj.Size = new System.Drawing.Size(86, 23);
            this.btnZaktualizuj.TabIndex = 29;
            this.btnZaktualizuj.Text = "Zaktualizuj";
            this.btnZaktualizuj.UseVisualStyleBackColor = true;
            this.btnZaktualizuj.Click += new System.EventHandler(this.btnZaktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(178, 278);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(55, 23);
            this.btnUsun.TabIndex = 30;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnWYczysc
            // 
            this.btnWYczysc.Location = new System.Drawing.Point(12, 249);
            this.btnWYczysc.Name = "btnWYczysc";
            this.btnWYczysc.Size = new System.Drawing.Size(221, 23);
            this.btnWYczysc.TabIndex = 31;
            this.btnWYczysc.Text = "Wyczyść";
            this.btnWYczysc.UseVisualStyleBackColor = true;
            this.btnWYczysc.Click += new System.EventHandler(this.btnWYczysc_Click);
            // 
            // bankcrmDataSet
            // 
            this.bankcrmDataSet.DataSetName = "bankcrmDataSet";
            this.bankcrmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankcrmDataSetBindingSource
            // 
            this.bankcrmDataSetBindingSource.DataSource = this.bankcrmDataSet;
            this.bankcrmDataSetBindingSource.Position = 0;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "klienci";
            this.klienciBindingSource.DataSource = this.bankcrmDataSetBindingSource;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // klienciBindingSource1
            // 
            this.klienciBindingSource1.DataMember = "klienci";
            this.klienciBindingSource1.DataSource = this.bankcrmDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 317);
            this.Controls.Add(this.btnWYczysc);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZaktualizuj);
            this.Controls.Add(this.txtBoxPesel);
            this.Controls.Add(this.txtBoxTel);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxNazwisko);
            this.Controls.Add(this.txtBoxImie);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Bank CRM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankcrmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankcrmDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxImie;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxNazwisko;
        private System.Windows.Forms.TextBox txtBoxPesel;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.Button btnZaktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnWYczysc;
        private System.Windows.Forms.BindingSource bankcrmDataSetBindingSource;
        private bankcrmDataSet bankcrmDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private bankcrmDataSetTableAdapters.klienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.BindingSource klienciBindingSource1;
    }
}

