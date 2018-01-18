using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentScript : MonoBehaviour {
    [AttrName(Identifier = "cast")]
    [SerializeField]
    private string cast;
    [AttrName(Identifier = "curPos")]
    [SerializeField]
    private Vector2 curPos;
    [AttrName(Identifier = "trgPos")]
    [SerializeField]
    private Vector2 trgPos;
    [AttrName(Identifier = "vitalityMax ")]
    [SerializeField]
    private float vitalityMax;
    [AttrName(Identifier = "vitality ")]
    [SerializeField]
    private float vitality;
    [AttrName(Identifier = "strength ")]
    [SerializeField]
    private float strength;
    [AttrName(Identifier = "stamina ")]
    [SerializeField]
    private float stamina;
    [AttrName(Identifier = "actSpd ")]
    [SerializeField]
    private float actSpd;
    [AttrName(Identifier = "moveSpd ")]
    [SerializeField]
    private float moveSpd;
    [AttrName(Identifier = "nbItemMax ")]
    [SerializeField]
    private int nbItemMax;
    [AttrName(Identifier = "nbItem ")]
    [SerializeField]
    private int nbItem;
    [AttrName(Identifier = "atkRange ")]
    [SerializeField]
    private float atkRange;
    [AttrName(Identifier = "pickRange ")]
    [SerializeField]
    private Vector2 pickRange;

    // Use this for initialization
    void Start () {
        curPos = new Vector3(transform.position.x, transform.position.z);
        trgPos = curPos;
    }
	
	// Update is called once per frame
	void Update () {
        curPos = new Vector3(transform.position.x, transform.position.z);
    }
}
