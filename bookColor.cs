using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookColor : MonoBehaviour
{

    // private bool p1 = false;
    // private bool p2 = false;
    private bool p3 = false;
    private GameObject pink;

    public Material orange;

	void Start()
    {
        // m_meshrenderer = gameObject.GetComponent<blue>();
        // m_meshrenderer = gameObject.GetComponent<green>();
        pink = GameObject.Find("pink");
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
        // if (collision.gameObject.name == "blue")
        // {
        //     p1 = true;

        //     blue.material.color = new Color(255,69,0);
        // }
        // if (collision.gameObject.name == "green")
        // {
        //     p2 = true;

        //     green.material.color = new Color(255,69,0);
        // }
        if (collision.gameObject.name == "book")
        {
            p3 = true;
            // pink.material.color = new Color(255,69,0);
            pink.GetComponent<MeshRenderer>().material = orange;
        }
    }
}
