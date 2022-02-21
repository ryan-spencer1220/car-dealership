using System;

namespace Dealership.Models {

  public class Car
  {
    private int _year;
    private string _makeModel;

    public string MakeModel
    {
      get
      {
          return _makeModel; 
      }
      set
      {
          _makeModel = value;
      }
    }
    private int _price;
    private int _miles;
    private int _maxSpeed;

    public Car(int year, string makeModel, int price, int miles, int maxSpeed)
    {
      _year = year;
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _maxSpeed = maxSpeed;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public static string MakeSound(string sound)
    {
    return "Our cars sound like " + sound;
    }     

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
    public double OnSale()
    {
      return (_price * 0.80);
    }
    public string DakarRallyPerformance()
    {
      if (_maxSpeed > 80)
      {
        return "You'll do just fine at The Dakar Rally";
      }
      else
      {
        return "You may have a hard time at The Dakar Rally";
      }
    }
    public double ResaleValue()
    {
      if (_year < 1985 && _year > 1980) 
      {
        return (_price * .90);
      }
      else if (_year < 1980 && _year > 1975) 
      {
        return (_price * .80);
      }
      else
      {
        return (_price * .70);
      }
    }
  }

}