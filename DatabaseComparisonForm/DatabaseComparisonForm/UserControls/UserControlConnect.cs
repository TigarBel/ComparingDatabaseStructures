using System;
using System.Windows.Forms;
using System.IO;
using DatabaseComparisonLogic.Connector;
using System.Drawing;

namespace DatabaseComparisonForm.UserControls
{
    public partial class UserControlConnect : UserControl
    {

        public UserControlConnect()
        {
            InitializeComponent();
            Connect = false;
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if(ConnectorSQLiteSourse != null && ConnectorSQLiteTarget != null)
            {
                Connect = true;
                this.Visible = false;
                this.Enabled = false;
            }
            else
            {
                DialogResult messageBox = MessageBox.Show("Connect error! Please testing connect.");
            }
        }

        public bool Connect { get; set; }

        private void GetFileNameDatabase(TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "database files (*.db)|*.db|sqlite files (*.sqlite)|*.sqlite";
            openFileDialog.Title = "Name of database";
            if (openFileDialog.ShowDialog() != DialogResult.Cancel && openFileDialog.FileName != "")
            {
                textBox.Text = openFileDialog.FileName;
            }
        }

        private void ButtonFindSourseDatabase_Click(object sender, EventArgs e)
        {
            textBoxSourseDatabase.BackColor = Color.White;
            GetFileNameDatabase(textBoxSourseDatabase);
        }

        private void ButtonFindTargetDatabase_Click(object sender, EventArgs e)
        {
            textBoxTargetDatabase.BackColor = Color.White;
            GetFileNameDatabase(textBoxTargetDatabase);
        }

        private ConnectorSQLite TestConnect(TextBox textBox)
        {
            ConnectorSQLite сonnectorSQlite;
            if (textBox.Text.Length > 4)
            {
                сonnectorSQlite = new ConnectorSQLite(textBox.Text);
                if (сonnectorSQlite.DataBase != null)
                {
                    textBox.BackColor = Color.LightGreen;
                    return сonnectorSQlite;
                }
                else
                {
                    textBox.BackColor = Color.LightPink;
                }
            }
            return null;
        }

        private void ButtonConnectTestSourse_Click(object sender, EventArgs e)
        {
            ConnectorSQLiteSourse = TestConnect(textBoxSourseDatabase);
        }

        private void ButtonConnectTestTarget_Click(object sender, EventArgs e)
        {
            ConnectorSQLiteTarget = TestConnect(textBoxTargetDatabase);
        }

        public ConnectorSQLite ConnectorSQLiteSourse { get; private set; }

        public ConnectorSQLite ConnectorSQLiteTarget { get; private set; }
    }
}
