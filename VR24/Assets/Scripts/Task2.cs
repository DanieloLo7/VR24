using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Task2 : MonoBehaviour
{
    public int b = 5;
    public Text count;
    public void OnCollisionEnter(Collision collision)
    {
        b--;
        count.text = b.ToString();
    }
}
