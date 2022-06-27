using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 條件式(判斷式)
/// 1. if
/// 2. switch
/// </summary>
public class LearnCondition : MonoBehaviour
{
    #region if 判斷式

    // if 語法：
    // if (布林值) {布林值等於 true 會執行}
    private void Start()
    {
        if (true)
        {
            print("我在判斷式 if 內");
        }
    }

    #endregion
}
