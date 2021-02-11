using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Map
    {
        string path = @"C:\Users\shark\Desktop\GitHub Projects\Text-Based-RPG\Text-Based_RPG\Maptext.txt";

        string mapText;
        string wall;
        string enter;
        string exit;


        public Map()
        {
            mapText = File.ReadAllText(path);
            wall = "#";
            enter = "O";
            exit = "0";
        }

        public void Draw()
        {
            Console.Write(mapText);
        }

    }
}
