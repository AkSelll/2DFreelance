using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public GameObject cloud;
    public BoxCollider2D BackgroundColl;
    public float speed;
    Vector2 cloudMov;
    float r_bound;
    float l_bound;
    void Start()
    {
        cloudMov = cloud.transform.position;
    }

    void Update()
    {
        r_bound = BackgroundColl.bounds.center.x + BackgroundColl.bounds.extents.x;
        l_bound = BackgroundColl.bounds.center.x - BackgroundColl.bounds.extents.x;
        /*if (cloud.transform.position.x < r_bound+3f)
        {
            cloudMov += Vector2.right * speed * Time.deltaTime;
            cloud.transform.position = cloudMov;
        }
        else if (cloud.transform.position.x >= r_bound+3f)
        {
            cloudMov = new Vector3(l_bound - 3f, cloud.transform.position.y, cloud.transform.position.z);
            cloud.transform.position = cloudMov;
        }*/
        if (cloud.transform.position.x > l_bound-3f)
        {
            cloudMov += Vector2.right * speed * Time.deltaTime;
            cloud.transform.position = cloudMov;
        }
        else if (cloud.transform.position.x <= l_bound-3f)
        {
            cloudMov = new Vector3(r_bound + 3f, cloud.transform.position.y, cloud.transform.position.z);
            cloud.transform.position = cloudMov;
        }
    }
}
