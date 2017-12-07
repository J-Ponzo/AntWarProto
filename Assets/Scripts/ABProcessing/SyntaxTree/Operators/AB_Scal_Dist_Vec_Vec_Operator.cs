using System;

public class AB_Scal_Dist_Vec_Vec_Operator : ABOperator<ABScalar>
{
    public AB_Scal_Dist_Vec_Vec_Operator()
    {
        this.Inputs = new ABNode[2];
    }

    public override ABScalar Evaluate(ABContext context)
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
        ABScalar result = TypeFactory.CreateEmptyScalar();
        float x = v2.X - v1.X;
        float y = v2.Y - v1.Y;
        result.Value = (float) Math.Sqrt(x * x + y * y);
        return result;
    }
}