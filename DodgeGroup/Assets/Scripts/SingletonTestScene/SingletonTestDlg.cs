using System;
using UnityEngine;
using UnityEngine.UI;

public class SingletonTestDlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] Text m_TxtResult = null;
    private void Start()
    {
        m_TxtResult.text = "";
        m_btnStart.onClick.AddListener(onClicked_Start);
        m_btnClear.onClick.AddListener(onClicked_Clear);
    }

    private void onClicked_Clear()
    {
        m_TxtResult.text = "";
    }

    private void onClicked_Start()
    {
        Initialized();
    }

    private void Initialized()
    {
        m_TxtResult.text = String.Format("{0}",
        GameMgr.Inst().m_Score = 200);
    }
}

public class GameMgr
{
    static GameMgr _inst = null;
    public static GameMgr Inst()
    {
        if (_inst == null)
        {
            _inst = new GameMgr();
        }
        return _inst;
    }
    public int m_Score = 100;
}

//public class GameMgr9 :MonoBehaviour
//{
//    static GameMgr9 _inst = null;
//    public static GameMgr9 Inst
//    {
//        get
//        {
//            if (_inst == null)
//            {
//                GameObject go = new GameObject("Singletion GameMgr");
//                _inst = go.AddComponent<GameMgr9>();
//                DontDestroyOnLoad(go);
//            }
//            return _inst;
//        }
//    }
//    public int m_Score = 100;

//    public int GetScore() { return m_Score; }
//    public void SerScore(int score)
//    {
//        m_Score = score;
//    }

//    public int score
//    {
//        get { return m_Score; }
//        set { m_Score = score; }
//    }
//}