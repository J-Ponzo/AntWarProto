using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public abstract class Operator_Test<OperatorType> where OperatorType:IABOperator {
	/// <summary>
	/// Create an operator based on the list of ABParams
	/// </summary>
	/// <returns>The operator</returns>
	/// <param name="operatorSymbol">string that represents the operator</param>
	/// <param name="parameters">ABParam parameters that will compose the operator</param>
	public static OperatorType getOperator_ABParams( string operatorSymbol, params ABNode[] parameters ){

		//Build test operator
		ABContext ctx = new ABContext();
		OperatorType ope = (OperatorType)ABOperatorFactory.CreateOperator(operatorSymbol);
		ope.Inputs = parameters;

		return ope;
	}
}
