using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildingSystem : MonoBehaviour
{
    [SerializeField] private BuildingTile[] buildingTiles;
    public BuildingTile[] BuildingTiles { get { return buildingTiles; } }

    private BuildingTile activeBuildingTile;

    [SerializeField] private Tilemap tilemap;

    public void SetActiveBuilding(BuildingTile tile)
    {
        activeBuildingTile = tile;
    }

    public BuildingTile PlaceBuilding(BuildingTile tile)
    {
        Vector3 mousePos = Input.mousePosition;
        // TODO: since this floors, this will only work if the tiles are set up a specific way. Let's check that. 
        Debug.Log(tilemap.GetTile(new Vector3Int((int)mousePos.x, (int)mousePos.y, (int)mousePos.z)));
        return new BuildingTile();
    }

    private Vector3Int GetTilePositionAtMousePosition()
    {
        GridLayout gridLayout = tilemap.layoutGrid;
        Vector3Int cellPosition = gridLayout.WorldToCell(Input.mousePosition);
        Debug.Log(cellPosition);
        return cellPosition;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetTilePositionAtMousePosition();
        }
    }
}
