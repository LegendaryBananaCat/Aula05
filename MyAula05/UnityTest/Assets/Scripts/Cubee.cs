using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubee : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Hello stranger...");
        transform.localScale = new Vector3(3, 5, 3);
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 rot = new Vector3(0.1f, 0.5f, 0.1f);

        transform.Rotate(rot);
	}
}
