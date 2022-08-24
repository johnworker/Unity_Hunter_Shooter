using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LEO
{
    public class SystemCoin : MonoBehaviour
    {
        [SerializeField, Header("���橵��"), Range(0, 2)]
        private float delayFly = 1.5f;
        [SerializeField, Header("����t��"), Range(0, 10)]
        private float speed = 1.5f;


        private Transform traCoinFlyTo;
        /// <summary>
        /// �����t�ΡG�����I���B���������m
        /// </summary>

        private bool startFly;

        private ManagerCoin managerCoin;
        private void Awake()
        {
            Physics.IgnoreLayerCollision(6, 3);     // �����B�u�]�����I��
            Physics.IgnoreLayerCollision(6, 6);     // �����B���������I��
            Physics.IgnoreLayerCollision(6, 7);     // �����B�Ǫ������I��

            traCoinFlyTo = GameObject.Find("�����n�e������m").transform;
            managerCoin = GameObject.Find("�����޲z��").GetComponent<ManagerCoin>();

            // Invoke �O�I�s�禡
            Invoke("StartFly", delayFly);
        }

        private void Update()
        {
            Fly();
        }

        #region �}�l����
        /// <summary>
        /// �}�l����
        /// </summary>
         #endregion
        private void StartFly()
        {
            startFly = true;
        }
       

        private void Fly()
        {
            if (!startFly) return;

            // ���ȡG�N A B ��Ӽƭȧ�X���������w��m
            Vector3 traCoin = transform.position;
            Vector3 traCoinTo = traCoinFlyTo.position;

            traCoin = Vector3.Lerp(traCoin, traCoinTo, 0.05f);
            transform.position = traCoin;

            DestroyCoin();
        }

        private void DestroyCoin()
        {
            float dis = Vector3.Distance(transform.position, traCoinFlyTo.position);

            if(dis < 1)
            {
                managerCoin.AddCoinAndUpdate();
                Destroy(gameObject);
            }
        }
    }

}
