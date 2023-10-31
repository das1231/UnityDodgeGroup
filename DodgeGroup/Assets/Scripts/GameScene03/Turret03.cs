using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret03 : MonoBehaviour
{
    [SerializeField] Transform m_BulletPos;
    [SerializeField] Transform m_BulletParent;
    [SerializeField] GameObject m_Bullet;
    [SerializeField] Transform m_TurretBody;
    [SerializeField] Transform m_Target;

    void Start()
    {
        //StartCoroutine(Fire());
    }

    void Update()
    {
        m_TurretBody.LookAt(m_Target);
    }

    public void CreateBullet()
    {
        GameObject go = Instantiate(m_Bullet, m_BulletParent);
        go.transform.position = m_BulletPos.position;
        Bullet03 Bullet = go.GetComponent<Bullet03>();
        Bullet.Initialize(m_Target);
    }
}
