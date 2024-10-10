namespace GMAO_IIT.usercontrol
{
    partial class UserControl3
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

        #region Designer generated code

        private void InitializeComponent()
        {
            lblNumeroDemandeIntervention = new Label();
            txtNumeroDemandeIntervention = new TextBox();
            lblDateIntervention = new Label();
            dtpDateIntervention = new DateTimePicker();
            lblCodeMachine = new Label();
            cmbCodeMachine = new ComboBox();
            lblDescriptionIntervention = new Label();
            txtDescriptionIntervention = new TextBox();
            lblEtape = new Label();
            cmbEtape = new ComboBox();
            btnAddIntervention = new Button();
            dgvInterventions = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInterventions).BeginInit();
            SuspendLayout();
            // 
            // lblNumeroDemandeIntervention
            // 
            lblNumeroDemandeIntervention.AutoSize = true;
            lblNumeroDemandeIntervention.Location = new Point(20, 20);
            lblNumeroDemandeIntervention.Name = "lblNumeroDemandeIntervention";
            lblNumeroDemandeIntervention.Size = new Size(172, 15);
            lblNumeroDemandeIntervention.TabIndex = 0;
            lblNumeroDemandeIntervention.Text = "Numéro Demande Intervention";
            // 
            // txtNumeroDemandeIntervention
            // 
            txtNumeroDemandeIntervention.Location = new Point(220, 17);
            txtNumeroDemandeIntervention.Name = "txtNumeroDemandeIntervention";
            txtNumeroDemandeIntervention.Size = new Size(150, 23);
            txtNumeroDemandeIntervention.TabIndex = 1;
            // 
            // lblDateIntervention
            // 
            lblDateIntervention.AutoSize = true;
            lblDateIntervention.Location = new Point(20, 50);
            lblDateIntervention.Name = "lblDateIntervention";
            lblDateIntervention.Size = new Size(98, 15);
            lblDateIntervention.TabIndex = 2;
            lblDateIntervention.Text = "Date Intervention";
            // 
            // dtpDateIntervention
            // 
            dtpDateIntervention.Location = new Point(220, 47);
            dtpDateIntervention.Name = "dtpDateIntervention";
            dtpDateIntervention.Size = new Size(200, 23);
            dtpDateIntervention.TabIndex = 3;
            // 
            // lblCodeMachine
            // 
            lblCodeMachine.AutoSize = true;
            lblCodeMachine.Location = new Point(20, 80);
            lblCodeMachine.Name = "lblCodeMachine";
            lblCodeMachine.Size = new Size(84, 15);
            lblCodeMachine.TabIndex = 4;
            lblCodeMachine.Text = "Code Machine";
            // 
            // cmbCodeMachine
            // 
            cmbCodeMachine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCodeMachine.FormattingEnabled = true;
            cmbCodeMachine.Location = new Point(220, 77);
            cmbCodeMachine.Name = "cmbCodeMachine";
            cmbCodeMachine.Size = new Size(150, 23);
            cmbCodeMachine.TabIndex = 5;
            // 
            // lblDescriptionIntervention
            // 
            lblDescriptionIntervention.AutoSize = true;
            lblDescriptionIntervention.Location = new Point(20, 110);
            lblDescriptionIntervention.Name = "lblDescriptionIntervention";
            lblDescriptionIntervention.Size = new Size(134, 15);
            lblDescriptionIntervention.TabIndex = 6;
            lblDescriptionIntervention.Text = "Description Intervention";
            // 
            // txtDescriptionIntervention
            // 
            txtDescriptionIntervention.Location = new Point(220, 107);
            txtDescriptionIntervention.Multiline = true;
            txtDescriptionIntervention.Name = "txtDescriptionIntervention";
            txtDescriptionIntervention.Size = new Size(250, 100);
            txtDescriptionIntervention.TabIndex = 7;
            // 
            // lblEtape
            // 
            lblEtape.AutoSize = true;
            lblEtape.Location = new Point(20, 220);
            lblEtape.Name = "lblEtape";
            lblEtape.Size = new Size(36, 15);
            lblEtape.TabIndex = 8;
            lblEtape.Text = "Etape";
            // 
            // cmbEtape
            // 
            cmbEtape.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEtape.FormattingEnabled = true;
            cmbEtape.Items.AddRange(new object[] { "En attente", "En cours", "Achevée" });
            cmbEtape.Location = new Point(220, 217);
            cmbEtape.Name = "cmbEtape";
            cmbEtape.Size = new Size(150, 23);
            cmbEtape.TabIndex = 9;
            // 
            // btnAddIntervention
            // 
            btnAddIntervention.Location = new Point(23, 260);
            btnAddIntervention.Name = "btnAddIntervention";
            btnAddIntervention.Size = new Size(100, 30);
            btnAddIntervention.TabIndex = 10;
            btnAddIntervention.Text = "Ajouter";
            btnAddIntervention.UseVisualStyleBackColor = true;
            btnAddIntervention.Click += btnAddIntervention_Click;
            // 
            // dgvInterventions
            // 
            dgvInterventions.AllowUserToAddRows = false;
            dgvInterventions.AllowUserToDeleteRows = false;
            dgvInterventions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInterventions.Location = new Point(20, 300);
            dgvInterventions.MultiSelect = false;
            dgvInterventions.Name = "dgvInterventions";
            dgvInterventions.ReadOnly = true;
            dgvInterventions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInterventions.Size = new Size(800, 150);
            dgvInterventions.TabIndex = 11;
            dgvInterventions.SelectionChanged += dgvInterventions_SelectionChanged;
            // 
            // button1
            // 
            button1.Location = new Point(129, 260);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 12;
            button1.Text = "update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(257, 260);
            button2.Name = "button2";
            button2.Size = new Size(102, 30);
            button2.TabIndex = 13;
            button2.Text = "supprimer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(395, 76);
            button3.Name = "button3";
            button3.Size = new Size(84, 24);
            button3.TabIndex = 14;
            button3.Text = "refrash";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvInterventions);
            Controls.Add(btnAddIntervention);
            Controls.Add(cmbEtape);
            Controls.Add(lblEtape);
            Controls.Add(txtDescriptionIntervention);
            Controls.Add(lblDescriptionIntervention);
            Controls.Add(cmbCodeMachine);
            Controls.Add(lblCodeMachine);
            Controls.Add(dtpDateIntervention);
            Controls.Add(lblDateIntervention);
            Controls.Add(txtNumeroDemandeIntervention);
            Controls.Add(lblNumeroDemandeIntervention);
            Name = "UserControl3";
            Size = new Size(863, 371);
            ((System.ComponentModel.ISupportInitialize)dgvInterventions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNumeroDemandeIntervention;
        private TextBox txtNumeroDemandeIntervention;
        private Label lblDateIntervention;
        private DateTimePicker dtpDateIntervention;
        private Label lblCodeMachine;
        private ComboBox cmbCodeMachine; // Changed from TextBox to ComboBox
        private Label lblDescriptionIntervention;
        private TextBox txtDescriptionIntervention;
        private Label lblEtape;
        private ComboBox cmbEtape;
        private Button btnAddIntervention;
        private DataGridView dgvInterventions;

        #endregion // Designer generated code

        private Button button1;
        private Button button2;
        private Button button3;
    }
}
