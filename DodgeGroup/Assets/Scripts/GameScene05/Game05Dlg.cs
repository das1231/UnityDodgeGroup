using UnityEngine;
using UnityEngine.UI;

public class Game05Dlg : MonoBehaviour
{
    [SerializeField] Button m_BtnStart = null;
    [SerializeField] Button m_BtnStop = null;
    [SerializeField] Button m_BtnClear = null;
    [SerializeField] Text m_TxtCount = null;

    int m_Min = 0;
    int m_Sec = 0;
    float m_Mil = 0f;
    bool m_isTrue = false;
    float m_Count = 0f;
    void Start()
    {
        m_BtnStart.onClick.AddListener(OnClicked_Start);
        m_BtnStop.onClick.AddListener(OnClicked_Stop);
        m_BtnClear.onClick.AddListener(OnClicked_Clear);
    }

    private void OnClicked_Clear()
    {
        m_isTrue = false;
        m_Count = 0f;
        m_TxtCount.text = string.Format("{0:00}:{1:00}:{2:00}", 0, 0, 0);
    }

    private void OnClicked_Stop()
    {
        m_isTrue = false;
    }

    private void OnClicked_Start()
    {
        m_isTrue = true;
    }

    void Update()
    {
        if (!m_isTrue)
            return;
        m_Count += Time.deltaTime;
        m_Min = (int)m_Count / 60;
        m_Sec = (int)m_Count % 60;
        m_Mil = (m_Count * 100) % 100;
        m_TxtCount.text = string.Format("{0:00}:{1:00}:{2:00}", m_Min, m_Sec, m_Mil);
    }
}
