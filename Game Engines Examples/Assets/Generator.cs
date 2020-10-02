﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int elements = 12;
    public float radius = 10;
    public GameObject mp;
    // Start is called before the first frame update
    void Start()
    {
        for (int j = 0; j < elements; j++)
        {
            float theta = Mathf.PI * 2.0f / (float)(elements*j);
            for (int i = 0; i < (elements*j); i++)
            {
                GameObject prefab = Instantiate(mp);
                Vector3 pos = new Vector3(Mathf.Sin(theta * i) * (radius*j), 0, Mathf.Cos(theta * i) * (radius*j));
                mp.transform.position = transform.TransformPoint(pos);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
