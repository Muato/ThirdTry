using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {
	// TODO LIST:
	// Mouse control (13)
	// Tile highlight
	// Unit class


	// Use this for initialization
	void Start ()
    {
        GenerateMap();
	}

    public int width = 3, length = 4;
    public GameObject TilePrefab;
    public Material[] materials;

    private Tile[,] tiles;
	private Dictionary<GameObject, Tile> gameObjectToTileMap;

    public void GenerateMap()
    {
        tiles = new Tile[width, length];
		gameObjectToTileMap = new Dictionary<GameObject, Tile>();

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < length; z++)
            {

                Tile t = new Tile(this, x, z);
                tiles[x, z] = t;

                GameObject tile = (GameObject)Instantiate(TilePrefab,
                    t.Position(),
                    Quaternion.identity,
                    this.transform);

				gameObjectToTileMap[tile] = t;

                MeshRenderer mr = tile.GetComponentInChildren<MeshRenderer>();
                mr.material = materials[1]; //materials[Random.Range(0, materials.Length)];
            }
        }

        StaticBatchingUtility.Combine(this.gameObject);
    }

	public Tile GetTileFromGameObject(GameObject TileGO)
	{
		// Debug.Log("How about here?");
		if (gameObjectToTileMap.ContainsKey(TileGO))
		{
			Debug.Log("Can I get in here?");
			return gameObjectToTileMap[TileGO];
		}
		return null;
	}
}
