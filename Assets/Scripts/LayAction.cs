using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayAction : MonoBehaviour {
    // Workaround for script enabling issues
    public bool activated;

    [SerializeField]
    private string castName;

    public string CastName
    {
        get
        {
            return castName;
        }

        set
        {
            castName = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!activated)
        {
            return;
        }
	}
}
