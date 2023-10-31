using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float m_Speed = 10f;
    public void Initialize(Transform target)
    {
        transform.LookAt(target);
    }

    void FixedUpdate()
    {
        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }
}
