﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    string txt = "This is DD's Library\n" +
        "Add Tag DD & Layer DD\n" +
        "Screen 480*768\n"+
        "Home Update 7-9";

    void Start()
    {

    }

    void Update()
    {

    }

    void OnGUI()
    {
        GUILayout.Label(txt);
    }
}
