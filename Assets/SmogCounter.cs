using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmogCounter : MonoBehaviour
{
    // Start is called before the first frame update

    private int smogCounter;

    void Start()
    {
        
    }

    public int GetSmogCounter()
    { 
        return smogCounter;
    }

    public void SetSmogCounter(int smogs)
    {
        smogCounter += smogs;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
