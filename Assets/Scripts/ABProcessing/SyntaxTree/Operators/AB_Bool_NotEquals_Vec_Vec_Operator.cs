using System;

public class AB_Bool_NotEquals_Vec_Vec_Operator : ABOperator<ABBool>
{
    private const float EPS = 0.001f;

    public AB_Bool_NotEquals_Vec_Vec_Operator()
    {
        this.Inputs = new ABNode[2];
    }

    public override ABBool Evaluate(ABContext context)
    {
        //Get v1
        ABVec v1 = null;
        ABNode input1 = Inputs[0];
        if (input1 is ABOperator<ABVec>)
        {
            ABOperator<ABVec> abOperator = (ABOperator<ABVec>)input1;
            v1 = abOperator.Evaluate(context);
        }
        else if (input1 is ABParam<ABVec>)
        {
            ABParam<ABVec> param = (ABParam<ABVec>)input1;
            v1 = param.Evaluate(context);
        }

        //Get v2
        ABVec v2 = null;
        ABNode input2 = Inputs[1];
        if (input2 is ABOperator<ABVec>)
        {
            ABOperator<ABVec> abOperator = (ABOperator<ABVec>)input2;
            v2 = abOperator.Evaluate(context);
        }
        else if (input2 is ABParam<ABVec>)
        {
            ABParam<ABVec> param = (ABParam<ABVec>)input2;
            v2 = param.Evaluate(context);
        }

        //Result
        ABBool result = TypeFactory.CreateEmptyBool();
        float x = v2.X - v1.X;
        float y = v2.Y - v1.Y;
        float dist = (float) Math.Sqrt(x * x + y * y);
        result.Value = ! (dist < EPS);

        return result;
    }
}