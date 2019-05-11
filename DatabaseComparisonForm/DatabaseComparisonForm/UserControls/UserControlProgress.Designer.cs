namespace DatabaseComparisonForm.UserControls
{
    partial class UserControlProgress
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
            this.groupBoxElements = new System.Windows.Forms.GroupBox();
            this.labelCompletion = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxRelationships = new System.Windows.Forms.CheckBox();
            this.checkBoxConstraints = new System.Windows.Forms.CheckBox();
            this.checkBoxIndexes = new System.Windows.Forms.CheckBox();
            this.checkBoxTriggers = new System.Windows.Forms.CheckBox();
            this.checkBoxViews = new System.Windows.Forms.CheckBox();
            this.checkBoxColumns = new System.Windows.Forms.CheckBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBoxElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxElements
            // 
            this.groupBoxElements.Controls.Add(this.labelCompletion);
            this.groupBoxElements.Controls.Add(this.buttonCancel);
            this.groupBoxElements.Controls.Add(this.checkBoxRelationships);
            this.groupBoxElements.Controls.Add(this.checkBoxConstraints);
            this.groupBoxElements.Controls.Add(this.checkBoxIndexes);
            this.groupBoxElements.Controls.Add(this.checkBoxTriggers);
            this.groupBoxElements.Controls.Add(this.checkBoxViews);
            this.groupBoxElements.Controls.Add(this.checkBoxColumns);
            this.groupBoxElements.Controls.Add(this.buttonNext);
            this.groupBoxElements.Controls.Add(this.buttonStart);
            this.groupBoxElements.Location = new System.Drawing.Point(3, 3);
            this.groupBoxElements.Name = "groupBoxElements";
            this.groupBoxElements.Size = new System.Drawing.Size(492, 242);
            this.groupBoxElements.TabIndex = 0;
            this.groupBoxElements.TabStop = false;
            this.groupBoxElements.Text = "Elements of comparison";
            // 
            // labelCompletion
            // 
            this.labelCompletion.AutoSize = true;
            this.labelCompletion.Location = new System.Drawing.Point(6, 219);
            this.labelCompletion.Name = "labelCompletion";
            this.labelCompletion.Size = new System.Drawing.Size(45, 13);
            this.labelCompletion.TabIndex = 8;
            this.labelCompletion.Text = "Complet";
            this.labelCompletion.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(348, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(239, 214);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // checkBoxRelationships
            // 
            this.checkBoxRelationships.AutoSize = true;
            this.checkBoxRelationships.Location = new System.Drawing.Point(6, 134);
            this.checkBoxRelationships.Name = "checkBoxRelationships";
            this.checkBoxRelationships.Size = new System.Drawing.Size(89, 17);
            this.checkBoxRelationships.TabIndex = 5;
            this.checkBoxRelationships.Text = "Relationships";
            this.checkBoxRelationships.UseVisualStyleBackColor = true;
            // 
            // checkBoxConstraints
            // 
            this.checkBoxConstraints.AutoSize = true;
            this.checkBoxConstraints.Location = new System.Drawing.Point(6, 111);
            this.checkBoxConstraints.Name = "checkBoxConstraints";
            this.checkBoxConstraints.Size = new System.Drawing.Size(78, 17);
            this.checkBoxConstraints.TabIndex = 4;
            this.checkBoxConstraints.Text = "Constraints";
            this.checkBoxConstraints.UseVisualStyleBackColor = true;
            // 
            // checkBoxIndexes
            // 
            this.checkBoxIndexes.AutoSize = true;
            this.checkBoxIndexes.Location = new System.Drawing.Point(6, 88);
            this.checkBoxIndexes.Name = "checkBoxIndexes";
            this.checkBoxIndexes.Size = new System.Drawing.Size(63, 17);
            this.checkBoxIndexes.TabIndex = 3;
            this.checkBoxIndexes.Text = "Indexes";
            this.checkBoxIndexes.UseVisualStyleBackColor = true;
            // 
            // checkBoxTriggers
            // 
            this.checkBoxTriggers.AutoSize = true;
            this.checkBoxTriggers.Location = new System.Drawing.Point(6, 65);
            this.checkBoxTriggers.Name = "checkBoxTriggers";
            this.checkBoxTriggers.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTriggers.TabIndex = 2;
            this.checkBoxTriggers.Text = "Triggers";
            this.checkBoxTriggers.UseVisualStyleBackColor = true;
            // 
            // checkBoxViews
            // 
            this.checkBoxViews.AutoSize = true;
            this.checkBoxViews.Location = new System.Drawing.Point(6, 42);
            this.checkBoxViews.Name = "checkBoxViews";
            this.checkBoxViews.Size = new System.Drawing.Size(54, 17);
            this.checkBoxViews.TabIndex = 1;
            this.checkBoxViews.Text = "Views";
            this.checkBoxViews.UseVisualStyleBackColor = true;
            // 
            // checkBoxColumns
            // 
            this.checkBoxColumns.AutoSize = true;
            this.checkBoxColumns.Location = new System.Drawing.Point(6, 19);
            this.checkBoxColumns.Name = "checkBoxColumns";
            this.checkBoxColumns.Size = new System.Drawing.Size(109, 17);
            this.checkBoxColumns.TabIndex = 0;
            this.checkBoxColumns.Text = "Tables / Columns";
            this.checkBoxColumns.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(239, 214);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // UserControlProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxElements);
            this.Name = "UserControlProgress";
            this.Size = new System.Drawing.Size(498, 251);
            this.groupBoxElements.ResumeLayout(false);
            this.groupBoxElements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxElements;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxRelationships;
        private System.Windows.Forms.CheckBox checkBoxConstraints;
        private System.Windows.Forms.CheckBox checkBoxIndexes;
        private System.Windows.Forms.CheckBox checkBoxTriggers;
        private System.Windows.Forms.CheckBox checkBoxViews;
        private System.Windows.Forms.CheckBox checkBoxColumns;
        private System.Windows.Forms.Label labelCompletion;
        private System.Windows.Forms.Button buttonNext;
    }
}
