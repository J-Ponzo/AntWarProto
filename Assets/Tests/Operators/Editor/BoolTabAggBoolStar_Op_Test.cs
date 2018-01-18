﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class BoolTabAggBoolStar_Op_Test {

	private string symbol = "B[]aggB*";

	/// <summary>
	/// Create an operator based on the list of parameters (correct type)
	/// </summary>
	/// <returns>The operator</returns>
	/// <param name="param">Parameters that will compose the operator</param>
	private AB_BoolTab_Agg_BoolStar_Operator getOperator( params object[] parameters ){

		// Generate a list of ABParams based on the params
		ABParam<ABBool>[] listParams = new ABParam<ABBool>[ parameters.Length ];
		for( int i = 0; i < parameters.Length; i++ ){
			bool argParam = (bool)parameters[i];
			listParams[i] = ABParamFactory.CreateBoolParam( "const", argParam );
		}

		// Create an operator and associates it to the params
		return Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, listParams );
	}

	/// <summary>
	/// Gets the AB parameter tab from array.
	/// </summary>
	/// <returns>The AB parameter tab from array.</returns>
	/// <param name="parameters">Parameters.</param>
	private ABNode getABParamTab_fromArray( params object[] parameters ){
		bool[] table = new bool[parameters.Length];
		for( int i = 0; i < parameters.Length; i++ ){
			table[i] = (bool)parameters[i];
		}
		return (ABNode)ABParamFactory.CreateBoolTableParam( "table", table );
	}

	#region TESTS
	[Test]
	public void Test_basic01() {
		// Test values
		bool[] expected = {true};
		bool arg1 = true;

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = getOperator( arg1 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_basic02() {
		// Test values
		bool[] expected = {false};
		bool arg1 = false;

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = getOperator( arg1 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_basic03() {
		// Test values
		bool[] expected = {true,false};
		bool arg1 = true;
		bool arg2 = false;

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = getOperator( arg1 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_array01() {
		// Test values
		bool[] expected = {true,false};
		ABNode arg1 = getABParamTab_fromArray( true, false );

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_array02() {
		// Test values
		bool[] expected = {true,false,false,true};
		ABNode arg1 = getABParamTab_fromArray( true, false );
		ABNode arg2 = getABParamTab_fromArray( false, true );

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1, arg2 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_array03() {
		// Test values
		bool[] expected = {true,false};
		ABNode arg1 = getABParamTab_fromArray( true );
		ABNode arg2 = ABParamFactory.CreateBoolParam( "const", false );

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1, arg2 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_array04() {
		// Test values
		bool[] expected = {true,false};
		ABNode arg1 = ABParamFactory.CreateBoolParam( "const", true );
		ABNode arg2 = getABParamTab_fromArray( false );

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1, arg2 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_emptyArgs() {
		// Test values
		bool[] expected = {};

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = getOperator();
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_emptyArgs1() {
		// Test values
		bool[] expected = {};
		// empty array
		ABNode arg1 = getABParamTab_fromArray();

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_emptyArgs2() {
		// Test values
		bool[] expected = {true};
		// bool
		ABNode arg1 = ABParamFactory.CreateBoolParam( "const", true );
		// empty array
		ABNode arg2 = getABParamTab_fromArray();

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1, arg2 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_emptyArgs3() {
		// Test values
		bool[] expected = {true};
		// bool[]
		ABNode arg1 = getABParamTab_fromArray( true );
		// empty array
		ABNode arg2 = getABParamTab_fromArray();

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1, arg2 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_arg1Null() {
		// Test values
		bool[] expected = {};
		// null
		ABNode arg1 = null;

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_arg2Null() {
		// Test values
		bool[] expected = {true};
		// bool
		ABNode arg1 = ABParamFactory.CreateBoolParam( "const", true );
		// null
		ABNode arg2 = null;

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1, arg2 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}

	[Test]
	public void Test_arg2Null2() {
		// Test values
		bool[] expected = {true};
		// bool[]
		ABNode arg1 = getABParamTab_fromArray( true );
		// null
		ABNode arg2 = null;

		// Create operator
		AB_BoolTab_Agg_BoolStar_Operator ope = Operator_Test<AB_BoolTab_Agg_BoolStar_Operator>.getOperator_ABParams( symbol, arg1, arg2 );
		// Test operator
		ABBool[] result = ope.Evaluate( null ).Values;
		Assert.AreEqual( expected.Length, result.Length );
		for( int i = 0; i < expected.Length; i++ ){
			Assert.AreEqual( expected[i], result[i].Value );
		}
	}
	#endregion
}
