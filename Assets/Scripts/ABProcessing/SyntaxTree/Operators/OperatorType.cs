﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OperatorType
{
    None,
    Bool_And_Bool_Bool,
    BoolTab_Agg_BoolStar,
    Bool_Equals_Bool_Bool,
    Bool_Get_Ref_Txt,
    BoolTab_GetRefTab_Txt,
    Bool_Get_BoolTab_Scal,
    Bool_IsSet_Bool,
    Bool_NotEquals_Bool_Bool,
    Scal_Size_BoolTab,
    ColorTab_Agg_CStar,
    Bool_Equals_Color_Color,
    Color_Get_Ref_Txt,
    ColorTab_Get_RefTab_Txt,
    Color_Get_ColorTab_Scal,
    Bool_IsSet_Color,
    Bool_NotEquals_Color_Color,
    Scal_Size_ColorTab,
    Scal_Dist_Vec_Vec,
    ScalTab_Dist_VecTab_Vec,
    Bool_GreaterThan_Scal_Scal,
    Bool_LessThan_Scal_Scal,
    Scal_MaxId_ScalTab,
    Scal_MaxVal_ScalTab,
    Scal_MinId_ScalTab,
    Scal_MinVal_ScalTab,
    Bool_Not_Bool,
    Bool_Or_Bool_Bool,
    Vec_RandCircle_Vec_Scal,
    Bool_RefEquals_Ref_Ref,
    RefTab_Agg_RefStar,
    Ref_Get_Ref_Txt,
    RefTab_Get_RefTab_Txt,
    Ref_Get_RefTab_Scal,
    Bool_IsSet_Ref,
    Bool_NotEquals_Ref_Ref,
    Scal_Size_RefTab,
    ScalTab_Agg_ScalStar,
    Scal_Div_Scal_Scal,
    Bool_Equals_Scal_Scal,
    Scal_Get_Ref_Txt,
    ScalTab_Get_RefTab_Txt,
    Scal_Get_ScalTab_Scal,
    Bool_IsSet_Scal,
    Bool_NotEquals_Scal_Scal,
    Scal_Prod_Scal_Scal,
    Scal_Size_ScalTab,
    Scal_Sub_Scal_Scal,
    Scal_Sum_Scal_Scal,
    TxtTab_Agg_TxtStar,
    Bool_Equals_Txt_Txt,
    Txt_Get_Ref_Txt,
    TxtTab_Get_RefTab_Txt,
    Txt_Get_TxtTab_Scal,
    Bool_IsSet_Txt,
    Bool_NotEquals_Txt_Txt,
    Scal_Size_TxtTab,
    VecTab_Agg_VecStar,
    Vec_Cross_Vec_Vec,
    Vec_Dot_Vec_Vec,
    Bool_Equals_Vec_Vec,
    Vec_Get_Ref_Txt,
    VecTab_Get_RefTab_Txt,
    Vec_Get_VecTab_Scal,
    Bool_IsSet_Vec,
    Bool_NotEquals_Vec_Vec,
    Vec_Prod_Vec_Scal,
    Vec_Prod_Scal_Vec,
    Scal_Size_VecTable,
    Vec_Sub_Vec_Vec,
    Vec_Sum_Vec_Vec,
    Vec_TermDiv_Vec_Vec,
    Vec_TermProd_Vec_Vec
}

//public enum OperatorType {
//    And,
//    Or,
//    Not,
//    BoolEquals,
//    BoolNotEquals,
//    ScalEquals,
//    ScalNotEquals,
//    TextEquals,
//    TextNotEquals,
//    VecEquals,
//    VecNotEquals,
//    ColorEquals,
//    ColorNotEquals,
//    RefEquals,
//    RefNotEquals,
//    GreaterThan,
//    LessThan,
//    MinId,
//    ScalSum,
//    ScalSub,
//    ScalProd,
//    ScalDiv,
//    VecSum,
//    VecSub,
//    VecTermProd,
//    VecTermDiv,
//    VecDot,
//    VecCross,
//    VecScalProdLeft,
//    VecScalProdRight,
//    Dist,
//    DistStar,
//    BoolIsSet,
//    ScalIsSet,
//    TextIsSet,
//    VecIsSet,
//    ColorIsSet,
//    RefIsSet,
//    BoolGet,
//    ScalGet,
//    TextGet,
//    VecGet,
//    VecGetFromRef,
//    VecGetStar,
//    ColorGet,
//    RefGet,
//    None,
//    RandCircle,
//}
