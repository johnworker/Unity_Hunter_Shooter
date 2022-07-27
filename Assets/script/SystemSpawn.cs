using System.Collections;
using System.Collections.Generic;
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
            print(Random.Range(min, max));
        }
        #endregion

    }

}