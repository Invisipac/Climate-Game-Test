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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetFillAmount();
    }

    private void SetFillAmount()
    {
        float fillAmount = cur / max;
        fillBar.fillAmount = fillAmount;
    }
}
