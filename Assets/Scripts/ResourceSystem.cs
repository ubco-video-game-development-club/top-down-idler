using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResourceSystem : MonoBehaviour
{
    public class GoldChangedEvent : UnityEvent<int> { }

    private int gold;
    public int Gold { get { return gold; } }

    private GoldChangedEvent onGoldChanged = new GoldChangedEvent();

    ///<summary>Adds a set amount of gold.</summary>
    public void AddGold(int amount)
    {
        gold += amount;
        onGoldChanged.Invoke(gold);
    }

    ///<summary>Removes a set amount of gold. Total is clamped to 0.</summary>
    public void RemoveGold(int amount)
    {
        gold = Mathf.Max(gold - amount, 0);
        onGoldChanged.Invoke(gold);
    }

    ///<summary>Removes a set amount of gold. If the cost exceeds the total, returns false and does not remove the gold.</summary>
    public bool TryRemoveGold(int amount)
    {
        bool allowed = gold - amount >= 0;
        if (allowed)
        {
            gold -= amount;
            onGoldChanged.Invoke(gold);
        }
        return allowed;
    }

    public void AddGoldChangedListener(UnityAction<int> listener)
    {
        onGoldChanged.AddListener(listener);
    }

    public void RemoveGoldChangedListener(UnityAction<int> listener)
    {
        onGoldChanged.RemoveListener(listener);
    }
}
