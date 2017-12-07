using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveScript : MonoBehaviour {
    [AttrName(Identifier = "pos")]
    [SerializeField]
    private Vector2 location;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        location.x = this.transform.position.x;
        location.y = this.transform.position.y;
    }
}
