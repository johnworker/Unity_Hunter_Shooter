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
        public GameObject arraw;
        // ����t��
        [Header("����t��"), Range(0, 500)]
        public float speedTurn = 10.5f;
        // �u�]�w�m��
        [Header("�u�]�w�m��")]
        public GameObject mrable;
        // �u�]�i�o�g���`��
        [Header("�u�]�i�o�g���`��"), Range(0, 50)]
        public int canShootMarbleTotle = 15;
        #endregion

        #region �ƥ�
        #endregion

        #region ��k
        #endregion

    }

}
