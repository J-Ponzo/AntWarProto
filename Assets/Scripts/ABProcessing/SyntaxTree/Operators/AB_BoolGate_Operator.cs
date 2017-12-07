using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB_BoolGate_Operator : ABGateOperator<ABBool>
{
    public override ABBool Evaluate(ABContext context)
    {
        ABNode node = Inputs[0];
        if (node is ABOperator<ABBool>)
        {
            ABOperator<ABBool> abOperator = (ABOperator<ABBool>)node;
            return abOperator.Evaluate(context);
        }
        else if (node is ABParam<ABBool>)
        {
            ABParam<ABBool> param = (ABParam<ABBool>)node;
            return param.Evaluate(context);
        }
        else
        {
            throw new NotSupportedException();
        }
    }
}
