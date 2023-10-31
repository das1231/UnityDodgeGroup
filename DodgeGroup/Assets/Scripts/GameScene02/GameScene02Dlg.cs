using UnityEngine;
using UnityEngine.UI;

public class GameScene02Dlg : MonoBehaviour
{
    [SerializeField] Button m_Start = null;
    [SerializeField] Button m_Stop = null;
    [SerializeField] Turret02 m_Turret = null;


    public float m_timer = 0f;
    public bool m_isTrue = false;
    void Start()
    {
        m_isTrue = false;
        m_Start.onClick.AddListener(OnClicked_Start);
        m_Stop.onClick.AddListener(OnClicked_Stop);
    }

    private void OnClicked_Stop()
    {
        m_isTrue = false;
    }

    private void OnClicked_Start()
    {
        m_timer = 0f;
        m_isTrue = true;

    }

    void Update()
    {
        if (m_isTrue)
        {
            m_timer += Time.deltaTime;
            if (m_timer >= 1)
            {
                m_Turret.Fire();
                m_timer = 0f;
            }
        }
    }
}
