using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;

    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward*3*Time.deltaTime);
    }
   
}
