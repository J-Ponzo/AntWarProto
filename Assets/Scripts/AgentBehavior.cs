using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBehavior : MonoBehaviour
{
    /// <summary>
    /// Name of the ABM the agent engages in
    /// </summary>
    [SerializeField]
    private string behaviorModelIdentifier;

    /// <summary>
    /// The current Atomic Action being presseced by the agent
    /// </summary>
    private ABAction curAction;

    public string BehaviorModelIdentifier
    {
        get
        {
            return behaviorModelIdentifier;
        }

        set
        {
            behaviorModelIdentifier = value;
        }
    }

    public ABAction CurAction
    {
        get
        {
            return curAction;
        }

        set
        {
            curAction = value;
        }
    }

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
