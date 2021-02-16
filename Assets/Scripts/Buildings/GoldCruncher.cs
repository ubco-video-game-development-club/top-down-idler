using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCruncher : Building
{
    [SerializeField] private int goldAmount = 1;
    [SerializeField] private int goldInterval = 1;

    private bool isProductionActive = true;

    private YieldInstruction goldIntervalInstruction;

    void Awake()
    {
        goldIntervalInstruction = new WaitForSeconds(goldInterval);
    }

    void Start()
    {
        StartCoroutine(ProductionCycle());
    }

    private IEnumerator ProductionCycle()
    {
        while (isProductionActive)
        {
            yield return goldIntervalInstruction;
            GameManager.ResourceSystem.AddGold(goldAmount);
        }
    }
}
