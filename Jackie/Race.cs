using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie
{
  class Race
  {
    private int year;

    public int Year
    {
      get { return year; }
      set { year = value; }
      //set
      //{
      // if (value < 0)
      //{
      //  year = 2000;
      // }
      // else
      //{
      //  year = value;
      //}
      // }
    }

    private int races;

    public int Races
    {
      get { return races; }
      set { races = value; }
    }
    private int wins;

    public int Wins
    {
      get { return wins; }
      set { wins = value; }
    }
    private int podiums;

    public int Podiums
    {
      get { return podiums; }
      set { podiums = value; }
    }

    private int poles;

    public int Poles
    {
      get { return poles; }
      set { poles = value; }
    }
    private int fastest;

    public int Fastest
    {
      get { return fastest; }
      set { fastest = value; }
    }

    public Race(int year, int races, int wins, int podiums, int poles, int fastest)
    {
      this.year = year;
      this.races = races;
      this.wins = wins;
      this.podiums = podiums;
      this.poles = poles;
      this.fastest = fastest;
    }
  }
}
