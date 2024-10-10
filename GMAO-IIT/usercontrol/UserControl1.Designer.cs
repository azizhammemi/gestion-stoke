namespace GMAO_IIT.usercontrol
{
    partial class UserControl1
    {
        private System.ComponentModel.IContainer components = null;

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
            txtCode = new TextBox();
            txtDesignation = new TextBox();
            cmbFamille = new ComboBox();
            cmbUniteDeMesure = new ComboBox();
            chkMajore = new CheckBox();
            txtPrixHT = new TextBox();
            txtTVA = new TextBox();
            txtQuantiteEnStock = new TextBox();
            txtQuantiteStockMin = new TextBox();
            chkControleDeStock = new CheckBox();
            chkControleDeReservation = new CheckBox();
            btnAddArticle = new Button();
            dgvArticles = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(20, 20);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code";
            txtCode.Size = new Size(200, 23);
            txtCode.TabIndex = 0;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(20, 60);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.PlaceholderText = "Désignation";
            txtDesignation.Size = new Size(200, 23);
            txtDesignation.TabIndex = 1;
            // 
            // cmbFamille
            // 
            cmbFamille.FormattingEnabled = true;
            cmbFamille.Items.AddRange(new object[] { "Pièce de rechange", "Lubrifiant", "Consommable", "Divers" });
            cmbFamille.Location = new Point(20, 100);
            cmbFamille.Name = "cmbFamille";
            cmbFamille.Size = new Size(200, 23);
            cmbFamille.TabIndex = 2;
            cmbFamille.Text = "Famille";
            // 
            // cmbUniteDeMesure
            // 
            cmbUniteDeMesure.FormattingEnabled = true;
            cmbUniteDeMesure.Items.AddRange(new object[] { "Pièce", "Litre", "Kilogramme" });
            cmbUniteDeMesure.Location = new Point(20, 140);
            cmbUniteDeMesure.Name = "cmbUniteDeMesure";
            cmbUniteDeMesure.Size = new Size(200, 23);
            cmbUniteDeMesure.TabIndex = 3;
            cmbUniteDeMesure.Text = "Unité de Mesure";
            // 
            // chkMajore
            // 
            chkMajore.AutoSize = true;
            chkMajore.Location = new Point(20, 180);
            chkMajore.Name = "chkMajore";
            chkMajore.Size = new Size(63, 19);
            chkMajore.TabIndex = 4;
            chkMajore.Text = "Majoré";
            chkMajore.UseVisualStyleBackColor = true;
            // 
            // txtPrixHT
            // 
            txtPrixHT.Location = new Point(20, 220);
            txtPrixHT.Name = "txtPrixHT";
            txtPrixHT.PlaceholderText = "Prix HT";
            txtPrixHT.Size = new Size(200, 23);
            txtPrixHT.TabIndex = 5;
            // 
            // txtTVA
            // 
            txtTVA.Location = new Point(20, 260);
            txtTVA.Name = "txtTVA";
            txtTVA.PlaceholderText = "TVA";
            txtTVA.Size = new Size(200, 23);
            txtTVA.TabIndex = 6;
            // 
            // txtQuantiteEnStock
            // 
            txtQuantiteEnStock.Location = new Point(20, 300);
            txtQuantiteEnStock.Name = "txtQuantiteEnStock";
            txtQuantiteEnStock.PlaceholderText = "Quantité en Stock";
            txtQuantiteEnStock.Size = new Size(200, 23);
            txtQuantiteEnStock.TabIndex = 7;
            // 
            // txtQuantiteStockMin
            // 
            txtQuantiteStockMin.Location = new Point(20, 340);
            txtQuantiteStockMin.Name = "txtQuantiteStockMin";
            txtQuantiteStockMin.PlaceholderText = "Quantité Stock Min";
            txtQuantiteStockMin.Size = new Size(200, 23);
            txtQuantiteStockMin.TabIndex = 8;
            // 
            // chkControleDeStock
            // 
            chkControleDeStock.AutoSize = true;
            chkControleDeStock.Location = new Point(20, 380);
            chkControleDeStock.Name = "chkControleDeStock";
            chkControleDeStock.Size = new Size(120, 19);
            chkControleDeStock.TabIndex = 9;
            chkControleDeStock.Text = "Contrôle de Stock";
            chkControleDeStock.UseVisualStyleBackColor = true;
            // 
            // chkControleDeReservation
            // 
            chkControleDeReservation.AutoSize = true;
            chkControleDeReservation.Location = new Point(20, 420);
            chkControleDeReservation.Name = "chkControleDeReservation";
            chkControleDeReservation.Size = new Size(152, 19);
            chkControleDeReservation.TabIndex = 10;
            chkControleDeReservation.Text = "Contrôle de Réservation";
            chkControleDeReservation.UseVisualStyleBackColor = true;
            // 
            // btnAddArticle
            // 
            btnAddArticle.Location = new Point(20, 460);
            btnAddArticle.Name = "btnAddArticle";
            btnAddArticle.Size = new Size(200, 23);
            btnAddArticle.TabIndex = 11;
            btnAddArticle.Text = "Ajouter Article";
            btnAddArticle.UseVisualStyleBackColor = true;
            btnAddArticle.Click += btnAddArticle_Click;
            // 
            // dgvArticles
            // 
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Location = new Point(250, 20);
            dgvArticles.Name = "dgvArticles";
            dgvArticles.Size = new Size(676, 521);
            dgvArticles.TabIndex = 12;
            dgvArticles.SelectionChanged += dgvArticles_SelectionChanged;
            // 
            // button1
            // 
            button1.Location = new Point(20, 489);
            button1.Name = "button1";
            button1.Size = new Size(200, 23);
            button1.TabIndex = 13;
            button1.Text = "mise a jour article";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 518);
            button2.Name = "button2";
            button2.Size = new Size(200, 23);
            button2.TabIndex = 14;
            button2.Text = "delete Article";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvArticles);
            Controls.Add(btnAddArticle);
            Controls.Add(chkControleDeReservation);
            Controls.Add(chkControleDeStock);
            Controls.Add(txtQuantiteStockMin);
            Controls.Add(txtQuantiteEnStock);
            Controls.Add(txtTVA);
            Controls.Add(txtPrixHT);
            Controls.Add(chkMajore);
            Controls.Add(cmbUniteDeMesure);
            Controls.Add(cmbFamille);
            Controls.Add(txtDesignation);
            Controls.Add(txtCode);
            Name = "UserControl1";
            Size = new Size(940, 569);
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.ComboBox cmbUniteDeMesure;
        private System.Windows.Forms.CheckBox chkMajore;
        private System.Windows.Forms.TextBox txtPrixHT;
        private System.Windows.Forms.TextBox txtTVA;
        private System.Windows.Forms.TextBox txtQuantiteEnStock;
        private System.Windows.Forms.TextBox txtQuantiteStockMin;
        private System.Windows.Forms.CheckBox chkControleDeStock;
        private System.Windows.Forms.CheckBox chkControleDeReservation;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.DataGridView dgvArticles;
        private Button button1;
        private Button button2;
    }
}
