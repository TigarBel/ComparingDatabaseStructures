using DatabaseComparisonLogic.Comparison.SQLiteComparison;
using DatabaseComparisonLogic.Connector;

namespace DatabaseComparisonLogic.UnitControls
{
    public class ExecuteComparisonRelationships : BaseExecuteCommand
    {
        public ExecuteComparisonRelationships(ControlCommand command, ConnectorSQLite firstConnectorSQLite, ConnectorSQLite secondConnectorSQLite)
        {
            if (command.Command == Command.comparison || command.Command == Command.relationships)
            {
                BaseComparisons.Add(new SQLiteComparisonRelationships(firstConnectorSQLite.DataBase, secondConnectorSQLite.DataBase));
            }
        }
    }
}
