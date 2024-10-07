using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    private Transform destination;
    public bool isPortal1;
    public float distance = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        if (isPortal1 == false)
        {
            destination = GameObject.FindGameObjectWithTag("Portal2").GetComponent<Transform>();
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("Portal1").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Vector2.Distance(transform.position, collision.transform.position) < distance)
        {
            collision.transform.position = new Vector2 (destination.position.x, destination.position.y);
        }
    }
}
