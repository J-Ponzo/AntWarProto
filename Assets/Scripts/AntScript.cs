using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntScript : MonoBehaviour {
    [SerializeField]
    private AgentContext context;

    // Use this for initialization
    void Awake()
    {
        context = this.GetComponent<AgentContext>();
    }

    void Start()
    {
        context.location.x = this.transform.position.x;
        context.location.y = this.transform.position.y;
    }

    // Update is called once per frame
    void Update () {
        context.location.x = this.transform.position.x;
        context.location.y = this.transform.position.y;
    }
}
