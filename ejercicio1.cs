using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int[] random_arr = new int[3];
    int random_position;
    void Start()
    {
        // for (int i = 0; i < 3; i++)
        // {
        //     random_arr[i] = Random.Range(0, 25);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        random_position = Random.Range(0, 2);
        random_arr[random_position] = Random.Range(0, 25);
        transform.position = new Vector3(random_arr[0], random_arr[1], random_arr[2]);
        // If any element is higher than 15, print
        for (int i = 0; i < 3; i++)
        {
            if (random_arr[i] > 15)
            {
                Debug.Log("Element higher than 15: " + random_arr[i]);
            }
        }
    }
}
