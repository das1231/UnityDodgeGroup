using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Game03Dlg : MonoBehaviour
{
    [SerializeField] Button m_Start = null;
    [SerializeField] Button m_Stop = null;
    [SerializeField] Turret03 m_Turret = null;

    bool m_isTrue = false;
    void Start()
    {
        m_Start.onClick.AddListener(OnClicked_Start);
        m_Stop.onClick.AddListener(OnClicked_Stop);
    }

    private void OnClicked_Stop()
    {
        m_isTrue = false;
    }

    private void OnClicked_Start()
    {
        if (!m_isTrue)
        {
            StartCoroutine(Fire());
        }
    }

    public IEnumerator Fire()
    {
        m_isTrue = true;
        while (m_isTrue)
        {
            m_Turret.CreateBullet();
            yield return new WaitForSeconds(1);
        }
    }
}
