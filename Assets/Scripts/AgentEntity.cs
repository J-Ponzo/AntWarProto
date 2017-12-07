using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentEntity : MonoBehaviour
{
    [SerializeField]
    private int id;
    [SerializeField]
    private AgentBehavior behaviour;
    [SerializeField]
    private AgentContext context;

    public AgentBehavior Behaviour
    {
        get
        {
            return behaviour;
        }

        set
        {
            behaviour = value;
        }
    }

    public AgentContext Context
    {
        get
        {
            return context;
        }

        set
        {
            context = value;
        }
    }

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    // Use this for initialization
    void Awake()
    {
        behaviour = this.GetComponent<AgentBehavior>();
        context = this.GetComponent<AgentContext>();
    }

    void Start()
    {
        ABManager.instance.RegisterAgent(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
