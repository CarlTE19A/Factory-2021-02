using System;
using System.Numerics;
using Raylib_cs;

namespace Factory
{
    public class Placeable
    {
        public Vector2 position { get; set; }  
        public int kind { get; set; }
        public int rotation { get; set; }  
        
    }
}
