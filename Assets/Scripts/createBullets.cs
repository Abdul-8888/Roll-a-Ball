using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBullets : MonoBehaviour
{
    public GameObject bullet;
    public GameObject target;
    private Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        offSet = target.transform.position - transform.position;
        StartCoroutine(creatingBullets());
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position - offSet;
    }

    IEnumerator creatingBullets()
    {
        yield return new WaitForSeconds(2.0f);

        while(target.gameObject != null)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(2.0f);
        }
    }
}
