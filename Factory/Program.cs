using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace Factory
{
    class Program
    {
        public static List<Placeable> placeableList = new List<Placeable>();    //List of all placeable objects
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200,900, "Factory");
            while(Raylib.WindowShouldClose() == false)
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                Raylib.EndDrawing();
            }
        }
        
        static void placePlacable(Vector2 _position, int _kind, int _rotation)
        {
            placeableList.Add(new Placeable()
            {
                position = _position,   //Position on grid
                kind = _kind,           //1 = Belt, 2 = Starter, 3 = Seller
                rotation = _rotation    //0 = Up, 1 = Left, 2 = Down, 3 = Right
                
            });
        }
    }
}
/*
placePlacable(new Vector2(0,0), 3, 0);
            
            foreach (var Placeable in placeableList)
            {
                System.Console.WriteLine(Placeable.kind);
            }
*/