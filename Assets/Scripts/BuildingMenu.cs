using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenu : MonoBehaviour
{
    [SerializeField] private BuildingSelector[] selectors;

    void Start()
    {
        BuildingTile[] tiles = GameManager.BuildingSystem.BuildingTiles;

        int count = Mathf.Min(selectors.Length, tiles.Length);
        for (int i = 0; i < selectors.Length; i++)
        {
            if (i < count) selectors[i].BuildingTile = tiles[i];
            selectors[i].SetMenuActive(i < count);
        }
    }
}
