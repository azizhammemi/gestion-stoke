namespace GMAO_IIT.usercontrol
{
    partial class UserControl4
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

        #region Code généré par le Concepteur de composants

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewInterventions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterventions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interventions";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(150, 50);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(450, 50);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(150, 30);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(30, 15);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Start";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(450, 30);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(27, 15);
            this.labelEnd.TabIndex = 4;
            this.labelEnd.Text = "End";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(150, 100);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(200, 23);
            this.textBoxCode.TabIndex = 5;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(150, 80);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(35, 15);
            this.labelCode.TabIndex = 6;
            this.labelCode.Text = "Code";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(450, 100);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(200, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewInterventions
            // 
            this.dataGridViewInterventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInterventions.Location = new System.Drawing.Point(50, 150);
            this.dataGridViewInterventions.Name = "dataGridViewInterventions";
            this.dataGridViewInterventions.RowTemplate.Height = 25;
            this.dataGridViewInterventions.Size = new System.Drawing.Size(700, 200);
            this.dataGridViewInterventions.TabIndex = 8;
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewInterventions);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(837, 366);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterventions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label labelStart;
        private Label labelEnd;
        private TextBox textBoxCode;
        private Label labelCode;
        private Button buttonSearch;
        private DataGridView dataGridViewInterventions;
    }
}
