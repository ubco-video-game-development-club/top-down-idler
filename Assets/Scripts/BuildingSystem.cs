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

    void Update()
    {
        if (activeBuildingTile != null && Input.GetMouseButtonDown(0))
        {
            PlaceBuilding();
            activeBuildingTile = null;
        }
    }

    public void SetActiveBuilding(BuildingTile tile)
    {
        activeBuildingTile = tile;
    }

    public void PlaceBuilding()
    {
        Vector3Int tilePos = GetTilePositionAtMousePosition();
        tilemap.SetTile(tilePos, activeBuildingTile);
    }

    private Vector3Int GetTilePositionAtMousePosition()
    {
        GridLayout gridLayout = tilemap.layoutGrid;
        Vector3Int cellPosition = gridLayout.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Debug.Log(cellPosition);
        return cellPosition;
    }
}
