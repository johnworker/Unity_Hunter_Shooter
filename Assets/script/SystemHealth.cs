using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace LEO {
    public class SystemHealth : MonoBehaviour
    {
        [SerializeField, Header("�e���ˮ`����")]
        private GameObject goDamage;
        [SerializeField, Header("�Ϥ���q")]
        private Image imgHp;
        [SerializeField, Header("��r��q")]
        private TextMeshProUGUI textHp;
        [SerializeField, Header("�Ǫ����")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("�ĤH�ʵe����")]
        private Animator aniEnemy;

        private float hp;
        private string parDamage = "Ĳ�o����";
        private void Awake()
        {
            hp = dataEnemy.hp;
        }

        // �I���ƥ�
        // 1.��Ӫ��󥲶����@�ӱa�� Rigidbody
        // 2.��Ӫ��󥲶����I���� Collider
        // 3.�O�_���Ŀ� Is Trigger
        // 3-1. ��̳��S���Ŀ� Is Trigger �ϥ� OnCollision


        #region �I���ƥ�
        private void OnCollisionEnter(Collision collision)
        {
            //print("�I���쪺����:" + collision.gameObject);

            GetDamage();
        }
        #endregion

        /// <summary>
        /// ����
        /// </summary>
        private void GetDamage()
        {
            hp -= 50;
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / dataEnemy.hp;
            aniEnemy.SetTrigger(parDamage);

            if (hp <= 0) Dead();
        }

        private void Dead()
        {
            print("���`");
        }
    }
}
