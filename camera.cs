using UnityEngine;
using System.Collections;

public class camera_dep : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position;
	}
}
