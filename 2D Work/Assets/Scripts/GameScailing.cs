using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScailing : MonoBehaviour
{
    public Camera cam;
    private float scale;
    void Awake()
    {
        scale = cam.aspect - 0.6f;
        transform.localScale = new Vector3(scale,scale,transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
