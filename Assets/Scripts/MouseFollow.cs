using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class MouseFollow : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject cursor;
    [SerializeField] GameObject objectToPlace;
    [SerializeField] Transform horizonLine;
    [SerializeField] UnityEvent WindmillAdded;
    private GameManage manage;
    private Vector3 mousePos;

    void Start()
    {
        mousePos = new Vector3();
        manage = GameObject.FindFirstObjectByType<GameManage>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;
        cursor.transform.position = new Vector3(mousePos.x, 0, 0);
        if (mousePos.y < horizonLine.position.y)
        {
            cursor.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
        
    }

    public void PlaceObject(InputAction.CallbackContext input)
    {
        if (input.started && manage.GetGold() >= 10)
        {
            Instantiate(objectToPlace, cursor.transform.position, Quaternion.identity);
            WindmillAdded.Invoke();
            manage.AddGold(-10);
            return;
        }
    }
}
