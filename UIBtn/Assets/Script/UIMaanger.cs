using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIMaanger : MonoBehaviour
{
    public void OnBtnClick(int argIndex)
    {
        switch (argIndex)
        {
            case 0:
                Debug.Log("��ư0");
                break;
            case 1:
                Debug.Log("��ư1");
                break;
            default:
                Debug.Log("�̰� �����.");
                break;

        }
    }
}
