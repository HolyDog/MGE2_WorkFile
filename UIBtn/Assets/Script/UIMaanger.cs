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
                Debug.Log("버튼0");
                break;
            case 1:
                Debug.Log("버튼1");
                break;
            default:
                Debug.Log("이건 비었다.");
                break;

        }
    }
}
