using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaberintControl : MonoBehaviour
{
    public float SpeedV = 2.0f;
    public float SpeedH = 2.0f;

    private float Horizontal = 0.0f;
    private float Vertical = 0.0f;


	void Start ()
    {

	}

	void Update ()
    {
        if (GameMAster.pause == false)
        {
            Horizontal -= SpeedH * Input.GetAxis("Mouse X");
            Vertical += SpeedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(Vertical, 0, Horizontal);

            if (Horizontal >= 20.0f)
            {
                Horizontal = 20.0f;
            }
            if (Horizontal <= -20.0f)
            {
                Horizontal = -20.0f;
            }
            if (Vertical >= 20.0f)
            {
                Vertical = 20.0f;
            }
            if (Vertical <= -20.0f)
            {
                Vertical = -20.0f;
            }
        }
    }
}
