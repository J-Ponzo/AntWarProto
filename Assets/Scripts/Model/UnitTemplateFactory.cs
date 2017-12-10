using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitTemplateInitializer {
    public static void InitTemplate(Cast cast, GameObject template)
    {
        AgentBehavior agentBehavior = template.GetComponent<AgentBehavior>();
        agentBehavior.BehaviorModelIdentifier = cast.BehaviorModelIdentifier;
    }
}
