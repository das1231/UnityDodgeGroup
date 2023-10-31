using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player04 : MonoBehaviour
{
    [SerializeField] float m_Speed = 0f;
    public FXParticle m_Effect;
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float xDelta = x * m_Speed * Time.deltaTime;
        float zDelta = z * m_Speed * Time.deltaTime;

        Vector3 move = new Vector3(xDelta, 0, zDelta);
        transform.position += move;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Destroy(collision.collider.gameObject, 0.5f);
            m_Effect.Play();
            Debug.Log("ÃÑ¿¡ ¸ÂÀ½");
        }
    }
}
