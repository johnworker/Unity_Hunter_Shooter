using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LEO{ 
public class SystemTurn : MonoBehaviour
{
        /// <summary>
        /// �ĤH�^�X
        /// </summary>
        public UnityEvent onTurnEnemy;

        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        /// <summary>
        /// �u�]�`��
        /// </summary>
        private int totleCountMarble;

        /// <summary>
        /// �Ǫ��P�i�H�Y���u�]�s���`��
        /// </summary>
        private int totalCountEnemyLive;

        /// <summary>
        /// �^���u�]�ƶq
        /// </summary>
        private int totalRecycleMarble;

        private bool canSpawn = true;
        private void Awake()
        {
            systemControl = GameObject.Find("���p�j").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("�^���ϰ�").GetComponent<RecycleArea>();

            recycleArea.onRecycle.AddListener(RecycleMarble);
        }

       private void RecycleMarble()
        {
            totleCountMarble = systemControl.canShootMarbleTotal;

            totalRecycleMarble++;
            // print("<color=yellow>�u�]�^���ƶq�G" + totalRecycleMarble + "</color>");

            if(totalRecycleMarble == totleCountMarble)
            {
                // print("�^�������A���ĤH�^�X");
                onTurnEnemy.Invoke();
            } 
        }
        /// <summary>
        /// ���ʵ������ͦ��ĤH�M�u�]
        /// </summary>
        public void MoveEndSpawnEnemy()
        {
            if (!canSpawn) return;

            canSpawn = false;
            systemSpawn.SpawnRandomEnemy();
            Invoke("PlayerTurn", 1);
        }
        /// <summary>
        /// ���a�^�X
        /// </summary>
        private void PlayerTurn()
        {
            systemControl.canShootMarble = true;
            canSpawn = true;
            totalRecycleMarble = 0;
        }
    }

}