using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema2.Commands;
using tema2.Models;
using tema2.Services;

namespace tema2.ViewModels
{
    class CellVM : BaseNotification
    {
        GameBusinessLogic bl;
        public CellVM(int x, int y, string display, string empty, string red, string white, string redKing, string whiteKing, GameBusinessLogic bl)
        {
            SimpleCell = new Cell(x, y, display, empty, red, white, redKing, whiteKing);
            this.bl = bl;
        }

        private Cell simpleCell;
        public Cell SimpleCell
        {
            get { return simpleCell; }
            set
            {
                simpleCell = value;
                NotifyPropertyChanged("SimpleCell");
            }
        }
        private ICommand clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                if (clickCommand == null)
                {
                    clickCommand = new RelayCommand<Cell>(bl.ClickAction);
                    
                    
                }
                return clickCommand;
            }
        }
    }
}
