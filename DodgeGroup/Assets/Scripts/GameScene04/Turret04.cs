using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret04 : MonoBehaviour
{
    [SerializeField] Transform m_bullPos;
    [SerializeField] Transform m_turBody;
    [SerializeField] GameObject m_bullet;
    [SerializeField] Transform m_Target;
    [SerializeField] Transform m_bullParents;

    Coroutine corotine;

    void Update()
    {
        if(corotine != null)
            m_turBody.LookAt(m_Target);
    }

    public void StartFire()
    {
        if(corotine == null)
            corotine = StartCoroutine(Fire());
    }

    public void StopFire()
    {
        if(corotine != null)
        {
            StopCoroutine(corotine);
            corotine = null;
        }
    }

    public IEnumerator Fire() {
        while (true)
        {
            CreateBullet();
            yield return new WaitForSeconds(5f);
        }
    }

    public void CreateBullet()
    {
        GameObject go = Instantiate(m_bullet, m_bullParents);
        go.transform.position = m_bullPos.position;
        Bullet04 bullet = go.GetComponent<Bullet04>();
        bullet.Initialized(m_Target);
    }
}
