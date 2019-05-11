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
            //if (_userControlConnect.Connect)
            //{
            //    _userControlConnect.Connect = false;
            //    _userControlProgress.Progress = true;
            //    _userControlProgress.Enabled = true;
            //    _userControlProgress.Visible = true;
            //    _userControlProgress.ConnectorSQLiteSourse = _userControlConnect.ConnectorSQLiteSourse;
            //    _userControlProgress.ConnectorSQLiteTarget = _userControlConnect.ConnectorSQLiteTarget;
            //}
            _userControlProgress.Enabled = true;
            _userControlProgress.Visible = true;
            _userControlProgress.ConnectorSQLiteSourse = _userControlConnect.ConnectorSQLiteSourse;
            _userControlProgress.ConnectorSQLiteTarget = _userControlConnect.ConnectorSQLiteTarget;
        }

        private void _userControlProgress_EnabledChanged(object sender, EventArgs e)
        {
            //if (_userControlConnect.Connect && !_userControlProgress.Progress)
            //{
            //    _userControlConnect.Connect = false;
            //    _userControlConnect.Enabled = true;
            //    _userControlConnect.Visible = true;
            //}
            // else 
            //if (!_userControlConnect.Connect && _userControlProgress.Progress && !_userControlComparisonOutput.Output)
            //{
            //    _userControlComparisonOutput.Output = true;
            //    _userControlComparisonOutput.Enabled = true;
            //    _userControlComparisonOutput.Visible = true;
            //}
            if (!_userControlProgress.Enabled)
            {
                _userControlComparisonOutput.Enabled = true;
                _userControlComparisonOutput.Visible = true;
                _userControlComparisonOutput.ConnectorSQLiteSourse = _userControlProgress.ConnectorSQLiteSourse;
                _userControlComparisonOutput.ConnectorSQLiteTarget = _userControlProgress.ConnectorSQLiteTarget;
                _userControlComparisonOutput.ItemsComparison = _userControlProgress.ItemsComparison;
                _userControlComparisonOutput.BaseComparisons = _userControlProgress.BaseComparisons;
                _userControlComparisonOutput.ItemsDifferent = _userControlProgress.ItemsDifferent;
            }
    }

        private void _userControlComparisonOutput_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}
