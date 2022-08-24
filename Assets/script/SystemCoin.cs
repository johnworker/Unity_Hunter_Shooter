using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LEO
{
    public class SystemCoin : MonoBehaviour
    {
        [SerializeField, Header("飛行延遲"), Range(0, 2)]
        private float delayFly = 1.5f;

        private Transform traCoinFlyTo;
        /// <summary>
        /// 金幣系統：忽略碰撞、飛到金幣位置
        /// </summary>

        private bool startFly;
        private void Awake()
        {
            Physics.IgnoreLayerCollision(6, 3);     // 金幣、彈珠忽略碰撞
            Physics.IgnoreLayerCollision(6, 6);     // 金幣、金幣忽略碰撞
            Physics.IgnoreLayerCollision(6, 7);     // 金幣、怪物忽略碰撞

            traCoinFlyTo = GameObject.Find("金幣要前往的位置").transform;

            Invoke("startFly", delayFly);
        }

        private void Update()
        {
            Fly();
        }

        #region 開始飛行
        /// <summary>
        /// 開始飛行
        /// </summary>
        private void StartFly()
        {
            startFly = true;
        }
        #endregion

        private void Fly()
        {
            if (!startFly) return;

            // 插值：將 A B 兩個數值抓出中間的指定位置
            Vector3 traCoin = transform.position;
            Vector3 traCoinTo = traCoinFlyTo.position;

            traCoin = Vector3.Lerp(traCoin, traCoinTo, 0.05f);
            transform.position = traCoin;
        }
    }

}
