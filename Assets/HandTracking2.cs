using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking2 : MonoBehaviour
{
    // Start is called before the first frame update
    public UDPReceive2 udpReceive2;
    public GameObject[] handPoints2;
    private const float constantY = 0.02f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data = udpReceive2.data;

        data = data.Remove(0, 1);
        data = data.Remove(data.Length-1, 1);
        print(data);
        string[] points = data.Split(',');
        //print(points[0]);

        //0        1*3      2*3
        //x1,y1,z1,x2,y2,z2,x3,y3,z3

        for ( int i = 0; i<19; i++)
        {

            float x = float.Parse(points[i * 2])/100;
            float y =0.00000001f;
            float z =55.01802f- (float.Parse(points[i * 2 + 1])-80) / 100;

            handPoints2[i].transform.localPosition = new Vector3(x, y, z);

        }
        // for ( int i = 19; i<38; i++)
        // {

        //     float x = float.Parse(points[i * 2])/100;
        //     float y =0.00000001f;
        //     float z =55.01802f- (float.Parse(points[i * 2 + 1])-80) / 100;

        //     handPoints[i].transform.localPosition = new Vector3(x, y, z);

        // }


    }
}