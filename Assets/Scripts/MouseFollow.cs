using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class MouseFollow : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject objectToPlace;
    [SerializeField] Transform horizonLineTop;
    [SerializeField] Transform horizonLineBottom;
    [SerializeField] Transform boundaryLineRight;
    [SerializeField] Transform boundaryLineLeft;
    [SerializeField] UnityEvent WindmillAdded;
    [SerializeField] GameObject smog;
    private GameManage manage;

    public GameObject windmill;
    private bool windmillActive = false;
    void Start()
    {

        //Transform t = transform.GetChild(0);
        //windmill = t.gameObject;    
        //windmill.SetActive(false);
        manage = GameObject.FindFirstObjectByType<GameManage>();

    }

    // Update is called once per frame
    void Update()
    {


        //if(cursor != null)
        //{

        //    MoveCursor();
        //}

        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        if (mousePos.y >= horizonLineTop.position.y)
        {
            transform.position = new Vector3(mousePos.x, horizonLineTop.position.y, 0);
        }


        if (mousePos.x > boundaryLineRight.position.x)
        {
            transform.position = new Vector3(boundaryLineRight.position.x, mousePos.y, 0);
        }

        if (mousePos.y > horizonLineTop.position.y && mousePos.x > boundaryLineRight.position.x)
        {
            transform.position = new Vector3(boundaryLineRight.position.x, horizonLineTop.position.y, 0);
        }




        //MoveCursor();


    }

    //private void MoveCursor()
    //{
    //    Vector3 mousePos = Input.mousePosition;
    //    mousePos = Camera.main.ScreenToWorldPoint(mousePos);
    //    mousePos.z = 0;
    //    cursor.transform.position = new Vector3(mousePos.x, 0, 0);
    //    if (mousePos.y < horizonLine.position.y)
    //    {
    //        cursor.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    //    }
    //}

    public void SetCursor()
    {
        if (!(manage.GetGold() < 10))
        {
            windmillActive = !windmillActive;
            windmill.SetActive(windmillActive);
        }
        
        
        //cursor.GetComponent<SpriteRenderer>().enabled = true;
    }

    public void PlaceObject(InputAction.CallbackContext input)
    {
        if (windmillActive)
        {
            if (input.started && manage.GetGold() >= 10)
            {
                Instantiate(objectToPlace, transform.position, Quaternion.identity);
                windmillActive = false;
                windmill.SetActive(windmillActive);
                WindmillAdded.Invoke();
                manage.AddGold(-10);
                return;
            }
        }
    }

    
}
