using System.Collections;
using System.Collections.Generic;

public class AB_VecTab_Get_RefTab_Txt_Operator : ABOperator<ABTable<ABVec>> {

    public AB_VecTab_Get_RefTab_Txt_Operator()
    {
        this.Inputs = new ABNode[2];
    }

    public override ABTable<ABVec> Evaluate(ABContext context)
    {
        ABTable<ABRef> tab = null;
        ABNode input1 = Inputs[0];
        if (input1 is ABOperator<ABTable<ABRef>>)
        {
            ABOperator<ABTable<ABRef>> abOperator = (ABOperator<ABTable<ABRef>>)input1;
            tab = abOperator.Evaluate(context);
        }
        else if (input1 is ABParam<ABRef>)
        {
            ABParam<ABTable<ABRef>> param = (ABParam<ABTable<ABRef>>)input1;
            tab = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        ABText t = null;
        ABNode input2 = Inputs[1];
        if (input2 is ABOperator<ABText>)
        {
            ABOperator<ABText> abOperator = (ABOperator<ABText>)input2;
            t = abOperator.Evaluate(context);
        }
        else if (input2 is ABParam<ABText>)
        {
            ABParam<ABText> param = (ABParam<ABText>)input2;
            t = param.Evaluate(context);
        }
        else
        {
            throw new System.NotSupportedException();
        }

        //Build then return Result
        ABVec[] values = new ABVec[tab.Values.Length];
        for (int i = 0; i < tab.Values.Length; i++)
        {
            values[i] = (ABVec) tab.Values[i].GetAttr(t.Value);
        }
        ABTable<ABVec> result = TypeFactory.CreateEmptyTable<ABVec>();
        result.Values = values;
        return result;
    }
}
