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
        [SerializeField, Header("怪物資料")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("敵人動畫控制")]
        private Animator aniEnemy;

        private float hp;
        private string parDamage = "觸發受傷";

        private SystemSpawn systemSpawn;
        private void Awake()
        {
            hp = dataEnemy.hp;
            textHp.text = hp.ToString();
            systemSpawn = GameObject.Find("生成怪物系統").GetComponent<SystemSpawn>();
        }

        // 碰撞事件
        // 1.兩個物件必須有一個帶有 Rigidbody
        // 2.兩個物件必須有碰撞器 Collider
        // 3.是否有勾選 Is Trigger
        // 3-1. 兩者都沒有勾選 Is Trigger 使用 OnCollision


        #region 碰撞事件
        private void OnCollisionEnter(Collision collision)
        {
            //print("碰撞到的物件:" + collision.gameObject);

            GetDamage();
        }
        #endregion

        /// <summary>
        /// 受傷
        /// </summary>
        private void GetDamage()
        {
            float getDamage = 50;
            hp -= getDamage;
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / dataEnemy.hp;
            aniEnemy.SetTrigger(parDamage);
            Vector3 pos = transform.position + Vector3.up;
            SystemDamage temDamage = Instantiate(goDamage, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamage>();
            temDamage.damage = getDamage;

            if (hp <= 0) Dead();
        }

        private void Dead()
        {
            //print("死亡");
            Destroy(gameObject);
            systemSpawn.totalCountEnemyLive--;
        }
    }
}
