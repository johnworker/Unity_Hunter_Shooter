using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace LEO {
    public class SystemHealth : MonoBehaviour
    {
        [SerializeField, Header("畫布傷害物件")]
        private GameObject goDamage;
        [SerializeField, Header("圖片血量")]
        private Image imgHp;
        [SerializeField, Header("文字血量")]
        private TextMeshProUGUI textHp;


        // 碰撞事件
        // 1.兩個物件必須有一個帶有 Rigidbody
        // 2.兩個物件必須有碰撞器 Collider
        // 3.是否有勾選 Is Trigger
        // 3-1. 兩者都沒有勾選 Is Trigger 使用 OnCollision

        private void OnCollisionEnter(Collision collision)
        {
            print("碰撞到的物件:" + collision.gameObject);
        }
    }
}
