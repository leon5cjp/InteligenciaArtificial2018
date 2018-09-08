using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {
    float t = 0;
    int index = 0;
    List<Vector3> points = new List<Vector3>();

    bool isReversed = false;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        t += 0.05f;
        transform.position = Vector3.Lerp(points[index], points[index+1], t);
        if(t >=1)
        {
            t = 0;
            index += 1;
            
            if(index == points.Count - 1)
            {
                
                isReversed = !isReversed;
                SetPoints(isReversed);
                index = 0;
            }

        }
	}

    void SetPoints(bool isReversed)
    {
        points.Clear();

        if(isReversed)
        {
            points.Add(GameObject.Find("P1").transform.position);
            points.Add(GameObject.Find("P6").transform.position);
            points.Add(GameObject.Find("P5").transform.position);
            points.Add(GameObject.Find("P4").transform.position);
            points.Add(GameObject.Find("P3").transform.position);
            points.Add(GameObject.Find("P2").transform.position);
            points.Add(GameObject.Find("P1").transform.position);
        }
        else
        {
            points.Add(GameObject.Find("P1").transform.position);
            points.Add(GameObject.Find("P2").transform.position);
            points.Add(GameObject.Find("P3").transform.position);
            points.Add(GameObject.Find("P4").transform.position);
            points.Add(GameObject.Find("P5").transform.position);
            points.Add(GameObject.Find("P6").transform.position);
            points.Add(GameObject.Find("P1").transform.position);
        }
    }
}
