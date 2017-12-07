using System.Collections;
using System.Collections.Generic;

public class AB_Vec_Get_VecTab_Scal_Operator : ABOperator<ABVec> {
    public AB_Vec_Get_VecTab_Scal_Operator()
    {
        this.Inputs = new ABNode[2];
    }

    public override ABVec Evaluate(ABContext context)
    {
        ABTable<ABVec> tab = null;
        ABNode input1 = Inputs[0];
        if (input1 is ABOperator<ABTable<ABVec>>)
        {
            ABOperator<ABTable<ABVec>> abOperator = (ABOperator<ABTable<ABVec>>)input1;
            tab = abOperator.Evaluate(context);
        }
        else if (input1 is ABParam<ABTable<ABVec>>)
        {
            ABParam<ABTable<ABVec>> param = (ABParam<ABTable<ABVec>>)input1;
            tab = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        ABScalar s = null;
        ABNode input2 = Inputs[1];
        if (input2 is ABOperator<ABScalar>)
        {
            ABOperator<ABScalar> abOperator = (ABOperator<ABScalar>)input2;
            s = abOperator.Evaluate(context);
        }
        else if (input2 is ABParam<ABScalar>)
        {
            ABParam<ABScalar> param = (ABParam<ABScalar>)input2;
            s = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        //Build then return Result
        return tab.Values[(int) s.Value];
    }

}
