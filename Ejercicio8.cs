using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    float[] distances_group_b = new float[3];
    GameObject[] group_b_spheres = new GameObject[3];
    GameObject cube;
    GameObject min_distance_sphere;
    GameObject max_distance_sphere;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindGameObjectsWithTag("BasicCube")[0];
        group_b_spheres[0] = GameObject.FindGameObjectsWithTag("GroupBSphere")[0];
        for (int i = 0; i < 3; i++)
        {
            distances_group_b[i] = Vector3.Distance(group_b_spheres[i].transform.position, cube.transform.position);
        }
        // Find closest sphere to cube
        float min_distance_sphere_distance = 999999999;
        int min_distance_sphere_position = 0;
        int max_distance_sphere_position = 0;
        float max_distance_sphere_distance = -999999999;
        for (int i = 0; i < 3; i++)
        {
            if (distances_group_b[i] < min_distance_sphere_distance)
            {
                min_distance_sphere_distance = distances_group_b[i];
                min_distance_sphere_position = i;
            }
            if (distances_group_b[i] > max_distance_sphere_distance)
            {
                max_distance_sphere_distance = distances_group_b[i];
                max_distance_sphere_position = i;
            }
        }
        Debug.Log("Closest sphere to cube: " + group_b_spheres[min_distance_sphere_position].name);
        // Raise the closest sphere to cube
        min_distance_sphere = group_b_spheres[min_distance_sphere_position];
        min_distance_sphere.transform.position = new Vector3(min_distance_sphere.transform.position.x, min_distance_sphere.transform.position.y + 5, min_distance_sphere.transform.position.z);
        // Find furthest sphere to cube
        Debug.Log("Furthest sphere to cube: " + group_b_spheres[max_distance_sphere_position].name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            max_distance_sphere.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }
    }
}
