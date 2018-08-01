using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour {
	Tile hoverTile;
	TileMap tileMap;

	public LayerMask LayerIDForTiles;


	delegate void MouseUpdateHandler(); // (object source, EventArgs args);
    MouseUpdateHandler MouseUpdateFunction;

    Vector3 MouseDownPosition;
    float MouseDragThreshold = 5f;

    void Start()
    {
        MouseUpdateFunction = DetectMouseMode;
		tileMap = GameObject.FindObjectOfType<TileMap>();
    }


	void Update()
	{
        // 1. Get minimal info about tile below cursor (mmaybe if hovered longer than 0.5 s)
        // 2. If Mouse button pressed, do stuff.
        // Drag function
        // Tile select
        // Unit select TODO: 

        //GetTile();

        if (MouseUpdateFunction != null)
            MouseUpdateFunction();
	}

    void DetectMouseMode()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MouseDownPosition = Input.mousePosition;
            Debug.Log("Down");
        }
        else if(Input.GetMouseButton(0) && Vector3.Distance(MouseDownPosition, Input.mousePosition) > MouseDragThreshold)
        {
            Debug.Log("Drag mode: ON");
            MouseUpdateFunction = CameraDragMode;
			//MouseUpdateFunction();
        }
        else if(Input.GetMouseButtonUp(0))
        {
			Tile TempTile = GetTile();
			Vector3 pos = TempTile.Position();
            Debug.Log("Up: " + pos.ToString("F4"));
        }
    }

    void CameraDragMode()
    {
		if (Input.GetMouseButtonUp(0))
		{
			Debug.Log("Drag mode: OFF");
			MouseUpdateFunction = DetectMouseMode;
		}

		// Works fine.
		Camera.main.transform.Translate(0.01f*(MouseDownPosition - Input.mousePosition));
		MouseDownPosition = Input.mousePosition;

		// TODO: Need to add camera inertia.
    }



	Tile GetTile()
	{
		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		int layerMask = LayerIDForTiles.value;

		if (Physics.Raycast(mouseRay, out hitInfo, Mathf.Infinity, layerMask))
		{
			//Debug.Log(hitInfo);
			Debug.Log("Hit something");
			GameObject TileGO = hitInfo.collider.gameObject;
			
			return tileMap.GetTileFromGameObject(TileGO);
		}

		return null;
	}
}
