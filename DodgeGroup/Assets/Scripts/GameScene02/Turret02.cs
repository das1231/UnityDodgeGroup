using UnityEngine;

public class Turret02 : MonoBehaviour
{
    [SerializeField] Transform m_Body = null;
    [SerializeField] Transform m_BulletParent = null;
    [SerializeField] Transform m_BulletPos = null;
    [SerializeField] Transform m_Target = null;
    [SerializeField] GameObject m_Bullet = null;

    public void Fire()
    {
        CreateBullet();
    }

    public void CreateBullet()
    {
        GameObject go = Instantiate(m_Bullet, m_BulletParent);
        go.transform.position = m_BulletPos.position;
        Bullet02 bullet = go.GetComponent<Bullet02>();
        bullet.Initialize(m_Target);
    }

    void Update()
    {
        m_Body.LookAt(m_Target);
    }
}
