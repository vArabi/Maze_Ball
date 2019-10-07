using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Derrota : MonoBehaviour
{
    public static bool Loser;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Loser = true;
    }
}
