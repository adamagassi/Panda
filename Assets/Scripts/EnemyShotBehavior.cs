using UnityEngine;
using System.Collections;

public class EnemyShotBehavior : MonoBehaviour {

	public GameObject Bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Bullet.GetComponent<Collider>()) {
			
		}
	}
}
