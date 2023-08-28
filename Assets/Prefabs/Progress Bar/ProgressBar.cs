using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    public float max;
    public float cur;
    public Image fillBar;

    [SerializeField] GameObject smogSpawner;
    [SerializeField] GameObject gameManager;

    private SmogSpawnScript smogSpawn;
    private GameManage gameManage;
    private int progressRate = 2;
    private float timer = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        smogSpawn = smogSpawner.GetComponent<SmogSpawnScript>();
        gameManage = gameManager.GetComponent<GameManage>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > (float) 1/progressRate)
        {
            SetFillAmount();
            timer = 0;
        }

        
    }

    private void SetFillAmount()
    {
        fillBar.fillAmount += (float) smogSpawn.GetCounter() / 100;
        fillBar.fillAmount -= (float) 2 * gameManage.GetWindmills() / 100;
    }
}