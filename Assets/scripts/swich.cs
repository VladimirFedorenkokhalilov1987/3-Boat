using UnityEngine;
using System.Collections;

public class swich : MonoBehaviour {

	public GameObject _boat;
	public GameObject _boatCamera;
	public GameObject _player;
	public GameObject _playerStPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//set to boat mode//
		if (Input.GetKey ("1")) {
			_boat.GetComponent<Rigidbody>().isKinematic=false;
			_boat.GetComponent<boat> ().enabled = true;
			_boatCamera.SetActive (true);
			_player.SetActive (false);
		}

		//set to FPS mode//
		if (Input.GetKey ("2")) {
			_boat.GetComponent<Rigidbody>().isKinematic=true;
			_boatCamera.SetActive (false);
			_boat.GetComponent<boat> ().enabled = false;
			_player.SetActive (true);
			_player.transform.position = _playerStPos.transform.position;



		}
	}
}
