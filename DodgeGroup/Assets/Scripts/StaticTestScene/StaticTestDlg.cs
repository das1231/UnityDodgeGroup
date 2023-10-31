using System;
using UnityEngine;
using UnityEngine.UI;

public class StaticTestDlg : MonoBehaviour
{
    [SerializeField] Button m_BtnStart = null;
    [SerializeField] Button m_BtnClear = null;
    [SerializeField] Text m_TxtScore = null;
    void Start()
    {
        m_BtnStart.onClick.AddListener(OnClicked_Start);
        m_BtnClear.onClick.AddListener(OnClicked_Clear);
    }

    private void OnClicked_Clear()
    {
        m_TxtScore.text = "";
    }

    private void OnClicked_Start()
    {
        StaticTest.m_Total = 0;
        StaticTest Test1 = new StaticTest(90);
        m_TxtScore.text = String.Format("Score = {0}, Total = {1}\n", Test1.m_Score, StaticTest.m_Total);
        StaticTest Test2 = new(80);
        m_TxtScore.text += String.Format("Score = {0}, Total = {1}\n", Test2.m_Score, StaticTest.m_Total);
        StaticTest Test3 = new(95);
        m_TxtScore.text += String.Format("Score = {0}, Total = {1}\n", Test3.m_Score, StaticTest.m_Total);
    }
}
