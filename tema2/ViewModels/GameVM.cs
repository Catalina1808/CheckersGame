using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tema2.Commands;
using tema2.Models;
using tema2.Services;

namespace tema2.ViewModels
{
    class GameVM : BaseNotification
    {
        SerializationActions actions;

        private GameBusinessLogic bl;
        public GameBusinessLogic Bl
        {
            get { return bl; }
            set
            {
                bl = value;
                NotifyPropertyChanged("Bl");
            }
        }

        
        public GameVM()
        {
            actions = new SerializationActions(bl);
            if (resumeGame)
            {
                actions.DeserializeObject();
                bl = actions.game;
                Board = bl.Cells;
                GameBoard = CellBoardToCellVMBoard(Board);
            }
            else
            {
                Board = Helper.InitGameBoard();
                bl = new GameBusinessLogic(Board);
                GameBoard = CellBoardToCellVMBoard(Board);
            }

        }

        public static bool resumeGame;
        public ObservableCollection<ObservableCollection<CellVM>> CellBoardToCellVMBoard(ObservableCollection<ObservableCollection<Cell>> board)
        {
            ObservableCollection<ObservableCollection<CellVM>> result = new ObservableCollection<ObservableCollection<CellVM>>();
            for (int i = 0; i < board.Count; i++)
            {
                ObservableCollection<CellVM> line = new ObservableCollection<CellVM>();
                for (int j = 0; j < board[i].Count; j++)
                {
                    Cell c = board[i][j];

                    CellVM cellVM = new CellVM(c.X, c.Y, c.Display, c.Empty, c.Red, c.White, c.RedKing, c.WhiteKing, bl);
                    line.Add(cellVM);
                }
                result.Add(line);
            }
            return result;
        }
 


        public ObservableCollection<ObservableCollection<Cell>> board;
        public ObservableCollection<ObservableCollection<Cell>> Board
        {
            get { return board; }
            set
            {
                board = value;
                NotifyPropertyChanged("Board");
            }
        }

        private ObservableCollection<ObservableCollection<CellVM>> gameBoard;
        public ObservableCollection<ObservableCollection<CellVM>> GameBoard
        {
            get { return gameBoard; }
            set
            {
                gameBoard = CellBoardToCellVMBoard(Board);
                NotifyPropertyChanged("GameBoard");
            }
        }

        public ICommand serializationCommand;
        public ICommand SerializationCommand
        {
            get
            {
                if (serializationCommand == null)
                    serializationCommand = new RelayCommand<GameBusinessLogic>(actions.SerializeObject);
                return serializationCommand;
            }
        }
        

    }
}
