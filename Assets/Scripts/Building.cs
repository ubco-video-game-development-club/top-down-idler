using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    [SerializeField] protected int cost = 1;
    public int Cost { get { return cost; } }
}
