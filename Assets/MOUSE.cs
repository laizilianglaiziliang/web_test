using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOUSE : MonoBehaviour {
   public GameObject a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            a.transform.localScale = new Vector3(0, 0, 0);
        }
        if (Input.GetMouseButtonDown(1))
        {
            a.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
