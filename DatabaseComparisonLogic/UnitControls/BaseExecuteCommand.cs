using DatabaseComparisonLogic.Comparison;
using DatabaseComparisonLogic.Connector;
using System;
using System.Collections.Generic;
using System.IO;

namespace DatabaseComparisonLogic.UnitControls
{
    abstract public class BaseExecuteCommand
    {
        public BaseExecuteCommand()
        {
            BaseComparisons = new List<BaseComparison>();
        }

        protected void Connect()
        {
            Console.WriteLine("Read the file name of datebase: (..\\database.db)");
            string firstDataBaseFileName = Console.ReadLine();
            Console.WriteLine("Read the file name of datebase: (..\\database.db)");
            string secondDataBaseFileName = Console.ReadLine();

            if (File.Exists(firstDataBaseFileName) && File.Exists(secondDataBaseFileName))
            {
                FirstConnectorSQlite = new ConnectorSQLite(firstDataBaseFileName);
                SecondConnectorSQlite = new ConnectorSQLite(secondDataBaseFileName);
            }
            else
            {
                FirstConnectorSQlite = null;
                SecondConnectorSQlite = null;
                Console.WriteLine("These databases are missing!");
            }
        }

        public List<BaseComparison> BaseComparisons { get; protected set; }

        public ConnectorSQLite FirstConnectorSQlite { get; private set; }

        public ConnectorSQLite SecondConnectorSQlite { get; private set; }
    }
}
