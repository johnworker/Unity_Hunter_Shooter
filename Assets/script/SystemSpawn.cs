using System.Collections;
using System.Collections.Generic;       // 資料結構清單
using System.Linq;                      // 查詢語言
using UnityEngine;


namespace Leo
{ 
    /// <summary>
    /// 生成怪物系統
    /// </summary>
    public class SystemSpawn : MonoBehaviour
        {
        #region 資料
        [Header("怪物陣列"), SerializeField]
        private GameObject[] goEnemys;
        [Header("生成格子第二排座標"), SerializeField]
        private Transform[] traSecondPlace;

        [SerializeField]
        private List<Transform> listScendPlace = new List<Transform>();
        #endregion

        #region 事件
        private void Awake()
        {
            SpawnRandomEnemy();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 生成隨機敵人
        /// </summary>
        private void SpawnRandomEnemy()
        {
            int min = 2;
            int max = traSecondPlace.Length;

            int randomCount = Random.Range(min, max);
            print("怪物隨機數量：" + randomCount);

            // 清單 = 陣列.轉換清單();
            listScendPlace = traSecondPlace.ToList();

            // 隨機物件
            System.Random random = new System.Random();
            // 清單 = 清單的排序(每個清單內容 => 隨機排序).轉為清單
            listScendPlace = listScendPlace.OrderBy(x => random.Next()).ToList();

            int sub = traSecondPlace.Length - randomCount;
            print("要扣除的數量：" + sub);

            // 迴圈 刪除 要扣除的數量
            for (int i = 0; i < sub; i++)
            {
                // 刪除第一個清單資料
                listScendPlace.RemoveAt(0);
            }

            // 生成所有怪物
            for (int i = 0; i < listScendPlace.Count; i++)
            {
                // 隨機怪物
                int randomIndex = Random.Range(0, goEnemys.Length);
                // 生成怪物
                Instantiate(
                    goEnemys[randomIndex],
                    listScendPlace[i].position,
                    Quaternion.identity
                    );
            }
        }
        #endregion

    }

}