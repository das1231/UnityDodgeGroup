using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    public static int m_Total = 0;
    public int m_Score = 0;
    public StaticTest(int idx)
    {
        m_Score = idx;
        m_Total += idx;
    }
}
