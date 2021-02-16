using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildingSystem : MonoBehaviour
{
    [SerializeField] private BuildingTile[] buildingTiles;
    public BuildingTile[] BuildingTiles { get { return buildingTiles; } }

    private BuildingTile activeBuildingTile;

    private Tilemap tilemap;

    void Awake()
    {
        tilemap = GetComponent<Tilemap>();
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
        Vector3Int tilePos = Vector3Int.zero; // TODO
        tilemap.SetTile(tilePos, activeBuildingTile);
    }
}
