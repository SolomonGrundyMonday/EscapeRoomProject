using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{


	private MeshRenderer m_meshrenderer;

	// Use this for initialization
	void Start()
	{
		m_meshrenderer = gameObject.GetComponent<MeshRenderer>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter(Collision other)
	{
		m_meshrenderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
	}
}