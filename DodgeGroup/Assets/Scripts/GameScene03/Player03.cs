using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player03 : MonoBehaviour
{
    [SerializeField] float m_Speed = 0f;
    public FXParticle m_Effect;

    void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float xDelta = m_Speed * Time.deltaTime * x;
        float zDelta = m_Speed * Time.deltaTime * z;

        Vector3 move = new Vector3(xDelta, 0, zDelta);
        transform.position += move;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Destroy(collision.collider.gameObject, 0.5f);
            m_Effect.Play();
        }
    }
}
