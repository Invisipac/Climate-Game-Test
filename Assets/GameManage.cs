using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update

    private int windmillCounter = 0;


    public void AddWindmill()
    {
        windmillCounter += 1;
    }

    public int GetWindmills()
    {
        return windmillCounter;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
