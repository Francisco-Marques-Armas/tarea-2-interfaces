using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 cube_position;
    Vector3 cylinder_position;
    Vector3 sphere_position;
    Vector3 new_cube_position;
    Vector3 new_cylinder_position;
    void Start()
    {
        cube_position = GameObject.FindGameObjectsWithTag("BasicCube")[0].transform.position;
        cylinder_position = GameObject.FindGameObjectsWithTag("BasicCylinder")[0].transform.position;
        sphere_position = GameObject.FindGameObjectsWithTag("BasicSphere")[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        new_cube_position = new Vector3(sphere_position.x + 5, cube_position.y, cube_position.z);
        new_cylinder_position = new Vector3(sphere_position.x - 5, cylinder_position.y, cylinder_position.z);        
    }
}
