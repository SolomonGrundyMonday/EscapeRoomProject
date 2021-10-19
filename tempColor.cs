using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempColor : MonoBehaviour
{

    private bool p1 = false;
    // private bool p2 = false;
    // private bool p3 = false;
    private GameObject blue;

    public Material orange;

	void Start()
    {
        blue = GameObject.Find("blue");
        // m_meshrenderer = gameObject.GetComponent<green>();
        // m_meshrenderer = gameObject.GetComponent<pink>();
    }

    void Update()
    {
        // if (p1 == true || p2 == true || p3 == true)
        // {
        //     Debug.Log("Define win state behavior here.");
        // }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "temp")
        {
            p1 = true;

            // blue.material.color = new Color(255,69,0);

            blue.GetComponent<MeshRenderer>().material = orange;
        }
        // else if (collision.gameObject.name == "green")
        // {
        //     p2 = true;

        //     green.material.color = new Color(255,69,0);
        // }
        // else if (collision.gameObject.name == "pink")
        // {
        //     p3 = true;
        //     pink.material.color = new Color(255,69,0);
        // }
    }
}
