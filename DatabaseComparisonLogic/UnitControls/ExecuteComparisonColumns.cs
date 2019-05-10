using DatabaseComparisonLogic.Comparison.SQLiteComparison;

namespace DatabaseComparisonLogic.UnitControls
{
    public class ExecuteComparisonColumns : BaseExecuteCommand
    {
        public ExecuteComparisonColumns(ControlCommand command)
        {
            Connect();
            if(FirstConnectorSQlite != null && SecondConnectorSQlite != null)
            {
                if (command.Command == Command.comparison)
                {
                    BaseComparisons.Add(new SQLiteComparisonColumns(FirstConnectorSQlite.DataBase, SecondConnectorSQlite.DataBase));
                    ExecuteComparisonViews executeComparisonViews = new ExecuteComparisonViews(command, FirstConnectorSQlite, SecondConnectorSQlite);
                    BaseComparisons.AddRange(executeComparisonViews.BaseComparisons);
                }
                else if (command.Command == Command.columns)
                {
                    BaseComparisons.Add(new SQLiteComparisonColumns(FirstConnectorSQlite.DataBase, SecondConnectorSQlite.DataBase));
                }
                else
                {
                    ExecuteComparisonViews executeComparisonViews = new ExecuteComparisonViews(command, FirstConnectorSQlite, SecondConnectorSQlite);
                    BaseComparisons.AddRange(executeComparisonViews.BaseComparisons);
                }
            }
        }
    }
}
