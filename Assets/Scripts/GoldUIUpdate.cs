using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUIUpdate : MonoBehaviour{

    public Text textBox;

    void Start()
    {
        GameManager.ResourceSystem.AddGoldChangedListener(UpdateGold);
    }

    private void UpdateGold(int gold) 
    {
        textBox.text = "$" + gold.ToString();
    }
}
