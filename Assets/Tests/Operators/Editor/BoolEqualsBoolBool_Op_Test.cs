using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class BoolEqualsBoolBool_Op_Test {

	private string symbol = "B==BB";

	/// <summary>
	/// Create an operator based on the list of parameters (correct type)
	/// </summary>
	/// <returns>The operator</returns>
	/// <param name="param">Parameters that will compose the operator</param>
	private AB_Bool_Equals_Bool_Bool_Operator getOperator( params object[] parameters ){

		// Generate a list of ABParams based on the params
		ABParam<ABBool>[] listParams = new ABParam<ABBool>[ parameters.Length ];
		// creating params
		if( parameters.Length > 0 ){
			bool argParam = (bool)parameters[0];
			listParams[0] = ABParamFactory.CreateBoolParam("const", argParam);
		}
		if( parameters.Length > 1 ){
			bool argParam = (bool)parameters[1];
			listParams[1] = ABParamFactory.CreateBoolParam("const", argParam);
		}

		// Create an operator and associates it to the params
		return Operator_Test<AB_Bool_Equals_Bool_Bool_Operator>.getOperator_ABParams( symbol, listParams );
	}

	#region TESTS
	[Test]
	public void Test_basic01() {
		// Test values
		bool expected = true;
		bool arg1 = true;
		bool arg2 = true;

		// Create operator
		AB_Bool_Equals_Bool_Bool_Operator ope = getOperator( arg1, arg2 );
		// Test operator
		Assert.AreEqual( expected, ope.Evaluate( null ).Value );
	}

	[Test]
	public void Test_basic02() {
		// Test values
		bool expected = false;
		bool arg1 = false;
		bool arg2 = true;

		// Create operator
		AB_Bool_Equals_Bool_Bool_Operator ope = getOperator( arg1, arg2 );
		// Test operator
		Assert.AreEqual( expected, ope.Evaluate( null ).Value );
	}

	[Test]
	public void Test_basic03() {
		// Test values
		bool expected = false;
		bool arg1 = true;
		bool arg2 = false;

		// Create operator
		AB_Bool_Equals_Bool_Bool_Operator ope = getOperator( arg1, arg2 );
		// Test operator
		Assert.AreEqual( expected, ope.Evaluate( null ).Value );
	}

	[Test]
	public void Test_basic04() {
		// Test values
		bool expected = true;
		bool arg1 = false;
		bool arg2 = false;

		// Create operator
		AB_Bool_Equals_Bool_Bool_Operator ope = getOperator( arg1, arg2 );
		// Test operator
		Assert.AreEqual( expected, ope.Evaluate( null ).Value );
	}

	[Test]
	public void Test_emptyArgs() {
		try{
			// Create operator
			AB_Bool_Equals_Bool_Bool_Operator ope = getOperator();
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
	public void Test_arg1Null() {
		// Test values
		bool arg2 = true;

		try{
			AB_Bool_Equals_Bool_Bool_Operator ope = getOperator( null, arg2 );
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
	public void Test_arg2Null() {
		// Test values
		bool arg1 = true;

		try{
			AB_Bool_Equals_Bool_Bool_Operator ope = getOperator( arg1, null );
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
