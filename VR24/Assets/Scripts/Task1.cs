using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Task1 : MonoBehaviour
{
    public GameObject test;
    public void Button()
    {
        test.SetActive(!(test.activeSelf));
    }
}