using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    public static bool Winner;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Winner = true;
    }
}
