using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    public float max;
    private float cur;
    public Image fillBar;

    [SerializeField] GameObject smogSpawner;
    [SerializeField] GameObject gameManager;
    [SerializeField] SmogCounter smogParent;

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
        if (timer > (float)1 / progressRate)
        {

            SetFillAmount();
            timer = 0;

        }
        WinGame();
        GameOver();
        //Debug.Log(gameManage.GetWindmills());
        //Debug.Log(smogParent.GetSmogCounter());


    }

    private void SetFillAmount()
    {
        fillBar.fillAmount -= (float)gameManage.GetWindmills() / 100;
        fillBar.fillAmount += (float)smogParent.GetSmogCounter() / 100;
        
        Debug.Log(fillBar.fillAmount);
        if (fillBar.fillAmount == 1)
        {
            Debug.Log("test");
        }
    }

    private void WinGame()
    {
        if (fillBar.fillAmount <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    private void GameOver()
    {
        if (fillBar.fillAmount >= 1)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
