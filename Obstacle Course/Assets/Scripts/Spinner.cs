using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float x_angle = 1f;
    [SerializeField] float y_angle = 1f;
    [SerializeField] float z_angle = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x_angle,y_angle,z_angle);
    }
}
