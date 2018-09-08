using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pra : MonoBehaviour {

    // Use this for initialization
    float t = 0;
    int index = 0;
    List<Vector3> points = new List<Vector3>();



    int[] path = new int[] { 3, 2, 5,0 };

    // Use this for initialization
    void Start()
    {

        path[1] = GameObject.Find("0").transform.position;
        points.Add(GameObject.Find("2").transform.position);
        points.Add(GameObject.Find("3").transform.position);
        points.Add(GameObject.Find("5").transform.position);
        points.Add(GameObject.Find("0").transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        t += 0.05f;
        transform.position = Vector3.Lerp(points[index], points[index + 1], t);
        if (t >= 1)
        {
            t = 0;
            index += 1;

            if (index == points.Count - 1)
            {

               
                index = 0;
            }

        }
     }
    }

