using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Products
    {
        private long id;
        private string name;
        private string madeIn;
        private double price;
        private string time;

        public long Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string MadeIn
        {
            get { return madeIn; }
            set
            {
                madeIn = value;
                OnPropertyChanged("MadeIn");
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                if (DateTime.TryParse(value, out DateTime result))
                    time = result.ToShortDateString();
                else
                    time = "!!!!";
                OnPropertyChanged("Time");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
