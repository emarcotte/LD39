﻿using UnityEngine;
using System.Collections;

public class Pixelator : MonoBehaviour
{

    public RenderTexture renderTexture;

    void Start()
    {
        int realRatio = Mathf.RoundToInt(Screen.width / Screen.height);
        renderTexture.width = NearestSuperiorPowerOf2(Mathf.RoundToInt(renderTexture.width * realRatio));
    }

    void OnGUI()
    {
        GUI.depth = 20;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), renderTexture);
    }

    int NearestSuperiorPowerOf2(int n)
    {
        return (int)Mathf.Pow(2, Mathf.Ceil(Mathf.Log(n) / Mathf.Log(2)));
    }
}