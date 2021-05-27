using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tema2.Models
{
    [Serializable]
   public class Cell : INotifyPropertyChanged
    {
        public Cell()
        {

        }

        public Cell(int x, int y, string display, string empty, string red, string white, string redKing, string whiteKing)
        {
            this.X = x;
            this.Y = y;
            this.Display = display;
            this.Empty = empty;
            this.Red = red;
            this.White = white;
            this.RedKing = redKing;
            this.WhiteKing = whiteKing;
        }

        [XmlElement]
        private int x;
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                NotifyPropertyChanged("X");
            }
        }
        [XmlElement]
        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                NotifyPropertyChanged("Y");
            }
        }
        [XmlElement]
        private string display;
        public string Display
        {
            get { return display; }
            set
            {
                display = value;
                NotifyPropertyChanged("Display");
            }
        }
        [XmlElement]
        private string empty;
        public string Empty
        {
            get { return empty; }
            set
            {
                empty = value;
                NotifyPropertyChanged("Empty");
            }
        }
        [XmlElement]
        private string red;
        public string Red
        {
            get { return red; }
            set
            {
                red = value;
                NotifyPropertyChanged("Red");
            }
        }
        [XmlElement]
        private string white;
        public string White
        {
            get { return white; }
            set
            {
                white = value;
                NotifyPropertyChanged("White");
            }
        }
        [XmlElement]
        private string redKing;
        public string RedKing
        {
            get { return redKing; }
            set
            {
                redKing = value;
                NotifyPropertyChanged("RedKing");
            }
        }
        [XmlElement]
        private string whiteKing;
        public string WhiteKing
        {
            get { return whiteKing; }
            set
            {
                whiteKing = value;
                NotifyPropertyChanged("WhiteKing");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
