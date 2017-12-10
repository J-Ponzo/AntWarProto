using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveScript : MonoBehaviour {
    [AttrName(Identifier = "pos")]
    [SerializeField]
    private Vector2 location;
    [SerializeField]
    private float redResAmout;
    [SerializeField]
    private float greenResAmout;
    [SerializeField]
    private float blueResAmout;

    public float RedResAmout
    {
        get
        {
            return redResAmout;
        }

        set
        {
            redResAmout = value;
        }
    }

    public float GreenResAmout
    {
        get
        {
            return greenResAmout;
        }

        set
        {
            greenResAmout = value;
        }
    }

    public float BlueResAmout
    {
        get
        {
            return blueResAmout;
        }

        set
        {
            blueResAmout = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        location.x = this.transform.position.x;
        location.y = this.transform.position.y;
    }
}
