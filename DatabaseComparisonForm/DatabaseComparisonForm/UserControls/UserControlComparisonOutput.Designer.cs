namespace DatabaseComparisonForm.UserControls
{
    partial class UserControlComparisonOutput
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonUnloadToXML = new System.Windows.Forms.Button();
            this.dataGridViewColumns = new System.Windows.Forms.DataGridView();
            this.tabControlComparison = new System.Windows.Forms.TabControl();
            this.tabPageColumns = new System.Windows.Forms.TabPage();
            this.tabPageViews = new System.Windows.Forms.TabPage();
            this.dataGridViewViews = new System.Windows.Forms.DataGridView();
            this.tabPageTriggers = new System.Windows.Forms.TabPage();
            this.dataGridViewTriggers = new System.Windows.Forms.DataGridView();
            this.tabPageIndexes = new System.Windows.Forms.TabPage();
            this.dataGridViewIndexes = new System.Windows.Forms.DataGridView();
            this.tabPageConstraints = new System.Windows.Forms.TabPage();
            this.dataGridViewConstraints = new System.Windows.Forms.DataGridView();
            this.tabPageRelationships = new System.Windows.Forms.TabPage();
            this.dataGridViewRelationships = new System.Windows.Forms.DataGridView();
            this.comboBoxUnloadDatabase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).BeginInit();
            this.tabControlComparison.SuspendLayout();
            this.tabPageColumns.SuspendLayout();
            this.tabPageViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViews)).BeginInit();
            this.tabPageTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTriggers)).BeginInit();
            this.tabPageIndexes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndexes)).BeginInit();
            this.tabPageConstraints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConstraints)).BeginInit();
            this.tabPageRelationships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelationships)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(3, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // buttonUnloadToXML
            // 
            this.buttonUnloadToXML.Location = new System.Drawing.Point(221, 3);
            this.buttonUnloadToXML.Name = "buttonUnloadToXML";
            this.buttonUnloadToXML.Size = new System.Drawing.Size(106, 23);
            this.buttonUnloadToXML.TabIndex = 1;
            this.buttonUnloadToXML.Text = "Unload to xml";
            this.buttonUnloadToXML.UseVisualStyleBackColor = true;
            this.buttonUnloadToXML.Click += new System.EventHandler(this.ButtonUnloadToXML_Click);
            // 
            // dataGridViewColumns
            // 
            this.dataGridViewColumns.AllowUserToAddRows = false;
            this.dataGridViewColumns.AllowUserToDeleteRows = false;
            this.dataGridViewColumns.AllowUserToResizeRows = false;
            this.dataGridViewColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColumns.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewColumns.Name = "dataGridViewColumns";
            this.dataGridViewColumns.Size = new System.Drawing.Size(532, 291);
            this.dataGridViewColumns.TabIndex = 2;
            // 
            // tabControlComparison
            // 
            this.tabControlComparison.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlComparison.Controls.Add(this.tabPageColumns);
            this.tabControlComparison.Controls.Add(this.tabPageViews);
            this.tabControlComparison.Controls.Add(this.tabPageTriggers);
            this.tabControlComparison.Controls.Add(this.tabPageIndexes);
            this.tabControlComparison.Controls.Add(this.tabPageConstraints);
            this.tabControlComparison.Controls.Add(this.tabPageRelationships);
            this.tabControlComparison.Location = new System.Drawing.Point(3, 32);
            this.tabControlComparison.Name = "tabControlComparison";
            this.tabControlComparison.SelectedIndex = 0;
            this.tabControlComparison.Size = new System.Drawing.Size(546, 323);
            this.tabControlComparison.TabIndex = 3;
            // 
            // tabPageColumns
            // 
            this.tabPageColumns.Controls.Add(this.dataGridViewColumns);
            this.tabPageColumns.Location = new System.Drawing.Point(4, 4);
            this.tabPageColumns.Name = "tabPageColumns";
            this.tabPageColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageColumns.Size = new System.Drawing.Size(538, 297);
            this.tabPageColumns.TabIndex = 0;
            this.tabPageColumns.Text = "Columns";
            this.tabPageColumns.UseVisualStyleBackColor = true;
            // 
            // tabPageViews
            // 
            this.tabPageViews.Controls.Add(this.dataGridViewViews);
            this.tabPageViews.Location = new System.Drawing.Point(4, 4);
            this.tabPageViews.Name = "tabPageViews";
            this.tabPageViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViews.Size = new System.Drawing.Size(538, 297);
            this.tabPageViews.TabIndex = 1;
            this.tabPageViews.Text = "Views";
            this.tabPageViews.UseVisualStyleBackColor = true;
            // 
            // dataGridViewViews
            // 
            this.dataGridViewViews.AllowUserToAddRows = false;
            this.dataGridViewViews.AllowUserToDeleteRows = false;
            this.dataGridViewViews.AllowUserToResizeRows = false;
            this.dataGridViewViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViews.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewViews.Name = "dataGridViewViews";
            this.dataGridViewViews.Size = new System.Drawing.Size(532, 291);
            this.dataGridViewViews.TabIndex = 3;
            // 
            // tabPageTriggers
            // 
            this.tabPageTriggers.Controls.Add(this.dataGridViewTriggers);
            this.tabPageTriggers.Location = new System.Drawing.Point(4, 4);
            this.tabPageTriggers.Name = "tabPageTriggers";
            this.tabPageTriggers.Size = new System.Drawing.Size(538, 297);
            this.tabPageTriggers.TabIndex = 2;
            this.tabPageTriggers.Text = "Triggers";
            this.tabPageTriggers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTriggers
            // 
            this.dataGridViewTriggers.AllowUserToAddRows = false;
            this.dataGridViewTriggers.AllowUserToDeleteRows = false;
            this.dataGridViewTriggers.AllowUserToResizeRows = false;
            this.dataGridViewTriggers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTriggers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTriggers.Name = "dataGridViewTriggers";
            this.dataGridViewTriggers.Size = new System.Drawing.Size(532, 291);
            this.dataGridViewTriggers.TabIndex = 3;
            // 
            // tabPageIndexes
            // 
            this.tabPageIndexes.Controls.Add(this.dataGridViewIndexes);
            this.tabPageIndexes.Location = new System.Drawing.Point(4, 4);
            this.tabPageIndexes.Name = "tabPageIndexes";
            this.tabPageIndexes.Size = new System.Drawing.Size(538, 297);
            this.tabPageIndexes.TabIndex = 3;
            this.tabPageIndexes.Text = "Indexes";
            this.tabPageIndexes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIndexes
            // 
            this.dataGridViewIndexes.AllowUserToAddRows = false;
            this.dataGridViewIndexes.AllowUserToDeleteRows = false;
            this.dataGridViewIndexes.AllowUserToResizeRows = false;
            this.dataGridViewIndexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndexes.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewIndexes.Name = "dataGridViewIndexes";
            this.dataGridViewIndexes.Size = new System.Drawing.Size(532, 291);
            this.dataGridViewIndexes.TabIndex = 3;
            // 
            // tabPageConstraints
            // 
            this.tabPageConstraints.Controls.Add(this.dataGridViewConstraints);
            this.tabPageConstraints.Location = new System.Drawing.Point(4, 4);
            this.tabPageConstraints.Name = "tabPageConstraints";
            this.tabPageConstraints.Size = new System.Drawing.Size(538, 297);
            this.tabPageConstraints.TabIndex = 4;
            this.tabPageConstraints.Text = "Constraints";
            this.tabPageConstraints.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConstraints
            // 
            this.dataGridViewConstraints.AllowUserToAddRows = false;
            this.dataGridViewConstraints.AllowUserToDeleteRows = false;
            this.dataGridViewConstraints.AllowUserToResizeRows = false;
            this.dataGridViewConstraints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConstraints.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewConstraints.Name = "dataGridViewConstraints";
            this.dataGridViewConstraints.Size = new System.Drawing.Size(532, 291);
            this.dataGridViewConstraints.TabIndex = 3;
            // 
            // tabPageRelationships
            // 
            this.tabPageRelationships.Controls.Add(this.dataGridViewRelationships);
            this.tabPageRelationships.Location = new System.Drawing.Point(4, 4);
            this.tabPageRelationships.Name = "tabPageRelationships";
            this.tabPageRelationships.Size = new System.Drawing.Size(538, 297);
            this.tabPageRelationships.TabIndex = 5;
            this.tabPageRelationships.Text = "Relationships";
            this.tabPageRelationships.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRelationships
            // 
            this.dataGridViewRelationships.AllowUserToAddRows = false;
            this.dataGridViewRelationships.AllowUserToDeleteRows = false;
            this.dataGridViewRelationships.AllowUserToResizeRows = false;
            this.dataGridViewRelationships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelationships.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRelationships.Name = "dataGridViewRelationships";
            this.dataGridViewRelationships.Size = new System.Drawing.Size(532, 291);
            this.dataGridViewRelationships.TabIndex = 3;
            // 
            // comboBoxUnloadDatabase
            // 
            this.comboBoxUnloadDatabase.FormattingEnabled = true;
            this.comboBoxUnloadDatabase.Location = new System.Drawing.Point(333, 5);
            this.comboBoxUnloadDatabase.Name = "comboBoxUnloadDatabase";
            this.comboBoxUnloadDatabase.Size = new System.Drawing.Size(212, 21);
            this.comboBoxUnloadDatabase.TabIndex = 4;
            // 
            // UserControlComparisonOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxUnloadDatabase);
            this.Controls.Add(this.tabControlComparison);
            this.Controls.Add(this.buttonUnloadToXML);
            this.Controls.Add(this.buttonConnect);
            this.Name = "UserControlComparisonOutput";
            this.Size = new System.Drawing.Size(552, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).EndInit();
            this.tabControlComparison.ResumeLayout(false);
            this.tabPageColumns.ResumeLayout(false);
            this.tabPageViews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViews)).EndInit();
            this.tabPageTriggers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTriggers)).EndInit();
            this.tabPageIndexes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndexes)).EndInit();
            this.tabPageConstraints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConstraints)).EndInit();
            this.tabPageRelationships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelationships)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonUnloadToXML;
        private System.Windows.Forms.DataGridView dataGridViewColumns;
        private System.Windows.Forms.TabControl tabControlComparison;
        private System.Windows.Forms.TabPage tabPageColumns;
        private System.Windows.Forms.TabPage tabPageViews;
        private System.Windows.Forms.DataGridView dataGridViewViews;
        private System.Windows.Forms.TabPage tabPageTriggers;
        private System.Windows.Forms.DataGridView dataGridViewTriggers;
        private System.Windows.Forms.TabPage tabPageIndexes;
        private System.Windows.Forms.DataGridView dataGridViewIndexes;
        private System.Windows.Forms.TabPage tabPageConstraints;
        private System.Windows.Forms.DataGridView dataGridViewConstraints;
        private System.Windows.Forms.TabPage tabPageRelationships;
        private System.Windows.Forms.DataGridView dataGridViewRelationships;
        private System.Windows.Forms.ComboBox comboBoxUnloadDatabase;
    }
}
