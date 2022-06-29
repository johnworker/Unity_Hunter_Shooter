using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace LEO
{ 
    /// <summary>
    /// 玩家控制系統
    /// 物件旋轉、彈珠發射
    /// </summary>
public class SystemControl : MonoBehaviour
{
        #region 資料
        // GameObject 遊戲物件
        // 存放階層面板內或專案內的物件

        // 箭頭
        [Header("箭頭")]
        public GameObject arraw;
        // 旋轉速度
        [Header("旋轉速度"), Range(0, 500)]
        public float speedTurn = 10.5f;
        // 彈珠預置物
        [Header("彈珠預置物")]
        public GameObject mrable;
        // 彈珠可發射的總數
        [Header("彈珠可發射的總數"), Range(0, 50)]
        public int canShootMarbleTotle = 15;
        #endregion

        #region 事件
        #endregion

        #region 方法
        #endregion

    }

}
