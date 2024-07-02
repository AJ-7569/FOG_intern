using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class Colliders : MonoBehaviour
{
    public GameObject[] lines;

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject line in lines)
        {
            BoxCollider boxCollider = line.GetComponent<BoxCollider>();
            if (boxCollider != null)
            {
                Destroy(boxCollider);
            }
            Thread.Sleep(300);
            boxCollider = line.AddComponent<BoxCollider>();

            // Set the BoxCollider's size and center to ma

            // Align the BoxCollider's rotation with the line's rotation
            boxCollider.transform.rotation = line.transform.rotation;
        }
    }
}
