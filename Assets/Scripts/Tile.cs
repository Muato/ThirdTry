using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {
    readonly int X;
    readonly int Z;


    public Tile(TileMap map, int x, int z)
    {
        X = x;
        Z = z;
    }
            

    public Vector3 Position()
    {
        return new Vector3(X, 0, Z);
    }

}
