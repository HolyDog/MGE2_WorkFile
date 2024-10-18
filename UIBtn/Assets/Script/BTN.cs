using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTN : MonoBehaviour
{
    UIMaanger m_UIManager;

    [SerializeField] int m_index = 0;

    public void OnBtnClick()
    {
        m_UIManager.OnBtnClick(m_index);
    }
}
