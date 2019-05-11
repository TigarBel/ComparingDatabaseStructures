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
using System.IO;
using System.Data.SQLite;

namespace DatabaseComparisonForm.UserControls
{
    public partial class UserControlComparisonOutput : UserControl
    {
        private List<DataGridView> _dataGridViews = new List<DataGridView>();

        public UserControlComparisonOutput()
        {
            InitializeComponent();

            _dataGridViews.Add(dataGridViewColumns);
            _dataGridViews.Add(dataGridViewViews);
            _dataGridViews.Add(dataGridViewTriggers);
            _dataGridViews.Add(dataGridViewIndexes);
            _dataGridViews.Add(dataGridViewConstraints);
            _dataGridViews.Add(dataGridViewRelationships);
            foreach (DataGridView dataGridView in _dataGridViews)
            {
                dataGridView.Columns.Add("ListOfItems", "List of items");
            }

            Output = false;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {

        }

        public bool Output { get; set; }

        public ConnectorSQLite ConnectorSQLiteSourse
        {
            set
            {
                foreach (DataGridView dataGridView in _dataGridViews)
                {
                    dataGridView.Columns.Add(value.DataBaseFileName, value.DataBaseFileName);
                }
                comboBoxUnloadDatabase.Items.Add(value.DataBaseFileName);
            }
        }

        public ConnectorSQLite ConnectorSQLiteTarget
        {
            set
            {
                foreach (DataGridView dataGridView in _dataGridViews)
                {
                    dataGridView.Columns.Add(value.DataBaseFileName, value.DataBaseFileName);
                }
                comboBoxUnloadDatabase.Items.Add(value.DataBaseFileName);
            }
        }

        public List<bool> ItemsComparison
        {
            set
            {
                int i = 0;
                foreach(bool check in value)
                {
                    if(!check)
                    {
                        tabControlComparison.TabPages[i].Text = "-";
                    }
                    i++;
                }
            }
        }

        public List<BaseComparison> BaseComparisons
        {
            set
            {
                int i = 0;
                int j = 0;
                foreach (TabPage tabPage in tabControlComparison.TabPages)
                {
                    if(tabPage.Text != "-")
                    {
                        for (int n = 0; n < value[j].ListOfAllItems.Count; n++)
                        {
                            string[] list = { value[j].ListOfAllItems[n], Convert.ToString(value[j].FirstListOfDifferences[n]),
                                Convert.ToString(value[j].SecondListOfDifferences[n]) };
                            _dataGridViews[i].Rows.Add(list);
                        }
                        j++;
                    }
                    i++;
                }
            }
        }

        public List<bool> ItemsDifferent
        {
            set
            {
                int i = 0;
                foreach(TabPage tabPage in tabControlComparison.TabPages)
                {
                    if(tabPage.Text != "-" && value[i])
                    {
                        tabPage.Text = tabPage.Text + "*";
                    }
                }
            }
        }

        private void ButtonUnloadToXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML File|*.xml";
            saveFileDialog.Title = "Unloading to xml.";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                if (File.Exists(comboBoxUnloadDatabase.SelectedItem.ToString()))
                {
                    ConnectorSQLite connectorSQlite = new ConnectorSQLite(comboBoxUnloadDatabase.SelectedItem.ToString());

                    DataTable dataTable = new DataTable();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM sqlite_master", connectorSQlite.DataBase);
                    adapter.Fill(dataTable);
                    dataTable.TableName = saveFileDialog.FileName;

                    using (StreamWriter fs = new StreamWriter(saveFileDialog.FileName)) // XML File Path
                    {
                        dataTable.WriteXml(fs);
                    }
                }
                else
                {
                    Console.WriteLine("This databas is missing!");
                }
            }


        }
    }
}
