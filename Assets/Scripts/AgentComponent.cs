using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentComponent : MonoBehaviour {
    //Generic
    [SerializeField]
    private float id;
    [SerializeField]
    private string name;
    [SerializeField]
    private Color32 color;
    [SerializeField]
    private float prodCost;
    [SerializeField]
    private float buyCost;

    //Passive Buffs
    [SerializeField]
    private float moveSpeedBuff;
    [SerializeField]
    private float actionSpeedBuff;
    [SerializeField]
    private float strengthBuff;
    [SerializeField]
    private float vitalityBuff;
    [SerializeField]
    private float staminaBuff;
    [SerializeField]
    private float visionRangeBuff;
    [SerializeField]
    private float vibrationRangeBuff;
    [SerializeField]
    private float heatRangeBuff;
    [SerializeField]
    private float smellRangeBuff;
    [SerializeField]
    private bool visionIndetectable;
    [SerializeField]
    private bool vibrationIndetectable;
    [SerializeField]
    private bool heatIndetectable;
    [SerializeField]
    private bool smellIndetectable;

    //Actions
    private bool enableGotoHold;
    [SerializeField]
    private bool enableStrike;
    [SerializeField]
    private bool enablePickDrop;
    [SerializeField]
    private bool enableLay;

    //Sensors
    [SerializeField]
    private float visionRange;
    [SerializeField]
    private float vibrationRange;
    [SerializeField]
    private float heatRange;
    [SerializeField]
    private float smellRange;

    //Not handled
    [SerializeField]
    private List<String> notHandledTokens = new List<String>();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
