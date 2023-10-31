using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextItem : MonoBehaviour
{
    public delegate void DelegateFunc(TextItem kItem, bool bSelect); // 정의
    public DelegateFunc OnSelectedFunc = null; //선언

    Image m_img = null;
    public Text m_txtName = null;
    Button m_btn = null;

    private void Awake()
    {
        m_img = GetComponent<Image>();
        m_btn = GetComponent<Button>();
    }
    private void Start()
    {
        m_btn.onClick.AddListener(OnClicked_Select);
    }
    public void OnAddListner(DelegateFunc func)
    {
        OnSelectedFunc = new DelegateFunc(func);
    }
    public void OnClicked_Select()
    {
        if (OnSelectedFunc != null)
        {
            OnSelectedFunc(this, true);
        }
    }
    public void SetSelected_Color(bool istrue)
    {
        if (istrue)
        {
            m_img.color = Color.green;
        }
        else
        {
            m_img.color = Color.white;
        }
    }
}
