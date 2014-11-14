using UnityEngine;
using System.Collections;

public class deplacement : MonoBehaviour {

	public float speed = 5.5f;
	public float jump = 6.5f;

	private bool coli = false; // test de colissions pour jump

	// Use this for initialization
	void Start () {
		print("Objet initialisé !");
	}
	
	// Update is called once per frame
	void Update () {

		deplacements();
	
	}

	void OnCollisionEnter(Collision col)// quand il ya une colli
	{
		coli = true;
	}

	public void deplacements()
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0, 0, speed)* Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0, 0, -speed)* Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(speed, 0, 0)* Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-speed, 0, 0)* Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.Space))
		{
			if(coli)// test de coli pour jump
			{
				rigidbody.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
				coli = false;
			}
		}
	}
}
