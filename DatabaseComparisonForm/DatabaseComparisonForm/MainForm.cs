using System;
using System.Windows.Forms;

namespace DatabaseComparisonForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void _userControlConnect_EnabledChanged(object sender, EventArgs e)
        {
            if (_userControlConnect.Connect)
            {

                this._userControlProgress = new DatabaseComparisonForm.UserControls.UserControlProgress();
                this._userControlProgress.ConnectorSQLiteSourse = null;
                this._userControlProgress.ConnectorSQLiteTarget = null;
                this._userControlProgress.Enabled = false;
                this._userControlProgress.Location = new System.Drawing.Point(12, 12);
                this._userControlProgress.Name = "_userControlProgress";
                this._userControlProgress.Progress = false;
                this._userControlProgress.Size = new System.Drawing.Size(498, 251);
                this._userControlProgress.TabIndex = 1;
                this._userControlProgress.Visible = false;
                this._userControlProgress.EnabledChanged += new System.EventHandler(this._userControlProgress_EnabledChanged);
                this.Controls.Add(this._userControlProgress);

                _userControlProgress.Progress = true;
                _userControlProgress.Enabled = true;
                _userControlProgress.Visible = true;
                _userControlConnect.Connect = false;
                _userControlProgress.ConnectorSQLiteSourse = _userControlConnect.ConnectorSQLiteSourse;
                _userControlProgress.ConnectorSQLiteTarget = _userControlConnect.ConnectorSQLiteTarget;
            }
        }

        private void _userControlProgress_EnabledChanged(object sender, EventArgs e)
        {
            if (!_userControlProgress.Progress)
            {
                this._userControlComparisonOutput = new DatabaseComparisonForm.UserControls.UserControlComparisonOutput();
                this._userControlComparisonOutput.Enabled = false;
                this._userControlComparisonOutput.Location = new System.Drawing.Point(12, 12);
                this._userControlComparisonOutput.Name = "_userControlComparisonOutput";
                this._userControlComparisonOutput.Output = false;
                this._userControlComparisonOutput.Size = new System.Drawing.Size(552, 360);
                this._userControlComparisonOutput.TabIndex = 2;
                this._userControlComparisonOutput.Visible = false;
                this._userControlComparisonOutput.EnabledChanged += new System.EventHandler(this._userControlComparisonOutput_EnabledChanged);
                this.Controls.Add(this._userControlComparisonOutput);

                _userControlComparisonOutput.Enabled = true;
                _userControlComparisonOutput.Visible = true;
                _userControlComparisonOutput.ConnectorSQLiteSourse = _userControlProgress.ConnectorSQLiteSourse;
                _userControlComparisonOutput.ConnectorSQLiteTarget = _userControlProgress.ConnectorSQLiteTarget;
                _userControlComparisonOutput.ItemsComparison = _userControlProgress.ItemsComparison;
                _userControlComparisonOutput.BaseComparisons = _userControlProgress.BaseComparisons;
                _userControlComparisonOutput.ItemsDifferent = _userControlProgress.ItemsDifferent;
            }
            else if(!_userControlConnect.Connect && _userControlProgress.Progress)
            {
                _userControlConnect.Enabled = true;
                _userControlConnect.Visible = true;
            }
    }

        private void _userControlComparisonOutput_EnabledChanged(object sender, EventArgs e)
        {
            if (_userControlComparisonOutput.Output)
            {
                this._userControlConnect = new DatabaseComparisonForm.UserControls.UserControlConnect();
                this._userControlConnect.Connect = false;
                this._userControlConnect.Location = new System.Drawing.Point(12, 12);
                this._userControlConnect.Name = "_userControlConnect";
                this._userControlConnect.Size = new System.Drawing.Size(479, 169);
                this._userControlConnect.TabIndex = 0;
                this._userControlConnect.EnabledChanged += new System.EventHandler(this._userControlConnect_EnabledChanged);
                this.Controls.Add(this._userControlConnect);

                _userControlComparisonOutput.Output = false;
                _userControlConnect.Enabled = true;
                _userControlConnect.Visible = true;
                _userControlConnect.Connect = true;
            }
        }
    }
}
