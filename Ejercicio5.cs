using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 cube_position = GameObject.FindGameObjectsWithTag("BasicCube")[0].transform.position;
        Vector3 cylinder_position = GameObject.FindGameObjectsWithTag("BasicCylinder")[0].transform.position;
        Vector3 own_position = GetComponent<Transform>().position;
        Debug.Log("Distancia entre el cubo y la esfera: " + Vector3.Distance(cube_position, own_position));
        Debug.Log("Distancia entre el cilindro y la esfera: " + Vector3.Distance(cylinder_position, own_position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
