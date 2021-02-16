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
    private Grid layoutGrid;

    void Awake()
    {
        layoutGrid = tilemap.layoutGrid;
    }

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
        return layoutGrid.WorldToCell((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
