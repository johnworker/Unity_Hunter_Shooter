using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMethod : MonoBehaviour
{

    // 自訂方法
    // 需要呼叫才會執行

    // Unity的入口
    // 開始事件 (藍色名稱)
    // 撥放遊戲後會執行一次
    // 初始化設定：初始金額、三條命等等等

    private void Start()
    {
        // 呼叫方法
        // 方法名稱
        Text();
        PrintColorText();
    }

    // 方法語法
    // 回傳類型 方法自訂名稱 () { 方法內容 }
    // 無回傳 void
    // 方法名稱 Unity 習慣用大寫開頭
    private void Text()
    {
        // 輸出(內容)
        print("hello world");

    }

    private void PrintColorText()
    {
        print("<color=yellow>黃色</color>");
        print("<color=red>紅色</color>");
        print("<color=#003366>藍色</color>");
    }
}
