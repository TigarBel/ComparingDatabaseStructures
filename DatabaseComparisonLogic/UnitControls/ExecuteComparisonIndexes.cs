using DatabaseComparisonLogic.Comparison.SQLiteComparison;
using DatabaseComparisonLogic.Connector;

namespace DatabaseComparisonLogic.UnitControls
{
    public class ExecuteComparisonIndexes : BaseExecuteCommand
    {
        public ExecuteComparisonIndexes(ControlCommand command, ConnectorSQLite firstConnectorSQLite, ConnectorSQLite secondConnectorSQLite)
        {
            if (command.Command == Command.comparison)
            {
                BaseComparisons.Add(new SQLiteComparisonIndexes(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
                ExecuteComparisonConstraints executeComparisonConstraints = new ExecuteComparisonConstraints(command, firstConnectorSQLite, secondConnectorSQLite);
                BaseComparisons.AddRange(executeComparisonConstraints.BaseComparisons);
            }
            else if (command.Command == Command.indexes)
            {
                BaseComparisons.Add(new SQLiteComparisonIndexes(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
            }
            else
            {
                ExecuteComparisonConstraints executeComparisonConstraints = new ExecuteComparisonConstraints(command, firstConnectorSQLite, secondConnectorSQLite);
                BaseComparisons.AddRange(executeComparisonConstraints.BaseComparisons);
            }
        }
    }
}
