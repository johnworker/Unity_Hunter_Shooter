//單行註解，說明、標記
/*
 * 多行註解
 * 多行註解
 */

//藍色 保留字
//白色 名稱
//綠色 資料類型

using UnityEngine;

//修飾詞 類別(藍圖){他是虛擬的資料} 類別名稱 ： 繼承(物件導向程式設計 OOP 三大原則)
public class LearnData : MonoBehaviour
{
    // LearnData 類別的成員區域

    //儲存資料方式
    //欄位 field
    //儲存各種資料
    //欄位語法
    //資料類型 欄位自訂名稱 結束語法
    //定義一筆整數資料 名稱叫做
    int hp;

    //資料類型：四大基本類型
    //整  數：保存正負沒有小數點的資料 int
    //浮點數：保存正負有小數點的資料 float
    //字  串：保存文字資訊 string
    //布林值：保存有或沒有 bool

    int lv = 87;
    float exp = 0.03f;
    string playerName = "神人降臨"; //名稱的第二個單字通常用大寫，以方便增加可視性
    bool hasCureSkill = true;

    //推薦書：Clean Code 無瑕的程式
}

// 非LearnData 類別的成員區域