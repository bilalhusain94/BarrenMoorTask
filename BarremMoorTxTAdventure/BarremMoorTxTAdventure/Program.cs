using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarremMoorTxTAdventure
{
    class Program
    {

    
        static void Main(string[] args)
        {
            int compassHeading = 93;
            string Direction = new Direction
                               .Direction(d => compassHeading >= d.MinHeading && compassHeading <= d.MaxHeading)
                               .Select(d => d.Direction);
        }
            class Direction
        {
            public Direction(string dir, int min, int max)
            {
                MinHeading = min;
                MaxHeading = max;
                Directions = dir;
            }
            public int MinHeading { get; private set; }
            public int MaxHeading { get; private set; }
            public string Directions { get; private set; }
        }

        var directions = new List<Direction>
               {
                    new Direction("N",0,0),
                    new Direction("NNE",1,44),
                    new Direction("NE",45,45),
                    new Direction("ENE",46,89),
                    new Direction("E",90,90),
                    new Direction("ESE",90,0),
                    new Direction("SE",135,135),
                    new Direction("SSE",136,179),
                    new Direction("S",180,180),
                    new Direction("SSW",181,224),
                    new Direction("SW",225,225),
                    new Direction("WSW",226,229),
                    new Direction("W",270,270),
                    new Direction("WNW",271,314),
                    new Direction("NW",315,315),
                    new Direction("NNW",316,359),
               };
        
        }

    }

