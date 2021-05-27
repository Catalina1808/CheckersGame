using tema2.Models;
using tema2.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Xml.Serialization;
using System.IO;

namespace tema2.Services
{
    [Serializable]
    public class GameBusinessLogic : INotifyPropertyChanged
    {
        [XmlElement]
        public int redPieces;

        [XmlElement]
        public int whitePieces;

        [XmlArray]
        public ObservableCollection<ObservableCollection<Cell>> cells;
        public ObservableCollection<ObservableCollection<Cell>> Cells
        {
            get { return cells; }
            set
            {
                cells = value;
                NotifyPropertyChanged("Cells");
            }
        }

        public GameBusinessLogic()
        {

        }
        public GameBusinessLogic(ObservableCollection<ObservableCollection<Cell>> cells)
        {
            this.cells = cells;
            nextPlayer = " Muta jucatorul rosu.";
            redPieces = 12;
            whitePieces = 12;
            mmg = multipleMovesGame;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        [XmlElement]
        public string nextPlayer;
        public string NextPlayer
        {
            get { return nextPlayer; }
            set
            {
               nextPlayer = value;
                NotifyPropertyChanged("NextPlayer");
            }
        }
        
        public static bool multipleMovesGame;

        [XmlElement]
        public bool mmg;

        private void PutRedPiece(Cell cell)
        {
            cell.Display = cell.Red;
        }

        private void PutRedKingPiece(Cell cell)
        {
            cell.Display = cell.RedKing;
        }

        private void PutWhitePiece(Cell cell)
        {
            cell.Display = cell.White;
        }

        private void PutWhiteKingPiece(Cell cell)
        {
            cell.Display = cell.WhiteKing;
        }

        private void EmptyCell(Cell cell)
        {
            cell.Display = cell.Empty;
        }

        public void MakeKing(Cell currentCell)
        {
            if (currentCell.Display == currentCell.Red && currentCell.X == 0)
                PutRedKingPiece(currentCell);
            else
                if (currentCell.Display == currentCell.White && currentCell.X == 7)
                PutWhiteKingPiece(currentCell);
        }

        public bool VerifyWin()
        {
            int scor;          
            if (whitePieces == 0)
            {
                string[] statistics = File.ReadAllLines("statistics.txt");
                nextPlayer = " Jucatorul rosu a castigat!:) ";
                scor = int.Parse(statistics[0]);
                scor++;
                statistics[0] = scor.ToString();
                File.WriteAllLines("statistics.txt", statistics);
                return true;
            }
            else if (redPieces == 0)
            {
                string[] statistics = File.ReadAllLines("statistics.txt");
                nextPlayer = " Jucatorul alb a castigat!:) ";
                scor = int.Parse(statistics[1]);
                scor++;
                statistics[1] = scor.ToString();
                File.WriteAllLines("statistics.txt", statistics);
                return true;
            }
            else
                return false;
        
        }

        public void SimpleMove(Cell currentCell, Cell previousCell)
        {
            if (previousCell.Display == previousCell.RedKing)
            {
                EmptyCell(previousCell);
                PutRedKingPiece(currentCell);
                nextPlayer = " Muta jucatorul alb.";
            }
            else
                if (previousCell.Display == previousCell.WhiteKing)
            {
                EmptyCell(previousCell);
                PutWhiteKingPiece(currentCell);
                nextPlayer = " Muta jucatorul rosu.";
            }
            else
                     if (previousCell.Display == previousCell.Red && currentCell.X == previousCell.X - 1)
            {
                EmptyCell(Helper.PreviousCell);
                PutRedPiece(currentCell);
                nextPlayer = " Muta jucatorul alb.";
            }
            else
                         if (previousCell.Display == previousCell.White && currentCell.X == previousCell.X + 1)
            {
                EmptyCell(Helper.PreviousCell);
                PutWhitePiece(currentCell);
                nextPlayer = " Muta jucatorul rosu.";
            }

        }

        public void MultipleSalt(Cell currentCell, Cell previousCell)
        {
            string turn = nextPlayer;
            SimpleSalt(currentCell, previousCell);
            MakeKing(currentCell);
            if ((currentCell.Display == currentCell.Red && ((currentCell.X-2>=0 && currentCell.Y+2<=7 && (cells[currentCell.X - 1][currentCell.Y + 1].Display == currentCell.White || cells[currentCell.X - 1][currentCell.Y + 1].Display == currentCell.WhiteKing) && cells[currentCell.X-2][currentCell.Y+2].Display==currentCell.Empty) || (currentCell.X - 2>=0 && currentCell.Y - 2>=0 && (cells[currentCell.X - 1][currentCell.Y - 1].Display == currentCell.White || cells[currentCell.X - 1][currentCell.Y - 1].Display == currentCell.WhiteKing) && cells[currentCell.X - 2][currentCell.Y - 2].Display == currentCell.Empty)))
                || (currentCell.Display == currentCell.White && ((currentCell.X + 2<=7 && currentCell.Y + 2<=7 && (cells[currentCell.X + 1][currentCell.Y + 1].Display == currentCell.Red || cells[currentCell.X + 1][currentCell.Y + 1].Display == currentCell.RedKing) && cells[currentCell.X + 2][currentCell.Y + 2].Display == currentCell.Empty) || (currentCell.X + 2<=7 && currentCell.Y - 2>=0 && (cells[currentCell.X + 1][currentCell.Y - 1].Display == currentCell.Red || cells[currentCell.X + 1][currentCell.Y - 1].Display == currentCell.RedKing) && cells[currentCell.X + 2][currentCell.Y - 2].Display == currentCell.Empty)))
                || (currentCell.Display == currentCell.RedKing && ((currentCell.X - 2>=0 && currentCell.Y + 2<=7 && (cells[currentCell.X - 1][currentCell.Y + 1].Display == currentCell.White || cells[currentCell.X - 1][currentCell.Y + 1].Display == currentCell.WhiteKing) && cells[currentCell.X - 2][currentCell.Y + 2].Display == currentCell.Empty) || (currentCell.X - 2 >= 0 && currentCell.Y - 2 >= 0 && (cells[currentCell.X - 1][currentCell.Y - 1].Display == currentCell.White || cells[currentCell.X - 1][currentCell.Y - 1].Display == currentCell.WhiteKing) && cells[currentCell.X - 2][currentCell.Y - 2].Display == currentCell.Empty) || (currentCell.X + 2 <= 7 && currentCell.Y +2 <=7 && (cells[currentCell.X + 1][currentCell.Y + 1].Display == currentCell.White || cells[currentCell.X + 1][currentCell.Y + 1].Display == currentCell.WhiteKing) && cells[currentCell.X + 2][currentCell.Y + 2].Display == currentCell.Empty) || (currentCell.X + 2 <= 7 && currentCell.Y - 2 >=0 && (cells[currentCell.X + 1][currentCell.Y - 1].Display == currentCell.White || cells[currentCell.X + 1][currentCell.Y - 1].Display == currentCell.WhiteKing) && cells[currentCell.X + 2][currentCell.Y - 2].Display == currentCell.Empty)))
                || (currentCell.Display == currentCell.WhiteKing && ((currentCell.X - 2 >= 0 && currentCell.Y + 2 <= 7 && (cells[currentCell.X - 1][currentCell.Y + 1].Display == currentCell.Red || cells[currentCell.X - 1][currentCell.Y + 1].Display == currentCell.RedKing)  && cells[currentCell.X - 2][currentCell.Y + 2].Display == currentCell.Empty) || (currentCell.X - 2 >= 0 && currentCell.Y - 2 >= 0 && (cells[currentCell.X - 1][currentCell.Y - 1].Display == currentCell.Red || cells[currentCell.X - 1][currentCell.Y - 1].Display == currentCell.RedKing) && cells[currentCell.X - 2][currentCell.Y - 2].Display == currentCell.Empty) || (currentCell.X + 2 <= 7 && currentCell.Y + 2 <= 7 && (cells[currentCell.X + 1][currentCell.Y + 1].Display == currentCell.Red || cells[currentCell.X + 1][currentCell.Y + 1].Display == currentCell.RedKing) && cells[currentCell.X + 2][currentCell.Y + 2].Display == currentCell.Empty) || (currentCell.X + 2 <= 7 && currentCell.Y - 2 >= 0 && (cells[currentCell.X + 1][currentCell.Y - 1].Display == currentCell.Red || cells[currentCell.X + 1][currentCell.Y - 1].Display == currentCell.RedKing) && cells[currentCell.X + 2][currentCell.Y - 2].Display == currentCell.Empty))))

                nextPlayer = turn;

        }


        public void SimpleSalt(Cell currentCell, Cell previousCell)
        {
            if (currentCell.X == previousCell.X - 2 && ((currentCell.Y == previousCell.Y + 2 && (cells[previousCell.X - 1][previousCell.Y + 1].Display == currentCell.White || cells[previousCell.X - 1][previousCell.Y + 1].Display == currentCell.WhiteKing)) || (currentCell.Y == previousCell.Y - 2 && (cells[previousCell.X - 1][previousCell.Y - 1].Display == currentCell.White || cells[previousCell.X - 1][previousCell.Y - 1].Display == currentCell.WhiteKing))))
            {
                if (previousCell.Display == previousCell.Red)
                {
                    currentCell.Display = currentCell.Red;
                    EmptyCell(cells[(currentCell.X + previousCell.X) / 2][(currentCell.Y + previousCell.Y) / 2]);
                    EmptyCell(previousCell);
                    nextPlayer = " Muta jucatorul alb.";
                    whitePieces--;
                }
                else
                    if (previousCell.Display == previousCell.RedKing)
                {
                    currentCell.Display = currentCell.RedKing;
                    EmptyCell(cells[(currentCell.X + previousCell.X) / 2][(currentCell.Y + previousCell.Y) / 2]);
                    EmptyCell(previousCell);
                    nextPlayer = " Muta jucatorul alb.";
                    whitePieces--;
                }

            }
             else if (currentCell.X == previousCell.X + 2 && ((currentCell.Y == previousCell.Y + 2 && (cells[previousCell.X + 1][previousCell.Y + 1].Display == currentCell.Red || cells[previousCell.X + 1][previousCell.Y + 1].Display == currentCell.RedKing)) || (currentCell.Y == previousCell.Y - 2 && (cells[previousCell.X + 1][previousCell.Y - 1].Display == currentCell.Red || cells[previousCell.X + 1][previousCell.Y - 1].Display == currentCell.RedKing))))
            {
                if (previousCell.Display == previousCell.White)
                {
                    currentCell.Display = currentCell.White;
                    EmptyCell(cells[(currentCell.X + previousCell.X) / 2][(currentCell.Y + previousCell.Y) / 2]);
                    EmptyCell(previousCell);
                    nextPlayer = " Muta jucatorul rosu.";
                    redPieces--;
                }
                else
                    if (previousCell.Display == previousCell.WhiteKing)
                {
                    currentCell.Display = currentCell.WhiteKing;
                    EmptyCell(cells[(currentCell.X + previousCell.X) / 2][(currentCell.Y + previousCell.Y) / 2]);
                    EmptyCell(previousCell);
                    nextPlayer = " Muta jucatorul rosu.";
                    redPieces--;
                }
            }
             else if ((currentCell.X == previousCell.X - 2 && ((currentCell.Y == previousCell.Y + 2 && (cells[previousCell.X - 1][previousCell.Y + 1].Display == currentCell.Red || cells[previousCell.X - 1][previousCell.Y + 1].Display == currentCell.RedKing)) || (currentCell.Y == previousCell.Y - 2 && (cells[previousCell.X - 1][previousCell.Y - 1].Display == currentCell.Red|| cells[previousCell.X - 1][previousCell.Y - 1].Display == currentCell.RedKing))))
                     && (previousCell.Display == previousCell.WhiteKing))
            {
                currentCell.Display = currentCell.WhiteKing;
                EmptyCell(cells[(currentCell.X + previousCell.X) / 2][(currentCell.Y + previousCell.Y) / 2]);
                EmptyCell(previousCell);
                nextPlayer = " Muta jucatorul rosu.";
                redPieces--;
            }
            else if ((currentCell.X == previousCell.X + 2 && ((currentCell.Y == previousCell.Y + 2 && (cells[previousCell.X + 1][previousCell.Y + 1].Display == currentCell.White || cells[previousCell.X + 1][previousCell.Y + 1].Display == currentCell.WhiteKing)) || (currentCell.Y == previousCell.Y - 2 && (cells[previousCell.X + 1][previousCell.Y - 1].Display == currentCell.White || cells[previousCell.X + 1][previousCell.Y - 1].Display == currentCell.WhiteKing))))
                 && (previousCell.Display == previousCell.RedKing))
            {
                currentCell.Display = currentCell.RedKing;
                EmptyCell(cells[(currentCell.X + previousCell.X) / 2][(currentCell.Y + previousCell.Y) / 2]);
                EmptyCell(previousCell);
                nextPlayer = " Muta jucatorul alb.";
                whitePieces--;
            }

        }


        public void Move(Cell currentCell)
        {
            Helper.CurrentCell = currentCell;
            if ((currentCell.Display == currentCell.White || currentCell.Display == currentCell.WhiteKing) && nextPlayer == " Muta jucatorul rosu.")
                MessageBox.Show("JUCATORUL ROSU AM ZIS!!");
            else
             if ((currentCell.Display == currentCell.Red || currentCell.Display == currentCell.RedKing) && nextPlayer == " Muta jucatorul alb.")
                MessageBox.Show("JUCATORUL ALB AM ZIS!!");

            if (currentCell.Display == currentCell.Empty)
            {
                if (Helper.PreviousCell != null)
                {
                    if (((currentCell.X == Helper.PreviousCell.X - 1) || (currentCell.X == Helper.PreviousCell.X + 1)) && (currentCell.Y == Helper.PreviousCell.Y - 1 || currentCell.Y == Helper.PreviousCell.Y + 1))
                    {
                        SimpleMove(currentCell, Helper.PreviousCell);
                    }
                    else if (((currentCell.X == Helper.PreviousCell.X - 2) || (currentCell.X == Helper.PreviousCell.X + 2)) && (currentCell.Y == Helper.PreviousCell.Y - 2 || currentCell.Y == Helper.PreviousCell.Y + 2))
                    {
                        if(mmg)
                            MultipleSalt(currentCell, Helper.PreviousCell);
                        else
                        SimpleSalt(currentCell, Helper.PreviousCell);
                       
                    }


                    cells[Helper.PreviousCell.X][Helper.PreviousCell.Y] = Helper.PreviousCell;
                }

            }
            Helper.PreviousCell = currentCell;
            cells[currentCell.X][currentCell.Y] = currentCell;


        }

        public void ClickAction(Cell obj)
        {
            if (!VerifyWin())
            {
                Move(obj);
                MakeKing(obj);
                VerifyWin();
                NotifyPropertyChanged("NextPlayer");
            }
        }
    }
}
