﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillValues : MonoBehaviour {
    int lvl = 1;
    public int time;
    public float police;
    public float panic;

    GameObject gameController = GameObject.Find("GameController");
    // Use this for initialization
    void Start()
    {
        lvl = gameController.GetComponent<GameController>().drillLVL;

        switch (lvl)
        {
            case 1:
                time = 60;
                police = 0f;
                panic = 0f;
                break;
            case 2:
                time = 45;
                police = 0f;
                panic = 0.1f;
                break;
            case 3:
                time = 30;
                police = 0f;
                panic = 0.1f;
                break;
        }
    }
}
