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
        public GameObject arrow;
        // 旋轉速度
        [Header("旋轉速度"), Range(0, 500)]
        public float speedTurn = 10.5f;
        // 彈珠預置物
        [Header("彈珠預置物")]
        public GameObject mrable;
        // 彈珠可發射的總數
        [Header("彈珠可發射的總數"), Range(0, 50)]
        public int canShootMarbleTotle = 15;
        // 彈珠生成點
        [Header("彈珠生成點")]
        public Transform traSpawnPoint;
        // 攻擊參數名稱
        [Header("攻擊參數名稱")]
        public string parAttack = "觸發攻擊";
        // 彈珠發射速度
        [Header("彈珠發射速度"), Range(0, 5000)]
        public float speedMarble = 1000;
        [Header("彈珠發射間格"), Range(0, 2)]
        public float intervalMarble = 0.5f;

        public Animator ani;
        #endregion

        #region 事件
        private void Update()
        {
            ShootMarble();
        }
        #endregion

        #region 方法

        /// <summary>
        ///  旋轉角色，讓角色面向彈珠的位置
        /// </summary>
        private void TurnCharacter()
        {

        }

        /// <summary>
        ///  發射彈珠，根據彈珠總數發射物件
        /// </summary>
        private void ShootMarble()
        {
            // 按下 滑鼠左鍵 顯示 箭頭
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }

            // 放開 滑鼠左鍵 生成並發射彈珠
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                //print("放開左鍵！");
                arrow.SetActive(false);
                StartCoroutine(spawnMarble());
            }
        }

        private IEnumerator spawnMarble()
        {
            for (int i = 0; i < canShootMarbleTotle; i++)
            {
                // Object 類別可省略不寫
                // 直接透過 Object 成員名稱使用
                // 生成(彈珠)； traSpawnPoint
                // Quaternion.identity 零度角
                GameObject tempMarble = Instantiate(mrable,traSpawnPoint.position, Quaternion.identity);

                // 暫存彈珠 取得剛體元件 添加推力 (角色.前方 * 速度)
                // transform.forward 角色的前方
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);
                yield return new WaitForSeconds(intervalMarble);
            }

        }
        /// <summary>
        ///  回收彈珠
        /// </summary>
        private void RecycleMarble()
        {

        }

        #endregion

    }

}
