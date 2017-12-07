using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABOperatorFactory {

    public static IABOperator CreateOperator(String typeStr)
    {
        OperatorType type = GetTypeFromStr(typeStr);
        return CreateOperator(type);
    }

    private static OperatorType GetTypeFromStr(string typeStr)
    {
        OperatorType type = OperatorType.None;

        switch (typeStr)
        {
            case "B&&BB":
                type = OperatorType.Bool_And_Bool_Bool;
                break;
            case "B==BB":
                type = OperatorType.Bool_Equals_Bool_Bool;
                break;
            case "BgetRT":
                type = OperatorType.Bool_Get_Ref_Txt;
                break;
            case "BisSetB":
                type = OperatorType.Bool_IsSet_Bool;
                break;
            case "B!=BB":
                type = OperatorType.Bool_NotEquals_Bool_Bool;
                break;
            case "B==CC":
                type = OperatorType.Bool_Equals_Color_Color;
                break;
            case "CgetRT":
                type = OperatorType.Color_Get_Ref_Txt;
                break;
            case "BisSetC":
                type = OperatorType.Bool_IsSet_Color;
                break;
            case "B!=CC":
                type = OperatorType.Bool_NotEquals_Color_Color;
                break;
            case "SdistVV":
                type = OperatorType.Scal_Dist_Vec_Vec;
                break;
            case "S[]distV[]V":
                type = OperatorType.ScalTab_Dist_VecTab_Vec;
                break;
            case "B>SS":
                type = OperatorType.Bool_GreaterThan_Scal_Scal;
                break;
            case "B<SS":
                type = OperatorType.Bool_LessThan_Scal_Scal;
                break;
            case "SminIdS[]":
                type = OperatorType.Scal_MinId_ScalTab;
                break;
            case "B!B":
                type = OperatorType.Bool_Not_Bool;
                break;
            case "B||BB":
                type = OperatorType.Bool_Or_Bool_Bool;
                break;
            case "VrandCircleVS":
                type = OperatorType.Vec_RandCircle_Vec_Scal;
                break;
            case "B==RR":
                type = OperatorType.Bool_RefEquals_Ref_Ref;
                break;
            case "RgetRT":
                type = OperatorType.Ref_Get_Ref_Txt;
                break;
            case "BisSetR":
                type = OperatorType.Bool_IsSet_Ref;
                break;
            case "B!=RR":
                type = OperatorType.Bool_NotEquals_Ref_Ref;
                break;
            case "S/SS":
                type = OperatorType.Scal_Div_Scal_Scal;
                break;
            case "B==SS":
                type = OperatorType.Bool_Equals_Scal_Scal;
                break;
            case "SgetRT":
                type = OperatorType.Scal_Get_Ref_Txt;
                break;
            case "BisSetS":
                type = OperatorType.Bool_IsSet_Scal;
                break;
            case "B!=SS":
                type = OperatorType.Bool_NotEquals_Scal_Scal;
                break;
            case "S*SS":
                type = OperatorType.Scal_Prod_Scal_Scal;
                break;
            case "S-SS":
                type = OperatorType.Scal_Sub_Scal_Scal;
                break;
            case "S+SS":
                type = OperatorType.Scal_Sum_Scal_Scal;
                break;
            case "B==TT":
                type = OperatorType.Bool_Equals_Txt_Txt;
                break;
            case "TgetRT":
                type = OperatorType.Txt_Get_Ref_Txt;
                break;
            case "BisSetT":
                type = OperatorType.Bool_IsSet_Txt;
                break;
            case "B!=TT":
                type = OperatorType.Bool_NotEquals_Txt_Txt;
                break;
            case "VXVV":
                type = OperatorType.Vec_Cross_Vec_Vec;
                break;
            case "S.VV":
                type = OperatorType.Vec_Dot_Vec_Vec;
                break;
            case "B==VV":
                type = OperatorType.Bool_Equals_Vec_Vec;
                break;
            case "VgetRT":
                type = OperatorType.Vec_Get_Ref_Txt;
                break;
            case "V[]getR[]T":
                type = OperatorType.VecTab_Get_RefTab_Txt;
                break;
            case "VgetV[]S":
                type = OperatorType.Vec_Get_VecTab_Scal;
                break;
            case "BisSetV":
                type = OperatorType.Bool_IsSet_Vec;
                break;
            case "B!=VV":
                type = OperatorType.Bool_NotEquals_Vec_Vec;
                break;
            case "V*VS":
                type = OperatorType.Vec_Prod_Vec_Scal;
                break;
            case "V*SV":
                type = OperatorType.Vec_Prod_Scal_Vec;
                break;
            case "V-VV":
                type = OperatorType.Vec_Sub_Vec_Vec;
                break;
            case "V+VV":
                type = OperatorType.Vec_Sum_Vec_Vec;
                break;
            case "V/VV":
                type = OperatorType.Vec_TermDiv_Vec_Vec;
                break;
            case "V*VV":
                type = OperatorType.Vec_TermProd_Vec_Vec;
                break;
            default:
                throw new NotImplementedException("Type " + typeStr + " not implemented");
        }

        return type;
    }

    public static IABOperator CreateOperator(OperatorType type)
    {
        IABOperator abOperator = null;
        switch (type)
        {
            case OperatorType.Bool_And_Bool_Bool:
                abOperator = new AB_Bool_And_Bool_Bool_Operator();
                break;
            case OperatorType.Bool_Equals_Bool_Bool:
                abOperator = new AB_Bool_Equals_Bool_Bool_Operator();
                break;
            case OperatorType.Bool_Get_Ref_Txt:
                abOperator = new AB_Bool_Get_Ref_Txt_Operator();
                break;
            case OperatorType.Bool_IsSet_Bool:
                abOperator = new AB_Bool_IsSet_Bool_Operator();
                break;
            case OperatorType.Bool_NotEquals_Bool_Bool:
                abOperator = new AB_Bool_NotEquals_Bool_Bool_Operator();
                break;
            case OperatorType.Bool_Equals_Color_Color:
                abOperator = new AB_Bool_Equals_Color_Color_Operator();
                break;
            case OperatorType.Color_Get_Ref_Txt:
                abOperator = new AB_Color_Get_Ref_Txt_Operator();
                break;
            case OperatorType.Bool_IsSet_Color:
                abOperator = new AB_Bool_IsSet_Color_Operator();
                break;
            case OperatorType.Bool_NotEquals_Color_Color:
                abOperator = new AB_Bool_NotEquals_Color_Color_Operator();
                break;
            case OperatorType.Scal_Dist_Vec_Vec:
                abOperator = new AB_Scal_Dist_Vec_Vec_Operator();
                break;
            case OperatorType.ScalTab_Dist_VecTab_Vec:
                abOperator = new AB_ScalTab_Dist_VecTab_Vec_Operator();
                break;
            case OperatorType.Bool_GreaterThan_Scal_Scal:
                abOperator = new AB_Bool_GreaterThan_Scal_Scal_Operator();
                break;
            case OperatorType.Bool_LessThan_Scal_Scal:
                abOperator = new AB_Bool_LessThan_Scal_Scal_Operator();
                break;
            case OperatorType.Scal_MinId_ScalTab:
                abOperator = new AB_Scal_MinId_ScalTab_Operator();
                break;
            case OperatorType.Bool_Not_Bool:
                abOperator = new AB_Bool_Not_Bool_Operator();
                break;
            case OperatorType.Bool_Or_Bool_Bool:
                abOperator = new AB_Bool_Or_Bool_Bool_Operator();
                break;
            case OperatorType.Vec_RandCircle_Vec_Scal:
                abOperator = new AB_Vec_RandCircle_Vec_Scal_Operator();
                break;
            case OperatorType.Bool_RefEquals_Ref_Ref:
                abOperator = new AB_Bool_RefEquals_Ref_Ref_Operator();
                break;
            case OperatorType.Ref_Get_Ref_Txt:
                abOperator = new AB_Ref_Get_Ref_Txt_Operator();
                break;
            case OperatorType.Bool_IsSet_Ref:
                abOperator = new AB_Bool_IsSet_Ref_Operator();
                break;
            case OperatorType.Bool_NotEquals_Ref_Ref:
                abOperator = new AB_Bool_NotEquals_Ref_Ref_Operator();
                break;
            case OperatorType.Scal_Div_Scal_Scal:
                abOperator = new AB_Scal_Div_Scal_Scal_Operator();
                break;
            case OperatorType.Bool_Equals_Scal_Scal:
                abOperator = new AB_Bool_Equals_Scal_Scal_Operator();
                break;
            case OperatorType.Scal_Get_Ref_Txt:
                abOperator = new AB_Scal_Get_Ref_Txt_Operator();
                break;
            case OperatorType.Bool_IsSet_Scal:
                abOperator = new AB_Bool_IsSet_Scal_Operator();
                break;
            case OperatorType.Bool_NotEquals_Scal_Scal:
                abOperator = new AB_Bool_NotEquals_Scal_Scal_Operator();
                break;
            case OperatorType.Scal_Prod_Scal_Scal:
                abOperator = new AB_Scal_Prod_Scal_Scal_Operator();
                break;
            case OperatorType.Scal_Sub_Scal_Scal:
                abOperator = new AB_Scal_Sub_Scal_Scal_Operator();
                break;
            case OperatorType.Scal_Sum_Scal_Scal:
                abOperator = new AB_Scal_Sum_Scal_Scal_Operator();
                break;
            case OperatorType.Bool_Equals_Txt_Txt:
                abOperator = new AB_Bool_Equals_Txt_Txt_Operator();
                break;
            case OperatorType.Txt_Get_Ref_Txt:
                abOperator = new AB_Txt_Get_Ref_Txt_Operator();
                break;
            case OperatorType.Bool_IsSet_Txt:
                abOperator = new AB_Bool_IsSet_Txt_Operator();
                break;
            case OperatorType.Bool_NotEquals_Txt_Txt:
                abOperator = new AB_Bool_NotEquals_Txt_Txt_Operator();
                break;
            case OperatorType.Vec_Cross_Vec_Vec:
                abOperator = new AB_Vec_Cross_Vec_Vec_Operator();
                break;
            case OperatorType.Vec_Dot_Vec_Vec:
                abOperator = new AB_Vec_Dot_Vec_Vec_Operator();
                break;
            case OperatorType.Bool_Equals_Vec_Vec:
                abOperator = new AB_Bool_Equals_Vec_Vec_Operator();
                break;
            case OperatorType.Vec_Get_Ref_Txt:
                abOperator = new AB_Vec_Get_Ref_Txt_Operator();
                break;
            case OperatorType.VecTab_Get_RefTab_Txt:
                abOperator = new AB_VecTab_Get_RefTab_Txt_Operator();
                break;
            case OperatorType.Vec_Get_VecTab_Scal:
                abOperator = new AB_Vec_Get_VecTab_Scal_Operator();
                break;
            case OperatorType.Bool_IsSet_Vec:
                abOperator = new AB_Bool_IsSet_Vec_Operator();
                break;
            case OperatorType.Bool_NotEquals_Vec_Vec:
                abOperator = new AB_Bool_NotEquals_Vec_Vec_Operator();
                break;
            case OperatorType.Vec_Prod_Vec_Scal:
                abOperator = new AB_Vec_Prod_Vec_Scal_Operator();
                break;
            case OperatorType.Vec_Prod_Scal_Vec:
                abOperator = new AB_Vec_Prod_Scal_Vec_Operator();
                break;
            case OperatorType.Vec_Sub_Vec_Vec:
                abOperator = new AB_Vec_Sub_Vec_Vec_Operator();
                break;
            case OperatorType.Vec_Sum_Vec_Vec:
                abOperator = new AB_Vec_Sum_Vec_Vec_Operator();
                break;
            case OperatorType.Vec_TermDiv_Vec_Vec:
                abOperator = new AB_Vec_TermDiv_Vec_Vec_Operator();
                break;
            case OperatorType.Vec_TermProd_Vec_Vec:
                abOperator = new AB_Vec_TermProd_Vec_Vec_Operator();
                break;
        }

        return abOperator;
    }
}
