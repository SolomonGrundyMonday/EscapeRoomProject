using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candleColor : MonoBehaviour
{

    // private bool p1 = false;
    private bool p2 = false;
    // private bool p3 = false;
    private GameObject green;

    public Material orange;

	void Start()
    {
        green = GameObject.Find("green");

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
    	Debug.Log("collider triggered");
        // if (collision.gameObject.name == "blue")
        // {
        //     p1 = true;

        //     blue.material.color = new Color(255,69,0);
        // }
        if (collision.gameObject.name == "candle")
        {
            p2 = true;
            Debug.Log("made it here");

            // Renderer shade = GetComponent<Renderer>();
            // shade.material.SetColor("color", new Color(255,69,0), 0);

            green.GetComponent<MeshRenderer>().material = orange;
        }
        // else if (collision.gameObject.name == "pink")
        // {
        //     p3 = true;
        //     pink.material.color = new Color(255,69,0);
        // }
    }
}
