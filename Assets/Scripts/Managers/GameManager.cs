﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour {
    /// <summary>
    /// The static instance of the Singleton for external access
    /// </summary>
    public static GameManager instance = null;

    /// <summary>
    /// Enforce Singleton properties
    /// </summary>
    void Awake()
    {
        //Check if instance already exists and set it to this if not
        if (instance == null)
        {
            instance = this;
        }

        //Enforce the unicity of the Singleton
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    //Paths
    public string SPECIE_FILE_SUFFIX = "specie.csv";
    public string INPUTS_FOLDER_PATH = "Assets/Inputs/";
    public string PLAYER1_SPECIE_FOLDER = "Player1/";
    public string PLAYER2_SPECIE_FOLDER = "Player2/";

    //Templates & Prefabs
    [SerializeField]
    private GameObject emptyAgentPrefab;
    [SerializeField]
    private GameObject hivePrefab;
    [SerializeField]
    private GameObject[] p1_unitTemplates;
    [SerializeField]
    private GameObject[] p2_unitTemplates;

    //Instancied Game Objects
    [SerializeField]
    private GameObject p1_hive;
    [SerializeField]
    private GameObject p2_hive;

    private Specie p1_specie;
    private Specie p2_specie;

    public GameObject P1_hive
    {
        get
        {
            return p1_hive;
        }

        set
        {
            p1_hive = value;
        }
    }

    public GameObject P2_hive
    {
        get
        {
            return p2_hive;
        }

        set
        {
            p2_hive = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        SetupMatch();
    }

    private void SetupMatch()
    {
        ParseSpecies();
        CreateUnitTemplates();
        InitGameObjects();
    }

    private void ParseSpecies()
    {
        //Init p1_specie
        //Get file name
        string[] filenames = Directory.GetFiles(INPUTS_FOLDER_PATH + PLAYER1_SPECIE_FOLDER);
        string p1_filename = null;
        foreach (string filename in filenames)
        {
            string[] toks = filename.Split('_');
            if (toks[toks.Length - 1] == SPECIE_FILE_SUFFIX) {
                p1_filename = filename;
                break;
            }
        }
        //Read file
        StreamReader reader = new StreamReader(p1_filename);
        List<string> lines = new List<string>();
        while (reader.Peek() >= 0)
        {
            lines.Add(reader.ReadLine());
        }
        //Parse file
        SpecieParser parser = new SpecieParser();
        p1_specie = parser.Parse(lines);

        //Init p2_specie
        //Get file name
        filenames = Directory.GetFiles(INPUTS_FOLDER_PATH + PLAYER2_SPECIE_FOLDER);
        string p2_filename = null;
        foreach (string filename in filenames)
        {
            string[] toks = filename.Split('_');
            if (toks[toks.Length - 1] == SPECIE_FILE_SUFFIX) {
                p2_filename = filename;
                break;
            }
        }
        //Read file
        reader = new StreamReader(p2_filename);
        lines = new List<string>();
        while (reader.Peek() >= 0)
        {
            lines.Add(reader.ReadLine());
        }
        //Parse file
        parser = new SpecieParser();
        p2_specie = parser.Parse(lines);
    }

    private void CreateUnitTemplates()
    {
        //Player1 templates (queen first)
        p1_unitTemplates = new GameObject[p1_specie.Casts.Values.Count];
        GameObject template = Instantiate(emptyAgentPrefab);
        template.SetActive(false);
        UnitTemplateInitializer.InitTemplate(p1_specie.Casts[p1_specie.QueenCastName], template);
        p1_unitTemplates[0] = template;
        int ind = 0;
        foreach (string key in p1_specie.Casts.Keys)
        {
            if (key != p1_specie.QueenCastName)
            {
                Cast cast = p1_specie.Casts[key];
                template = Instantiate(emptyAgentPrefab);
                template.GetComponent<AgentEntity>().Authority = PlayerAuthority.Player1;
                template.SetActive(false);
                p1_unitTemplates[ind] = template;
                UnitTemplateInitializer.InitTemplate(cast, template);
            }
            ind++;
        }

        //Player2 templates (queen first)
        p2_unitTemplates = new GameObject[p2_specie.Casts.Values.Count];
        template = Instantiate(emptyAgentPrefab);
        template.SetActive(false);
        UnitTemplateInitializer.InitTemplate(p2_specie.Casts[p1_specie.QueenCastName], template);
        p2_unitTemplates[0] = template;
        ind = 0;
        foreach (string key in p2_specie.Casts.Keys)
        {
            if (key != p2_specie.QueenCastName)
            {
                Cast cast = p2_specie.Casts[key];
                template = Instantiate(emptyAgentPrefab);
                template.GetComponent<AgentEntity>().Authority = PlayerAuthority.Player2;
                template.SetActive(false);
                p2_unitTemplates[ind] = template;
                UnitTemplateInitializer.InitTemplate(cast, template);
            }
            ind++;
        }
    }

    private void InitGameObjects()
    {
        //Hives
        p1_hive = Instantiate(hivePrefab, new Vector3(-30f, -0.45f, 0f), Quaternion.identity);
        p1_hive.name = "p1_hive";
        p2_hive = Instantiate(hivePrefab, new Vector3(30f, -0.45f, 0f), Quaternion.identity);
        p2_hive.name = "p2_hive";
        HiveScript p1_hiveScript = p1_hive.GetComponent<HiveScript>();
        HiveScript p2_hiveScript = p2_hive.GetComponent<HiveScript>();
        p1_hiveScript.RedResAmout = p1_specie.RedResAmount;
        p1_hiveScript.GreenResAmout = p1_specie.GreenResAmount;
        p1_hiveScript.BlueResAmout = p1_specie.BlueResAmount;
        p2_hiveScript.RedResAmout = p2_specie.RedResAmount;
        p2_hiveScript.GreenResAmout = p2_specie.GreenResAmount;
        p2_hiveScript.BlueResAmout = p2_specie.BlueResAmount;
        foreach (string key in p1_specie.Casts.Keys)
        {
            p1_hiveScript.Population.Add(key, 0);
        }
        foreach (string key in p2_specie.Casts.Keys)
        {
            p2_hiveScript.Population.Add(key, 0);
        }


        //Queens
        GameObject p1_queen = Instantiate(p1_unitTemplates[0], new Vector3(-30f, 0f, 0f), Quaternion.identity);
        p1_queen.name = "p1_queen";
        GameObject p2_queen = Instantiate(p2_unitTemplates[0], new Vector3(30f, 0f, 0f), Quaternion.identity);
        p2_queen.name = "p2_queen";
        p1_queen.SetActive(true);
        p2_queen.SetActive(true);
        p1_hiveScript.Population[p1_specie.QueenCastName]++;
        p2_hiveScript.Population[p2_specie.QueenCastName]++;
    }
}