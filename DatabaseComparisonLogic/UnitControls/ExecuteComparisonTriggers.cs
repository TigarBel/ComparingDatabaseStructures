using DatabaseComparisonLogic.Comparison.SQLiteComparison;
using DatabaseComparisonLogic.Connector;

namespace DatabaseComparisonLogic.UnitControls
{
    public class ExecuteComparisonTriggers : BaseExecuteCommand
    {
        public ExecuteComparisonTriggers(ControlCommand command, ConnectorSQLite firstConnectorSQLite, ConnectorSQLite secondConnectorSQLite)
        {
            if (command.Command == Command.comparison)
            {
                BaseComparisons.Add(new SQLiteComparisonTriggers(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
                ExecuteComparisonIndexes executeComparisonIndexes  = new ExecuteComparisonIndexes(command, firstConnectorSQLite, secondConnectorSQLite);
                BaseComparisons.AddRange(executeComparisonIndexes.BaseComparisons);
            }
            else if (command.Command == Command.triggers)
            {
                BaseComparisons.Add(new SQLiteComparisonTriggers(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
            }
            else
            {
                ExecuteComparisonIndexes executeComparisonIndexes = new ExecuteComparisonIndexes(command, firstConnectorSQLite, secondConnectorSQLite);
                BaseComparisons.AddRange(executeComparisonIndexes.BaseComparisons);
            }
        }
    }
}
