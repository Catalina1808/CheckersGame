using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema2.Models;

namespace tema2.Services
{
    class Helper
    {
        public static Cell CurrentCell { get; set; }
        public static Cell PreviousCell { get; set; }
        public static ObservableCollection<ObservableCollection<Cell>> InitGameBoard()
        {
            return new ObservableCollection<ObservableCollection<Cell>>()
            {
                new ObservableCollection<Cell>()
                {

                    new Cell(0, 0, "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(0, 1,"/tema2;component/Resources/white.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(0, 2, "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(0, 3,"/tema2;component/Resources/white.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(0, 4, "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png" , "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(0, 5,"/tema2;component/Resources/white.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png" , "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(0, 6, "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png" , "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(0, 7, "/tema2;component/Resources/white.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png" , "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png")
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(1, 0, "/tema2;component/Resources/white.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(1, 1, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png" ,"/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(1, 2,"/tema2;component/Resources/white.png",  "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(1, 3, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(1, 4, "/tema2;component/Resources/white.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png","/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(1, 5, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(1, 6, "/tema2;component/Resources/white.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(1, 7, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png")
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(2, 0, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(2, 1,"/tema2;component/Resources/white.png",  "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(2, 2, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(2, 3, "/tema2;component/Resources/white.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(2, 4, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(2, 5, "/tema2;component/Resources/white.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(2, 6, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(2, 7, "/tema2;component/Resources/white.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png")
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(3, 0, "/tema2;component/Resources/brown.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(3, 1, "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(3, 2,"/tema2;component/Resources/brown.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(3, 3, "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(3, 4, "/tema2;component/Resources/brown.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(3, 5,  "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(3, 6, "/tema2;component/Resources/brown.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(3, 7, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png")
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(4, 0, "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(4, 1,"/tema2;component/Resources/brown.png",  "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(4, 2,  "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(4, 3,"/tema2;component/Resources/brown.png",  "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(4, 4, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(4, 5,"/tema2;component/Resources/brown.png",  "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(4, 6,  "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(4, 7,"/tema2;component/Resources/brown.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png")
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(5, 0, "/tema2;component/Resources/red.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(5, 1, "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png","/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(5, 2,"/tema2;component/Resources/red.png",  "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(5, 3, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(5, 4, "/tema2;component/Resources/red.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(5, 5, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(5, 6, "/tema2;component/Resources/red.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(5, 7,  "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png")
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(6, 0, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(6, 1,"/tema2;component/Resources/red.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(6, 2, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(6, 3, "/tema2;component/Resources/red.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(6, 4, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(6, 5, "/tema2;component/Resources/red.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(6, 6, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png","/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(6, 7,  "/tema2;component/Resources/red.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png")
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(7, 0, "/tema2;component/Resources/red.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(7, 1, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png","/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(7, 2, "/tema2;component/Resources/red.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(7, 3, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png","/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(7, 4,  "/tema2;component/Resources/red.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(7, 5, "/tema2;component/Resources/nude.png", "/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(7, 6,  "/tema2;component/Resources/red.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png"),
                    new Cell(7, 7,  "/tema2;component/Resources/nude.png","/tema2;component/Resources/brown.png", "/tema2;component/Resources/red.png", "/tema2;component/Resources/white.png", "/tema2;component/Resources/king_red.png", "/tema2;component/Resources/king_white.png")
                }

            };
        }
    }
}
