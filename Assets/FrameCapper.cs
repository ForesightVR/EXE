﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameCapper : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 30;
    }
}
