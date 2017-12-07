using System;

public class AB_Bool_LessThan_Scal_Scal_Operator : ABOperator<ABBool>
{
    public AB_Bool_LessThan_Scal_Scal_Operator()
    {
        this.Inputs = new ABNode[2];
    }

    public override ABBool Evaluate(ABContext context)
    {
        //Get s1
        ABScalar s1 = null;
        ABNode input1 = Inputs[0];
        if (input1 is ABOperator<ABScalar>)
        {
            ABOperator<ABScalar> abOperator = (ABOperator<ABScalar>)input1;
            s1 = abOperator.Evaluate(context);
        }
        else if (input1 is ABParam<ABScalar>)
        {
            ABParam<ABScalar> param = (ABParam<ABScalar>)input1;
            s1 = param.Evaluate(context);
        }

        //Get s2
        ABScalar s2 = null;
        ABNode input2 = Inputs[1];
        if (input2 is ABOperator<ABScalar>)
        {
            ABOperator<ABScalar> abOperator = (ABOperator<ABScalar>)input2;
            s2 = abOperator.Evaluate(context);
        }
        else if (input2 is ABParam<ABScalar>)
        {
            ABParam<ABScalar> param = (ABParam<ABScalar>)input2;
            s2 = param.Evaluate(context);
        }

        //Return
        ABBool result = TypeFactory.CreateEmptyBool();
        result.Value = s1.Value < s2.Value;
        return result;
    }
}