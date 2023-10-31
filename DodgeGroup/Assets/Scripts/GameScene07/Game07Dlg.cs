using UnityEngine;
using UnityEngine.UI;

public class Game07Dlg : MonoBehaviour
{
    [SerializeField] Button m_BtnStart = null;
    [SerializeField] Text m_txtDodge = null;
    [SerializeField] Image m_Backgr = null;
    [SerializeField] Text m_TxtCount = null;

    string[] m_CountList = new string[4] { "3", "2", "1", "Start" };
    bool m_isTrue = false;
    float m_Time = 0f;
    int m_idx = 0;
    void Start()
    {
        m_isTrue = false;
        m_BtnStart.onClick.AddListener(OnClicked_Start);
    }

    private void OnClicked_Start()
    {
        m_BtnStart.gameObject.SetActive(false);
        m_txtDodge.gameObject.SetActive(false);
        m_Backgr.gameObject.SetActive(false);
        m_isTrue = true;
    }

    void Update()
    {
        if (!m_isTrue)
            return;
        m_TxtCount.text = m_CountList[m_idx];
        m_TxtCount.gameObject.SetActive(true);
        m_Time += Time.deltaTime;
        if (m_Time >= 1)
        {
            m_idx++;
            m_Time = 0;
            if (m_idx >= 4)
            {
                m_isTrue = false;
                m_TxtCount.gameObject.SetActive(false);
            }
        }
    }
}
