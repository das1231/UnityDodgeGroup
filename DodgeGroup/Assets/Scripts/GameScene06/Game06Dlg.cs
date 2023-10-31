using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game06Dlg : MonoBehaviour
{
    [SerializeField] Button m_BtnStart = null;
    public Image m_Back = null;
    public Text m_txt = null;
    public Text[] m_Count = new Text[4];
    void Start()
    {
        m_BtnStart.onClick.AddListener(OnClicked_Start);
    }

    private void OnClicked_Start()
    {
        m_Back.gameObject.SetActive(false);
        m_BtnStart.gameObject.SetActive(false);
        m_txt.gameObject.SetActive(false);
        StartCoroutine(CountNum());
    }

    IEnumerator CountNum()
    {
        for (int i = 0; i < m_Count.Length; i++)
        {
            m_Count[i].gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            m_Count[i].gameObject.SetActive(false);
        }
    }
}
