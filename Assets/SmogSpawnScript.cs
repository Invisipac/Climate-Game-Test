using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SmogSpawnScript : MonoBehaviour
{
    public GameObject smog;

    private int spawnRate = 1;
    private float timer = 0;
    private int smogCounter = 0;
    [SerializeField] SmogCounter smogParent;

    public float leftScreen = -8;
    public float rightScreen = 8;
    public float topScreen = 3;
    public float bottomScreen = -5;
    

    public int GetCounter()
    {
        return smogCounter;
    }

    public void DecreaseSmogCounter()
    { 
        smogCounter -= 1;
    }


    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnSmog();
            timer = 0;
        }
    }

    void spawnSmog()
    {
        Instantiate(smog, new Vector3(Random.Range(leftScreen, rightScreen), Random.Range(bottomScreen, topScreen), 0), transform.rotation, smogParent.transform);
        //smogCounter += 1;
        smogParent.SetSmogCounter(1);
    }
}
