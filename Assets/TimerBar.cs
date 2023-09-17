using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{

    public float max;
    private float cur;
    public Image fillBar;
    [SerializeField] GameObject windmill;
    private float timer = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        fillBar.fillAmount = (float) timer / 5;
        if (timer < 0)
        {
            Destroy(windmill); 
        }
    }
}
