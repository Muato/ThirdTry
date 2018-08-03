using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squad : MonoBehaviour
{
	private GameObject parentTilePrefab;
	private Tile parentTile;
	public GameObject PeasantPrefab;
	void Start()
	{
		parentTilePrefab = this.transform.parent.gameObject;
		Transform t = parentTilePrefab.GetComponentInChildren<Transform>();

		GameObject unit1 = (GameObject)Instantiate(PeasantPrefab,
			t.position,
			Quaternion.identity,
			this.transform);
	}
	
}
