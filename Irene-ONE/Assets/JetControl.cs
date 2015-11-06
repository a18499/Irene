using UnityEngine;
using System.Collections;

public class JetControl : MonoBehaviour {
    public GameObject Bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 pos = gameObject.transform.position + new Vector3(0,0.7f,0);
            Instantiate(Bullet, pos, gameObject.transform.rotation);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            gameObject.transform.position += new Vector3(-0.1f,0,0);
        }
	}
}
