
using System;



namespace MauiApp1_hw
{
     class Goods
    {
        
        public double _price { get; set; }
        string _contryFrom { get; set; }
        string _name { get; set; }
        double _dateMade { get; set; }
        string _description { get; set; }

        public Goods(double price, string contryFrom, string name, double dateMade, string description)
        {
            _price = price;
            _contryFrom = contryFrom;
            _name = name;
            _dateMade = dateMade;
            _description = description;
        }

        public virtual List<string> GetInfo()
        {
            List<string> data = new() { _name, _description, _contryFrom, _price > 0 ? _price.ToString() : "Wrong Input" };
            return data;
        }
    }

    class Food : Goods
    {
        double _dateEnd;
        int _amount;
        string _unit;

        public Food(string name, string description,double dateMade, string countryFrom, double price, double dateEnd, string unit, int amount) : base ( price, countryFrom, name, dateMade, description)
        {
            _dateEnd = dateEnd;
            _amount = amount;
            _unit = unit;
        }

        public override List<string> GetInfo()
        {
            List<string> value = base.GetInfo();
            value.Add($"Amount: {(_amount > 0 ? _amount : "Wrong Input")}\nExpires:{_dateEnd}\nMeasurement:{_unit}");
            return value;
        }
    }

    class Books : Goods
    {
        int _pages;
        string _publishHouse;
        string _author;

        public Books(string name, string description,double dateMade, string countryFrom, double price, string author, string publishHouse, int pages) : base(price, countryFrom, name, dateMade, description)
        {
            _pages = pages;
            _publishHouse = publishHouse;
            _author = author;
        }

        public override List<string> GetInfo()
        {
            List<string> value = base.GetInfo();
            value.Add($"Pages: {(_pages > 0 ? _pages : "Wrong Input")}\nAuthor:{_author}\nPublishing:{_publishHouse}");
            return value;
        }
    }
}
