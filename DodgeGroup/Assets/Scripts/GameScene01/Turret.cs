using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] Transform m_trBody = null;
    [SerializeField] Transform m_trBulletPos = null;
    [SerializeField] GameObject m_PrefabBullet = null;
    [SerializeField] Transform m_Target = null;
    [SerializeField] Transform m_BulletParent = null;
    
    void Start()
    {
        Initialize();
    }
    void Update()
    {
        m_trBody.LookAt(m_Target);
        Fire();
    }

    public void Initialize()
    {
        
    }

    void Fire()
    {
        if(Input.GetMouseButtonDown(0))
            CreateBullet();

    }

    void CreateBullet()
    {
        GameObject go = Instantiate(m_PrefabBullet, m_BulletParent);
        go.transform.position = new Vector3(m_trBulletPos.position.x, 
            m_Target.position.y, m_trBulletPos.position.z);
        Bullet bullet = go.GetComponent<Bullet>();
        bullet.Initialize(m_Target);
    }
}
