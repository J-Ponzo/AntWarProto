using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class BoolAndBoolBool_Op_Test {

	private string symbol = "B&&BB";
	private int nbTests = 100;

	/// <summary>
	/// Create an operator based on the list of parameters
	/// </summary>
	/// <returns>The operator</returns>
	/// <param name="param">Parameters that will compose the operator</param>
	private AB_Bool_And_Bool_Bool_Operator getOperator( params object[] param ){

		//Build test operator
		ABContext ctx = new ABContext();
		AB_Bool_And_Bool_Bool_Operator ope = (AB_Bool_And_Bool_Bool_Operator)ABOperatorFactory.CreateOperator(symbol);

		// creating params
		if( param.Length > 0 ){
			bool argParam = (bool)param[0];
			ABParam<ABBool> arg = ABParamFactory.CreateBoolParam("const", argParam);
			ope.Inputs[0] = arg;
		}
		if( param.Length > 1 ){
			bool argParam = (bool)param[1];
			ABParam<ABBool> arg = ABParamFactory.CreateBoolParam("const", argParam);
			ope.Inputs[1] = arg;
		}

		return ope;
	}

	#region TESTS
	[Test]
	public void BoolAndBoolBool_Op_Test_basic01() {
		// Test values
		bool expected = true;
		bool arg1 = true;
		bool arg2 = true;

		// Create operator
		AB_Bool_And_Bool_Bool_Operator ope = getOperator( arg1, arg2 );
		// Test operator
		Assert.AreEqual( expected, ope.Evaluate( null ).Value );
	}

	[Test]
	public void BoolAndBoolBool_Op_Test_basic02() {
		// Test values
		bool expected = false;
		bool arg1 = false;
		bool arg2 = true;

		// Create operator
		AB_Bool_And_Bool_Bool_Operator ope = getOperator( arg1, arg2 );
		// Test operator
		Assert.AreEqual( expected, ope.Evaluate( null ).Value );
	}

	[Test]
	public void BoolAndBoolBool_Op_Test_basic03() {
		// Test values
		bool expected = false;
		bool arg1 = true;
		bool arg2 = false;

		// Create operator
		AB_Bool_And_Bool_Bool_Operator ope = getOperator( arg1, arg2 );
		// Test operator
		Assert.AreEqual( expected, ope.Evaluate( null ).Value );
	}

	[Test]
	public void BoolAndBoolBool_Op_Test_basic04() {
		// Test values
		bool expected = false;
		bool arg1 = false;
		bool arg2 = false;

		// Create operator
		AB_Bool_And_Bool_Bool_Operator ope = getOperator( arg1, arg2 );
		// Test operator
		Assert.AreEqual( expected, ope.Evaluate( null ).Value );
	}

	[Test]
	public void BoolAndBoolBool_Op_Test_emptyArgs() {
		try{
			// Create operator
			AB_Bool_And_Bool_Bool_Operator ope = getOperator();
			ope.Evaluate( null );
		}
		catch( System.Exception ){
			// If an exception occurs, the test is succeeded
			Assert.Pass();
		}
		// If an exception does occur, the test is failed
		Assert.Fail();
	}

	[Test]
	public void BoolAndBoolBool_Op_Test_arg1Null() {
		// Test values
		bool arg2 = true;

		try{
			AB_Bool_And_Bool_Bool_Operator ope = getOperator( null, arg2 );
			ope.Evaluate( null );
		}
		catch( System.Exception ){
			// If an exception occurs, the test is succeeded
			Assert.Pass();
		}
		// If an exception does occur, the test is failed
		Assert.Fail();
	}

	[Test]
	public void BoolAndBoolBool_Op_Test_arg2Null() {
		// Test values
		bool arg1 = true;

		try{
			AB_Bool_And_Bool_Bool_Operator ope = getOperator( arg1, null );
			ope.Evaluate( null );
		}
		catch( System.Exception ){
			// If an exception occurs, the test is succeeded
			Assert.Pass();
		}
		// If an exception does occur, the test is failed
		Assert.Fail();
	}
	#endregion
}
