using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseComparisonLogic.UnitControls
{
    /// <summary>
    /// Класс хранения команд
    /// </summary>
    public class ControlCommand
    {
        /// <summary>
        /// Пустой конструктор класса
        /// </summary>
        public ControlCommand()
        {
            SetCommand("help");
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="command">Команда в виде текста</param>
        public ControlCommand(string command)
        {
            SetCommand(command);
        }
        /// <summary>
        /// Выставить команду
        /// </summary>
        /// <param name="command">Команда в виде текста</param>
        public void SetCommand(string command)
        {
            switch (command)
            {
                case "help":
                    {
                        Command = Command.help;
                        break;
                    }
                case "comp":
                    {
                        Command = Command.comparison;
                        break;
                    }
                case "colu":
                    {
                        Command = Command.columns;
                        break;
                    }
                case "view":
                    {
                        Command = Command.views;
                        break;
                    }
                case "trig":
                    {
                        Command = Command.triggers;
                        break;
                    }
                case "inde":
                    {
                        Command = Command.indexes;
                        break;
                    }
                case "cons":
                    {
                        Command = Command.constraints;
                        break;
                    }
                case "rela":
                    {
                        Command = Command.relationships;
                        break;
                    }
                case "unlo":
                    {
                        Command = Command.unloading;
                        break;
                    }
                case "exit":
                    {
                        Command = Command.exit;
                        break;
                    }
                default:
                    {
                        Command = Command.none;
                        break;
                    }
            }
            
        }
        /// <summary>
        /// Команда
        /// </summary>
        public Command Command { get; private set; }
        /// <summary>
        /// Список доступных команд
        /// </summary>
        /// <returns>Строковый список доступных команд</returns>
        public List<string> Help()
        {
            List<string> helpList = new List<string>();
            helpList.Add("help - detailed information.");
            helpList.Add("comp - full comparison of two databases.");
            helpList.Add("colu - column comparison.");
            helpList.Add("view - comparison of views.");
            helpList.Add("trig - trigger comparison.");
            helpList.Add("inde - index comparison.");
            helpList.Add("cons - comparison of restrictions.");
            helpList.Add("rela - relationship comparison.");
            helpList.Add("unlo - unloading database structure to xml file.");
            helpList.Add("exit - exit / end of program");
            return helpList;
        }
    }
}
