namespace DatabaseComparisonForm.UserControls
{
    partial class UserControlConnect
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
            this.labelDatabaseSourse = new System.Windows.Forms.Label();
            this.groupBoxConnectSourseDatabase = new System.Windows.Forms.GroupBox();
            this.buttonConnectTestSourse = new System.Windows.Forms.Button();
            this.buttonFindSourseDatabase = new System.Windows.Forms.Button();
            this.textBoxSourseDatabase = new System.Windows.Forms.TextBox();
            this.groupBoxConnectTargetDatabase = new System.Windows.Forms.GroupBox();
            this.buttonConnectTestTarget = new System.Windows.Forms.Button();
            this.buttonFindTargetDatabase = new System.Windows.Forms.Button();
            this.textBoxTargetDatabase = new System.Windows.Forms.TextBox();
            this.labelDatabaseTarget = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBoxConnectSourseDatabase.SuspendLayout();
            this.groupBoxConnectTargetDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDatabaseSourse
            // 
            this.labelDatabaseSourse.AutoSize = true;
            this.labelDatabaseSourse.Location = new System.Drawing.Point(6, 22);
            this.labelDatabaseSourse.Name = "labelDatabaseSourse";
            this.labelDatabaseSourse.Size = new System.Drawing.Size(56, 13);
            this.labelDatabaseSourse.TabIndex = 0;
            this.labelDatabaseSourse.Text = "Database:";
            // 
            // groupBoxConnectSourseDatabase
            // 
            this.groupBoxConnectSourseDatabase.Controls.Add(this.buttonConnectTestSourse);
            this.groupBoxConnectSourseDatabase.Controls.Add(this.buttonFindSourseDatabase);
            this.groupBoxConnectSourseDatabase.Controls.Add(this.textBoxSourseDatabase);
            this.groupBoxConnectSourseDatabase.Controls.Add(this.labelDatabaseSourse);
            this.groupBoxConnectSourseDatabase.Location = new System.Drawing.Point(3, 3);
            this.groupBoxConnectSourseDatabase.Name = "groupBoxConnectSourseDatabase";
            this.groupBoxConnectSourseDatabase.Size = new System.Drawing.Size(234, 100);
            this.groupBoxConnectSourseDatabase.TabIndex = 1;
            this.groupBoxConnectSourseDatabase.TabStop = false;
            this.groupBoxConnectSourseDatabase.Text = "Sourse connection";
            // 
            // buttonConnectTestSourse
            // 
            this.buttonConnectTestSourse.Location = new System.Drawing.Point(68, 61);
            this.buttonConnectTestSourse.Name = "buttonConnectTestSourse";
            this.buttonConnectTestSourse.Size = new System.Drawing.Size(142, 23);
            this.buttonConnectTestSourse.TabIndex = 3;
            this.buttonConnectTestSourse.Text = "Test connection";
            this.buttonConnectTestSourse.UseVisualStyleBackColor = true;
            this.buttonConnectTestSourse.Click += new System.EventHandler(this.ButtonConnectTestSourse_Click);
            // 
            // buttonFindSourseDatabase
            // 
            this.buttonFindSourseDatabase.Location = new System.Drawing.Point(176, 17);
            this.buttonFindSourseDatabase.Name = "buttonFindSourseDatabase";
            this.buttonFindSourseDatabase.Size = new System.Drawing.Size(48, 23);
            this.buttonFindSourseDatabase.TabIndex = 2;
            this.buttonFindSourseDatabase.Text = "Find";
            this.buttonFindSourseDatabase.UseVisualStyleBackColor = true;
            this.buttonFindSourseDatabase.Click += new System.EventHandler(this.ButtonFindSourseDatabase_Click);
            // 
            // textBoxSourseDatabase
            // 
            this.textBoxSourseDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSourseDatabase.Location = new System.Drawing.Point(68, 19);
            this.textBoxSourseDatabase.Name = "textBoxSourseDatabase";
            this.textBoxSourseDatabase.Size = new System.Drawing.Size(102, 20);
            this.textBoxSourseDatabase.TabIndex = 1;
            // 
            // groupBoxConnectTargetDatabase
            // 
            this.groupBoxConnectTargetDatabase.Controls.Add(this.buttonConnectTestTarget);
            this.groupBoxConnectTargetDatabase.Controls.Add(this.buttonFindTargetDatabase);
            this.groupBoxConnectTargetDatabase.Controls.Add(this.textBoxTargetDatabase);
            this.groupBoxConnectTargetDatabase.Controls.Add(this.labelDatabaseTarget);
            this.groupBoxConnectTargetDatabase.Location = new System.Drawing.Point(243, 3);
            this.groupBoxConnectTargetDatabase.Name = "groupBoxConnectTargetDatabase";
            this.groupBoxConnectTargetDatabase.Size = new System.Drawing.Size(234, 100);
            this.groupBoxConnectTargetDatabase.TabIndex = 2;
            this.groupBoxConnectTargetDatabase.TabStop = false;
            this.groupBoxConnectTargetDatabase.Text = "Target connection";
            // 
            // buttonConnectTestTarget
            // 
            this.buttonConnectTestTarget.Location = new System.Drawing.Point(68, 61);
            this.buttonConnectTestTarget.Name = "buttonConnectTestTarget";
            this.buttonConnectTestTarget.Size = new System.Drawing.Size(142, 23);
            this.buttonConnectTestTarget.TabIndex = 3;
            this.buttonConnectTestTarget.Text = "Test connection";
            this.buttonConnectTestTarget.UseVisualStyleBackColor = true;
            this.buttonConnectTestTarget.Click += new System.EventHandler(this.ButtonConnectTestTarget_Click);
            // 
            // buttonFindTargetDatabase
            // 
            this.buttonFindTargetDatabase.Location = new System.Drawing.Point(176, 17);
            this.buttonFindTargetDatabase.Name = "buttonFindTargetDatabase";
            this.buttonFindTargetDatabase.Size = new System.Drawing.Size(48, 23);
            this.buttonFindTargetDatabase.TabIndex = 2;
            this.buttonFindTargetDatabase.Text = "Find";
            this.buttonFindTargetDatabase.UseVisualStyleBackColor = true;
            this.buttonFindTargetDatabase.Click += new System.EventHandler(this.ButtonFindTargetDatabase_Click);
            // 
            // textBoxTargetDatabase
            // 
            this.textBoxTargetDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxTargetDatabase.Location = new System.Drawing.Point(68, 19);
            this.textBoxTargetDatabase.Name = "textBoxTargetDatabase";
            this.textBoxTargetDatabase.Size = new System.Drawing.Size(102, 20);
            this.textBoxTargetDatabase.TabIndex = 1;
            // 
            // labelDatabaseTarget
            // 
            this.labelDatabaseTarget.AutoSize = true;
            this.labelDatabaseTarget.Location = new System.Drawing.Point(6, 22);
            this.labelDatabaseTarget.Name = "labelDatabaseTarget";
            this.labelDatabaseTarget.Size = new System.Drawing.Size(56, 13);
            this.labelDatabaseTarget.TabIndex = 0;
            this.labelDatabaseTarget.Text = "Database:";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(392, 143);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // UserControlConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBoxConnectTargetDatabase);
            this.Controls.Add(this.groupBoxConnectSourseDatabase);
            this.Name = "UserControlConnect";
            this.Size = new System.Drawing.Size(479, 169);
            this.groupBoxConnectSourseDatabase.ResumeLayout(false);
            this.groupBoxConnectSourseDatabase.PerformLayout();
            this.groupBoxConnectTargetDatabase.ResumeLayout(false);
            this.groupBoxConnectTargetDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDatabaseSourse;
        private System.Windows.Forms.GroupBox groupBoxConnectSourseDatabase;
        private System.Windows.Forms.Button buttonConnectTestSourse;
        private System.Windows.Forms.Button buttonFindSourseDatabase;
        private System.Windows.Forms.TextBox textBoxSourseDatabase;
        private System.Windows.Forms.GroupBox groupBoxConnectTargetDatabase;
        private System.Windows.Forms.Button buttonConnectTestTarget;
        private System.Windows.Forms.Button buttonFindTargetDatabase;
        private System.Windows.Forms.TextBox textBoxTargetDatabase;
        private System.Windows.Forms.Label labelDatabaseTarget;
        private System.Windows.Forms.Button buttonNext;
    }
}
