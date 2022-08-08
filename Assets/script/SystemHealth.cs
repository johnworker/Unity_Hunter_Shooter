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


        // �I���ƥ�
        // 1.��Ӫ��󥲶����@�ӱa�� Rigidbody
        // 2.��Ӫ��󥲶����I���� Collider
        // 3.�O�_���Ŀ� Is Trigger
        // 3-1. ��̳��S���Ŀ� Is Trigger �ϥ� OnCollision

        private void OnCollisionEnter(Collision collision)
        {
            print("�I���쪺����:" + collision.gameObject);
        }
    }
}
