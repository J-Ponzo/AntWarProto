using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cast {
    private string behaviorModelIdentifier;
    private List<CastComponent> head = new List<CastComponent>();
    private List<CastComponent> tail = new List<CastComponent>();

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

    public List<CastComponent> Head
    {
        get
        {
            return head;
        }

        set
        {
            head = value;
        }
    }

    public List<CastComponent> Tail
    {
        get
        {
            return tail;
        }

        set
        {
            tail = value;
        }
    }
}
