using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game08Dlg : MonoBehaviour
{
    [SerializeField] Button[] m_BtnSce = null;

    void Start()
    {
        for (int i = 0; i < m_BtnSce.Length; i++)
        {
            int idx = i;
            m_BtnSce[i].onClick.AddListener(() => OnClicked_Scene(idx));
        }
    }

    private void OnClicked_Scene(int idx)
    {
        SceneMove(idx);
    }

    void SceneMove(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}
