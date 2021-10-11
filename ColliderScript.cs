using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehavior
{
	void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "TrackableName")
        {
            Debug.Log("Define collision behavior here.");
        }
    }
}
