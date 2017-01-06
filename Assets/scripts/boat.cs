using UnityEngine;
using System.Collections;

public class boat : MonoBehaviour {
	public float _turnSpeed =1000f;
	public float _accelerateSpeed =1000f;
	private Rigidbody _rbody;

	void Start () {
	
		_rbody = GetComponent<Rigidbody> ();

	}
	
	void Update ()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		_rbody.AddTorque (0f, h * _turnSpeed * Time.deltaTime, 0f);
		_rbody.AddForce (transform.forward * _accelerateSpeed * v * Time.deltaTime);
	}
}
