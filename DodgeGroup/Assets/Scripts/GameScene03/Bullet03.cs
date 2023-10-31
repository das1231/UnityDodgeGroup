using UnityEngine;

public class Bullet03 : MonoBehaviour
{
    [SerializeField] float m_Speed = 0f;

    private void Start()
    {
        Destroy(gameObject, 10);    
    }

    public void Initialize(Transform target)
    {
        transform.LookAt(target);
    }

    void Update()
    {
        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }
}
