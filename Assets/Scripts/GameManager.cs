using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private ResourceSystem resourceSystem;
    public ResourceSystem ResourceSystem { get { return resourceSystem; } }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        resourceSystem = GetComponent<ResourceSystem>();
    }
}
