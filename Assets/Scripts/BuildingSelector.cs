using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class BuildingSelector : MonoBehaviour
{
    public BuildingTile BuildingTile { get; set; }

    private CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void SetMenuActive(bool active)
    {
        canvasGroup.alpha = active ? 1 : 0;
        canvasGroup.blocksRaycasts = active;
    }

    public void UpdateActiveBuilding()
    {
        GameManager.BuildingSystem.SetActiveBuilding(BuildingTile);
    }
}
