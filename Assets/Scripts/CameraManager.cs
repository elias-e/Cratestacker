﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraManager : MonoBehaviour
{
    public float horizontalResolution = 1080;

    void OnGUI()
    {
        float currentAspect = (float)Screen.width / (float)Screen.height;
        Camera.main.orthographicSize = horizontalResolution / currentAspect / 200;

    }
}