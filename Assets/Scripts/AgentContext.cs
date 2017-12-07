using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentContext : MonoBehaviour
{
    [BindParam(Identifier = "testBool")]
    bool boolParam = true;
    [BindParam(Identifier = "testByte")]
    byte byteParam = 8;
    [BindParam(Identifier = "testShort")]
    short shortParam = -1;
    [BindParam(Identifier = "testInt")]
    int intParam = 3;
    [BindParam(Identifier = "testLong")]
    long longParam = 1024;
    [BindParam(Identifier = "testFloat")]
    float floatParam = 5.2f;
    [BindParam(Identifier = "testDouble")]
    double doubleParam = -5.12547;
    [BindParam(Identifier = "testString")]
    string stringParam = "hello world!";
    [BindParam(Identifier = "testVector2")]
    Vector2 vec2Param = new Vector2(0, 1);

    [BindParam(Identifier = "testBool[]")]
    bool[] boolParamTab = new bool[3];
    [BindParam(Identifier = "testByte[]")]
    byte[] byteParamTab = new byte[3];
    [BindParam(Identifier = "testShort[]")]
    short[] shortParamTab = new short[3];
    [BindParam(Identifier = "testInt[]")]
    int[] intParamTab = new int[3];
    [BindParam(Identifier = "testLong[]")]
    long[] longParamTab = new long[3];
    [BindParam(Identifier = "testFloat[]")]
    float[] floatParamTab = new float[3];
    [BindParam(Identifier = "testDouble[]")]
    double[] doubleParamTab = new double[3];
    [BindParam(Identifier = "testString[]")]
    string[] stringParamTab = new string[3];
    [BindParam(Identifier = "testVector2[]")]
    Vector2[] vec2ParamTab = new Vector2[3];

    [BindParam(Identifier = "prey")]
    [SerializeField]
    public GameObject locust;
    [BindParam(Identifier = "preys")]
    [SerializeField]
    public GameObject[] locusts;
    [BindParam(Identifier = "curPos")]
    [SerializeField]
    public Vector2 location;
    [BindParam(Identifier = "trgPos")]
    [SerializeField]
    public Vector2 targetPt;
    [BindParam(Identifier = "home")]
    [SerializeField]
    public GameObject hive;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
