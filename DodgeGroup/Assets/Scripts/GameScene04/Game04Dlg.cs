using UnityEngine;
using UnityEngine.UI;

public class Game04Dlg : MonoBehaviour
{
    [SerializeField] Button m_Start;
    [SerializeField] Button m_Stop;
    public Turret04[] m_TurrList = new Turret04[2];
    public bool m_Fire = false;
    void Start()
    {
        m_Fire = false;
        m_Start.onClick.AddListener(OnClicked_Start);
        m_Stop.onClick.AddListener(OnClicked_Stop);
    }

    private void OnClicked_Stop()
    {
        for (int i = 0; i < m_TurrList.Length; i++)
        {
            m_TurrList[i].StopFire();
        }
    }

    private void OnClicked_Start()
    {
        for (int i = 0; i < m_TurrList.Length; i++)
        {
            m_TurrList[i].StartFire();
        }
    }
}
