namespace GMAO_IIT.usercontrol
{
    partial class UserControl2
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMachineCode = new System.Windows.Forms.TextBox();
            this.txtMachineDesignation = new System.Windows.Forms.TextBox();
            this.cmbLocalisation = new System.Windows.Forms.ComboBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.cmbEtat = new System.Windows.Forms.ComboBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.dtpDateAcquisition = new System.Windows.Forms.DateTimePicker();
            this.dtpDateMiseEnService = new System.Windows.Forms.DateTimePicker();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.btnUpdateMachine = new System.Windows.Forms.Button();
            this.btnDeleteMachine = new System.Windows.Forms.Button();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Machines";
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Location = new System.Drawing.Point(20, 40);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.PlaceholderText = "Code";
            this.txtMachineCode.Size = new System.Drawing.Size(200, 23);
            this.txtMachineCode.TabIndex = 1;
            // 
            // txtMachineDesignation
            // 
            this.txtMachineDesignation.Location = new System.Drawing.Point(20, 70);
            this.txtMachineDesignation.Name = "txtMachineDesignation";
            this.txtMachineDesignation.PlaceholderText = "Designation";
            this.txtMachineDesignation.Size = new System.Drawing.Size(200, 23);
            this.txtMachineDesignation.TabIndex = 2;
            // 
            // cmbLocalisation
            // 
            this.cmbLocalisation.FormattingEnabled = true;
            this.cmbLocalisation.Items.AddRange(new object[] {
            "Atelier",
            "Laboratoire",
            "Stock"});
            this.cmbLocalisation.Location = new System.Drawing.Point(20, 100);
            this.cmbLocalisation.Name = "cmbLocalisation";
            this.cmbLocalisation.Size = new System.Drawing.Size(200, 23);
            this.cmbLocalisation.TabIndex = 3;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Location = new System.Drawing.Point(20, 130);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.PlaceholderText = "Numero de Série";
            this.txtNumeroSerie.Size = new System.Drawing.Size(200, 23);
            this.txtNumeroSerie.TabIndex = 4;
            // 
            // cmbEtat
            // 
            this.cmbEtat.FormattingEnabled = true;
            this.cmbEtat.Items.AddRange(new object[] {
            "Neuf",
            "Occasion",
            "En panne"});
            this.cmbEtat.Location = new System.Drawing.Point(20, 160);
            this.cmbEtat.Name = "cmbEtat";
            this.cmbEtat.Size = new System.Drawing.Size(200, 23);
            this.cmbEtat.TabIndex = 5;
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(20, 190);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.PlaceholderText = "Marque";
            this.txtMarque.Size = new System.Drawing.Size(200, 23);
            this.txtMarque.TabIndex = 6;
            // 
            // dtpDateAcquisition
            // 
            this.dtpDateAcquisition.Location = new System.Drawing.Point(20, 220);
            this.dtpDateAcquisition.Name = "dtpDateAcquisition";
            this.dtpDateAcquisition.Size = new System.Drawing.Size(200, 23);
            this.dtpDateAcquisition.TabIndex = 7;
            // 
            // dtpDateMiseEnService
            // 
            this.dtpDateMiseEnService.Location = new System.Drawing.Point(20, 250);
            this.dtpDateMiseEnService.Name = "dtpDateMiseEnService";
            this.dtpDateMiseEnService.Size = new System.Drawing.Size(200, 23);
            this.dtpDateMiseEnService.TabIndex = 8;
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Location = new System.Drawing.Point(20, 280);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(200, 23);
            this.btnAddMachine.TabIndex = 9;
            this.btnAddMachine.Text = "Ajouter Machine";
            this.btnAddMachine.UseVisualStyleBackColor = true;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // btnUpdateMachine
            // 
            this.btnUpdateMachine.Location = new System.Drawing.Point(20, 310);
            this.btnUpdateMachine.Name = "btnUpdateMachine";
            this.btnUpdateMachine.Size = new System.Drawing.Size(200, 23);
            this.btnUpdateMachine.TabIndex = 10;
            this.btnUpdateMachine.Text = "Mettre à jour Machine";
            this.btnUpdateMachine.UseVisualStyleBackColor = true;
            this.btnUpdateMachine.Click += new System.EventHandler(this.btnUpdateMachine_Click);
            // 
            // btnDeleteMachine
            // 
            this.btnDeleteMachine.Location = new System.Drawing.Point(20, 340);
            this.btnDeleteMachine.Name = "btnDeleteMachine";
            this.btnDeleteMachine.Size = new System.Drawing.Size(200, 23);
            this.btnDeleteMachine.TabIndex = 11;
            this.btnDeleteMachine.Text = "Supprimer Machine";
            this.btnDeleteMachine.UseVisualStyleBackColor = true;
            this.btnDeleteMachine.Click += new System.EventHandler(this.btnDeleteMachine_Click);
            // 
            // dgvMachines
            // 
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Location = new System.Drawing.Point(240, 40);
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.RowTemplate.Height = 25;
            this.dgvMachines.Size = new System.Drawing.Size(600, 320);
            this.dgvMachines.TabIndex = 12;
            this.dgvMachines.SelectionChanged += new System.EventHandler(this.dgvMachines_SelectionChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMachines);
            this.Controls.Add(this.btnDeleteMachine);
            this.Controls.Add(this.btnUpdateMachine);
            this.Controls.Add(this.btnAddMachine);
            this.Controls.Add(this.dtpDateMiseEnService);
            this.Controls.Add(this.dtpDateAcquisition);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.cmbEtat);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.cmbLocalisation);
            this.Controls.Add(this.txtMachineDesignation);
            this.Controls.Add(this.txtMachineCode);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(852, 382);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMachineCode;
        private TextBox txtMachineDesignation;
        private ComboBox cmbLocalisation;
        private TextBox txtNumeroSerie;
        private ComboBox cmbEtat;
        private TextBox txtMarque;
        private DateTimePicker dtpDateAcquisition;
        private DateTimePicker dtpDateMiseEnService;
        private Button btnAddMachine;
        private Button btnUpdateMachine;
        private Button btnDeleteMachine;
        private DataGridView dgvMachines;
    }
}
