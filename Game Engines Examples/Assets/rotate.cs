using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private Vector3 target = new Vector3(0.0f, 0.0f, 0.0f);
    public int rotationSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0 * Time.deltaTime); //rotates 50 degrees per second around y axis
        // Spin the object around the world origin at 20 degrees/second.
        transform.RotateAround(target, Vector3.up, 30 * Time.deltaTime);
    }
}
