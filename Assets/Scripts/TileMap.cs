using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {
	// TODO LIST:
	// Mouse control (13)	x
	// Tile highlight		x
	// Unit class


	// Use this for initialization
	void Start ()
    {
        GenerateMap();
		GenerateSquad();
	}

    public int width = 3, length = 4;
    public GameObject TilePrefab;
	public GameObject SquadPrefab;
    public Material[] materials;

    private Tile[,] tiles;
	private Dictionary<Tile, GameObject> tileToGameObjectMap;
	private Dictionary<GameObject, Tile> gameObjectToTileMap;

	//private Squad squad1;

    public void GenerateMap()
    {
        tiles = new Tile[width, length];
		tileToGameObjectMap = new Dictionary<Tile, GameObject>();
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

				tileToGameObjectMap[t] = tile;
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
			//Debug.Log("Can I get in here?");
			return gameObjectToTileMap[TileGO];
		}
		return null;
	}

	public Tile GetTileAt(int x, int z)
	{
		return tiles[x, z];
	}

	public void GenerateSquad()
	{
		GameObject tile = tileToGameObjectMap[tiles[1, 2]];
		GameObject squad = (GameObject)Instantiate(SquadPrefab, tile.transform);
	}
}
