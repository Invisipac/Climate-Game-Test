using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class moveSmogScript : MonoBehaviour
{
    private float changeDirRate = 2;
    private float timer = 0;
    private int moveSpeed = 5;
    private new Vector3 direction;

    private int smogHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < changeDirRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
            timer = 0;
        }

        if (transform.position.x < -8 || transform.position.x > 7.5 || transform.position.y < -5 || transform.position.y > 3)
        {
            direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        }

        transform.position += direction * moveSpeed * Time.deltaTime;

    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}