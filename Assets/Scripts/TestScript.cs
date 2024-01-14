using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
    }

    private void OnEnable()
    {
        Debug.Log("Enable");
    }

    private void OnDisable()
    {
        Debug.Log("Disable");
    }

    private void LateUpdate()
    {
        Debug.Log("Late");
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed");
    }
}
