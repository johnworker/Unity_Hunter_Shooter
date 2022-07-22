using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LEO
{ 
    /// <summary>
    /// ���a����t��
    /// �������B�u�]�o�g
    /// </summary>
public class SystemControl : MonoBehaviour
{
        #region ���
        // GameObject �C������
        // �s�񶥼h���O���αM�פ�������

        // �b�Y
        [Header("�b�Y")]
        public GameObject arrow;
        // ����t��
        [Header("����t��"), Range(0, 500)]
        public float speedTurn = 10.5f;
        // �u�]�w�m��
        [Header("�u�]�w�m��")]
        public GameObject mrable;
        // �u�]�i�o�g���`��
        [Header("�u�]�i�o�g���`��"), Range(0, 50)]
        public int canShootMarbleTotle = 15;
        // �u�]�ͦ��I
        [Header("�u�]�ͦ��I")]
        public Transform traSpawnPoint;
        // �����ѼƦW��
        [Header("�����ѼƦW��")]
        public string parAttack = "Ĳ�o����";
        // �u�]�o�g�t��
        [Header("�u�]�o�g�t��"), Range(0, 5000)]
        public float speedMarble = 1000;
        [Header("�u�]�o�g����"), Range(0, 2)]
        public float intervalMarble = 0.5f;

        public Animator ani;
        #endregion

        #region �ƥ�
        private void Update()
        {
            ShootMarble();
        }
        #endregion

        #region ��k

        /// <summary>
        ///  ���ਤ��A�����⭱�V�u�]����m
        /// </summary>
        private void TurnCharacter()
        {

        }

        /// <summary>
        ///  �o�g�u�]�A�ھڼu�]�`�Ƶo�g����
        /// </summary>
        private void ShootMarble()
        {
            // ���U �ƹ����� ��� �b�Y
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }

            // ��} �ƹ����� �ͦ��õo�g�u�]
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                //print("��}����I");
                arrow.SetActive(false);
                StartCoroutine(spawnMarble());
            }
        }

        private IEnumerator spawnMarble()
        {
            for (int i = 0; i < canShootMarbleTotle; i++)
            {
                // Object ���O�i�ٲ����g
                // �����z�L Object �����W�٨ϥ�
                // �ͦ�(�u�])�F traSpawnPoint
                // Quaternion.identity �s�ר�
                GameObject tempMarble = Instantiate(mrable,traSpawnPoint.position, Quaternion.identity);

                // �Ȧs�u�] ���o���餸�� �K�[���O (����.�e�� * �t��)
                // transform.forward ���⪺�e��
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);
                yield return new WaitForSeconds(intervalMarble);
            }

        }
        /// <summary>
        ///  �^���u�]
        /// </summary>
        private void RecycleMarble()
        {

        }

        #endregion

    }

}
