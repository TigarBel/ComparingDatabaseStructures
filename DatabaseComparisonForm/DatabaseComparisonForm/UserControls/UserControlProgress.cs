using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseComparisonLogic.Connector;
using DatabaseComparisonLogic.Comparison;
using DatabaseComparisonLogic.Comparison.SQLiteComparison;

namespace DatabaseComparisonForm.UserControls
{
    public partial class UserControlProgress : UserControl
    {

        private List<CheckBox> _checkBoxes = new List<CheckBox>();

        public UserControlProgress()
        {
            InitializeComponent();
            _checkBoxes.Add(checkBoxColumns);
            _checkBoxes.Add(checkBoxViews);
            _checkBoxes.Add(checkBoxTriggers);
            _checkBoxes.Add(checkBoxIndexes);
            _checkBoxes.Add(checkBoxConstraints);
            _checkBoxes.Add(checkBoxRelationships);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach(CheckBox checkBox in _checkBoxes)
            {
                check = checkBox.Checked;
                if (check)
                    break;
            }

            if(check)
            {
                ItemsComparison = new List<bool>();
                BaseComparisons = new List<BaseComparison>();
                ItemsDifferent = new List<bool>();

                labelCompletion.Visible = true;
                buttonCancel.Enabled = false;
                buttonStart.Visible = false;
                buttonStart.Enabled = false;
                buttonNext.Visible = true;
                buttonNext.Enabled = true;

                foreach (CheckBox checkBox in _checkBoxes)
                {
                    ItemsComparison.Add(checkBox.Checked);
                    if (checkBox.Checked)
                    {
                        Compair(checkBox);
                    }
                    checkBox.Enabled = false;
                }

                labelCompletion.Text = "Databases are no different";
                foreach (bool different in ItemsDifferent)
                {
                    if (different)
                        labelCompletion.Text = "Databases have different structure";
                }
                labelCompletion.Visible = true;
            }
            else
            {
                DialogResult messageBox = MessageBox.Show("Select comparison item.");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Progress = false;
            this.Visible = false;
            this.Enabled = false;
        }

        private void Compair(CheckBox checkBox)
        {
            switch (checkBox.Text)
            {
                case "Tables / Columns":
                    {
                        SQLiteComparisonColumns sQLiteComparisonColumns = new SQLiteComparisonColumns(ConnectorSQLiteSourse.DataBase, 
                            ConnectorSQLiteTarget.DataBase);
                        BaseComparisons.Add(sQLiteComparisonColumns);
                        ItemsDifferent.Add(sQLiteComparisonColumns.StructureIsDifferent);
                        break;
                    }
                case "Views":
                    {
                        SQLiteComparisonViews sQLiteComparisonViews = new SQLiteComparisonViews(ConnectorSQLiteSourse.DataBase,
                            ConnectorSQLiteTarget.DataBase);
                        BaseComparisons.Add(sQLiteComparisonViews);
                        ItemsDifferent.Add(sQLiteComparisonViews.StructureIsDifferent);
                        break;
                    }
                case "Triggers":
                    {
                        SQLiteComparisonTriggers sQLiteComparisonTriggers = new SQLiteComparisonTriggers(ConnectorSQLiteSourse.DataBase,
                            ConnectorSQLiteTarget.DataBase);
                        BaseComparisons.Add(sQLiteComparisonTriggers);
                        ItemsDifferent.Add(sQLiteComparisonTriggers.StructureIsDifferent);
                        break;
                    }
                case "Indexes":
                    {
                        SQLiteComparisonIndexes sQLiteComparisonIndexes = new SQLiteComparisonIndexes(ConnectorSQLiteSourse.DataBase,
                            ConnectorSQLiteTarget.DataBase);
                        BaseComparisons.Add(sQLiteComparisonIndexes);
                        ItemsDifferent.Add(sQLiteComparisonIndexes.StructureIsDifferent);
                        break;
                    }
                case "Constraints":
                    {
                        SQLiteComparisonConstraints sQLiteComparisonConstraints = new SQLiteComparisonConstraints(ConnectorSQLiteSourse.DataBase,
                            ConnectorSQLiteTarget.DataBase);
                        BaseComparisons.Add(sQLiteComparisonConstraints);
                        ItemsDifferent.Add(sQLiteComparisonConstraints.StructureIsDifferent);
                        break;
                    }
                case "Relationships":
                    {
                        SQLiteComparisonRelationships sQLiteComparisonRelationships = new SQLiteComparisonRelationships(ConnectorSQLiteSourse.DataBase,
                            ConnectorSQLiteTarget.DataBase);
                        BaseComparisons.Add(sQLiteComparisonRelationships);
                        ItemsDifferent.Add(sQLiteComparisonRelationships.StructureIsDifferent);
                        break;
                    }
            }
        }

        public bool Progress { get; set; }

        public ConnectorSQLite ConnectorSQLiteSourse { get; set; }

        public ConnectorSQLite ConnectorSQLiteTarget { get; set; }

        public List<bool> ItemsComparison { get; private set; }

        public List<BaseComparison> BaseComparisons { get; private set; }

        public List<bool> ItemsDifferent { get; private set; }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            Progress = false;
            this.Enabled = false;
            this.Visible = false;
        }
    }
}
