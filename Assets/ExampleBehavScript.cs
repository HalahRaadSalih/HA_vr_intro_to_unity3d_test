using UnityEngine;
using System.Collections;

public class ExampleBehavScript : MonoBehaviour {
	int myInt = 10;
	private Light myLight;
	// Use this for initialization
	void Start () {
		Debug.Log (MultiplyByTwo(myInt));
		myLight = gameObject.GetComponent<Light>();


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
		if(Input.GetKeyDown(KeyCode.Space)){
			myLight.enabled = !myLight.enabled;
		}
	}

	void FixedUpdate(){
		Debug.Log (Time.deltaTime);

	}
}
