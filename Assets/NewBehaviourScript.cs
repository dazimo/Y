using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    void OnMouseDown()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
