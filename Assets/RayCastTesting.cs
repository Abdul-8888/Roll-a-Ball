using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTesting : MonoBehaviour
{
	void FixedUpdate()
	{
		int layerMask = 1 << 8; layerMask = ~layerMask; RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
		{
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow); 
			Debug.Log("Did Hit");
			Debug.Log(hit.collider.gameObject.name);
		}
		else
		{
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white); 
			Debug.Log("Did not Hit");
		}
	}
} 

