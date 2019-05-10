using DatabaseComparisonLogic.Comparison;
using DatabaseComparisonLogic.Comparison.Writers;
using System;

namespace DatabaseComparisonLogic.UnitControls
{

    public class UnitControl
    {

        public UnitControl(string command)
        {
            ControlCommand controlCommand = new ControlCommand(command);
            if (controlCommand.Command == Command.help)
            {
                Help();
            }
            else if (controlCommand.Command == Command.exit)
            {

            }
            else if (controlCommand.Command != Command.none)
            {
                ExecuteComparisonColumns executeComparisonColumns = new ExecuteComparisonColumns(controlCommand);
                foreach(BaseComparison baseComparison in executeComparisonColumns.BaseComparisons)
                {
                    DifferenceTableWriter differenceTableWriter = new DifferenceTableWriter(baseComparison, 
                        executeComparisonColumns.FirstConnectorSQlite.DataBaseFileName, executeComparisonColumns.SecondConnectorSQlite.DataBaseFileName);
                    differenceTableWriter.Write(16);
                }
            }
            else
            {
                Console.WriteLine("Error, command is not found!");
            }
        }

        private void Help()
        {
            foreach(string help in new ControlCommand().Help())
            {
                Console.WriteLine(help);
            }
        }
    }
}
