using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cast {
    private string behaviorModelIdentifier;
    private SlotComponent head;
    private SlotComponent arms;
    private SlotComponent body;
    private SlotComponent legs;
    private SlotComponent queue;
    private SlotComponent none1;
    private SlotComponent none2;
    private SlotComponent none3;

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
}
