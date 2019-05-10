using DatabaseComparisonLogic.Comparison.SQLiteComparison;
using DatabaseComparisonLogic.Connector;

namespace DatabaseComparisonLogic.UnitControls
{
    public class ExecuteComparisonViews : BaseExecuteCommand
    {
        public ExecuteComparisonViews(ControlCommand command, ConnectorSQLite firstConnectorSQLite, ConnectorSQLite secondConnectorSQLite)
        {
            if (command.Command == Command.comparison)
            {
                BaseComparisons.Add(new SQLiteComparisonViews(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
                ExecuteComparisonTriggers executeComparisonTriggers = new ExecuteComparisonTriggers(command, firstConnectorSQLite, secondConnectorSQLite);
                BaseComparisons.AddRange(executeComparisonTriggers.BaseComparisons);
            }
            else if (command.Command == Command.views)
            {
                BaseComparisons.Add(new SQLiteComparisonViews(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
            }
            else
            {
                ExecuteComparisonTriggers executeComparisonTriggers = new ExecuteComparisonTriggers(command, firstConnectorSQLite, secondConnectorSQLite);
                BaseComparisons.AddRange(executeComparisonTriggers.BaseComparisons);
            }
        }
    }
}
