using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelegateDlg : MonoBehaviour
{
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] TextItem[] m_txtItems = null;
    [SerializeField] Text m_txtResult = null;
    TextItem m_SelectedItem = null;

    void Start()
    {
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        Initialize();
    }
    public void Initialize()
    {
        for (int i = 0; i < m_txtItems.Length; i++)
        {
            m_txtItems[i].OnAddListner(OnCallback_TextItem);
        }
    }

    private void OnCallback_TextItem(TextItem kItem, bool bSelect)
    {
        ClearSelect();
        kItem.SetSelected_Color(bSelect);
        m_SelectedItem = kItem;
        m_txtResult.text = m_SelectedItem.m_txtName.text;
    }

    private void OnClicked_Ok()
    {
        m_txtResult.text = $"당신이 선택한 도시는 {m_SelectedItem.m_txtName.text} 입니다.";
    }

    private void OnClicked_Clear()
    {
        m_txtResult.text = "";
    }

    void ClearSelect()
    {
        for (int i = 0; i < m_txtItems.Length; i++)
        {
            m_txtItems[i].SetSelected_Color(false);
        }
    }
}
