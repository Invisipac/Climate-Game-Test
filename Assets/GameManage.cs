using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update
    public Text goldText;
    private int windmillCounter = 0;
    private int gold = 0;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        
    }
    public void SetWindmill(int wms)
    {
        windmillCounter += wms;
    }

    public int GetWindmills()
    {
        return windmillCounter;
    }

    

    public int GetGold()
    {
        return gold;
    }

    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = gold.ToString();
    }
}
