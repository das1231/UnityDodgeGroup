using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet02 : MonoBehaviour
{
    [SerializeField] float m_BulletSpeed = 0f;
    public void Initialize(Transform player)
    {
        transform.LookAt(player);
    }
    void Move()
    {
        transform.position += transform.forward * m_BulletSpeed * Time.deltaTime;
    }
}
