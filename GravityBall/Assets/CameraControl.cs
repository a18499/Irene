using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
    public Transform target;
    public int relativeHeight = 10;
    public int zDistance = 1;
    public int dampSpeed = 1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = target.position + new Vector3(0, relativeHeight, -zDistance);
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * dampSpeed);
    }
}
