using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendFollow : MonoBehaviour
{
    public GameObject target;
    private Vector3 start;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 endPoint = new Vector3();
        endPoint = target.transform.position;
        transform.position = Vector3.Lerp(start, endPoint, duration);
    }
}
