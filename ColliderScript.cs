using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehavior
{

    private bool p1 = false;
    private bool p2 = false;
    private bool p3 = false;

	void Start()
    {

    }

    void Update()
    {
        if (p1 == true && p2 == true && p3 == true)
        {
            Debug.Log("Define win state behavior here.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Puzzle1Object")
        {
            p1 = true;
        }
        else if (collision.gameObject.name == "Puzzle2Object")
        {
            p2 = true;
        }
        else if (collision.gameObject.name == "Puzzle3Object")
        {
            p3 = true;
        }
    }
}
