using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenu : MonoBehaviour
{
    [SerializeField] private BuildingSelector[] selectors;

    void Start()
    {
        // BuildingTile[] tiles = GameManager.BuildingSystem.GetBuildingTiles();
        BuildingTile[] tiles = new BuildingTile[3];

        int count = Mathf.Min(selectors.Length, tiles.Length);
        for (int i = 0; i < selectors.Length; i++)
        {
            selectors[i].SetMenuActive(i < count);
        }
    }
}
