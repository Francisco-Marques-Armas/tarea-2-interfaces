using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    GameObject cylinder;
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cylinder = GameObject.FindGameObjectsWithTag("BasicCylinder")[0];
        cube = GameObject.FindGameObjectsWithTag("BasicCube")[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cylinder.GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
