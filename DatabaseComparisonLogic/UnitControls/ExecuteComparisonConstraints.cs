using DatabaseComparisonLogic.Comparison.SQLiteComparison;
using DatabaseComparisonLogic.Connector;

namespace DatabaseComparisonLogic.UnitControls
{
    public class ExecuteComparisonConstraints : BaseExecuteCommand
    {
        public ExecuteComparisonConstraints(ControlCommand command, ConnectorSQLite firstConnectorSQLite, ConnectorSQLite secondConnectorSQLite)
        {
            if (command.Command == Command.comparison)
            {
                BaseComparisons.Add(new SQLiteComparisonConstraints(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
                ExecuteComparisonRelationships executeComparisonRelationships = new ExecuteComparisonRelationships(command, firstConnectorSQLite, secondConnectorSQLite);
                BaseComparisons.AddRange(executeComparisonRelationships.BaseComparisons);
            }
            else if (command.Command == Command.constraints)
            {
                BaseComparisons.Add(new SQLiteComparisonConstraints(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
            }
            else
            {
                ExecuteComparisonRelationships executeComparisonRelationships = new ExecuteComparisonRelationships(command, firstConnectorSQLite, secondConnectorSQLite);
                BaseComparisons.AddRange(executeComparisonRelationships.BaseComparisons);
            }
        }
    }
}
