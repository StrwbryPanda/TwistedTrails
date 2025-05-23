using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public Transform Player;
    public float speed;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.forward;

        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed = Time.deltaTime);
    }
}
