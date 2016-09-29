using UnityEngine;
using System.Collections;

public class ExampleBehavScript : MonoBehaviour {
	int myInt = 10;
	// Use this for initialization
	void Start () {
		Debug.Log (MultiplyByTwo(myInt));

	}

	int MultiplyByTwo(int num){
		return num * 2;
	}
	// Update is called once per frame
	void Update () {
		Debug.Log (Time.deltaTime);
		Debug.Log (transform.position.y);
		if(Input.GetKeyDown(KeyCode.R)){
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		if(Input.GetKeyDown(KeyCode.G)){
			gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		if(Input.GetKeyDown(KeyCode.B)){
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}

	void FixedUpdate(){
		Debug.Log (Time.deltaTime);

	}
}
