﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class die : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hello");
    }
}
