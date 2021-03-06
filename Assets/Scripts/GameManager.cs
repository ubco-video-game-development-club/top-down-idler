using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private static ResourceSystem resourceSystem;
    public static ResourceSystem ResourceSystem { get { return resourceSystem; } }
    private static BuildingSystem buildingSystem;
    public static BuildingSystem BuildingSystem { get { return buildingSystem; } }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        resourceSystem = GetComponent<ResourceSystem>();
        buildingSystem = GetComponent<BuildingSystem>();
    }
}
