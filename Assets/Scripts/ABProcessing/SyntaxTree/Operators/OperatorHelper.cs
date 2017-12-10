﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorHelper : MonoBehaviour
{

    private static OperatorHelper instance;

    // Static singleton property
    public static OperatorHelper Instance
    {
        // Here we use the ?? operator, to return 'instance' if 'instance' does not equal null
        // otherwise we assign instance to a new component and return that
        get { return instance ?? (instance = new GameObject("OperatorHelper").AddComponent<OperatorHelper>()); }
    }


    public ABScalar getScalarParam(ABContext context, ABNode input)
    {
        ABScalar s1 = null;
        if (input is ABOperator<ABScalar>)
        {
            ABOperator<ABScalar> abOperator = (ABOperator<ABScalar>)input;
            s1 = abOperator.Evaluate(context);
        }
        else if (input is ABParam<ABScalar>)
        {
            ABParam<ABScalar> param = (ABParam<ABScalar>)input;
            s1 = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        return s1;
    }

    public ABVec getVecParam(ABContext context, ABNode input)
    {
        ABVec v1 = null;
        if (input is ABOperator<ABVec>)
        {
            ABOperator<ABVec> abOperator = (ABOperator<ABVec>)input;
            v1 = abOperator.Evaluate(context);
        }
        else if (input is ABParam<ABVec>)
        {
            ABParam<ABVec> param = (ABParam<ABVec>)input;
            v1 = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        return v1;
    }

    public ABTable<ABScalar> getTabScalarParam(ABContext context, ABNode input)
    {
        ABTable<ABScalar> tab = null;

        if (input is ABOperator<ABTable<ABScalar>>)
        {
            ABOperator<ABTable<ABScalar>> abOperator = (ABOperator<ABTable<ABScalar>>)input;
            tab = abOperator.Evaluate(context);
        }
        else if (input is ABParam<ABTable<ABScalar>>)
        {
            ABParam<ABTable<ABScalar>> param = (ABParam<ABTable<ABScalar>>)input;
            tab = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        return tab;
    }

    public ABTable<ABVec> getTabVecParam(ABContext context, ABNode input)
    {
        ABTable<ABVec> tab = null;

        if (input is ABOperator<ABTable<ABVec>>)
        {
            ABOperator<ABTable<ABVec>> abOperator = (ABOperator<ABTable<ABVec>>)input;
            tab = abOperator.Evaluate(context);
        }
        else if (input is ABParam<ABTable<ABVec>>)
        {
            ABParam<ABTable<ABVec>> param = (ABParam<ABTable<ABVec>>)input;
            tab = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        return tab;
    }


    // NOT TESTED YET
    public ABRef getRefParam(ABContext context, ABNode input)
    {
        ABRef reference = null;

        if (input is ABOperator<ABRef>)
        {
            ABOperator<ABRef> abOperator = (ABOperator<ABRef>)input;
            reference = abOperator.Evaluate(context);
        }
        else if (input is ABParam<ABRef>)
        {
            ABParam<ABRef> param = (ABParam<ABRef>)input;
            reference = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        return reference;
    }

    // NOT TESTED YET
    public ABText getTextParam(ABContext context, ABNode input)
    {
        ABText identifier = null;

        if (input is ABOperator<ABText>)
        {
            ABOperator<ABText> abOperator = (ABOperator<ABText>)input;
            identifier = abOperator.Evaluate(context);
        }
        else if (input is ABParam<ABText>)
        {
            ABParam<ABText> param = (ABParam<ABText>)input;
            identifier = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }
        return identifier;
    }
}
