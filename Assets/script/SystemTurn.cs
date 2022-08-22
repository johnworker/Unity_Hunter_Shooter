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
        private void Awake()
        {
            systemControl = GameObject.Find("�����L").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("�^���u�]").GetComponent<RecycleArea>();

            recycleArea.onRecycle.AddListener(RecycleMarble);
        }

       private void RecycleMarble()
        {
            totleCountMarble = systemControl.canShootMarbleTotal;

            totalRecycleMarble++;
            print("<color=yellow>�u�]�^���ƶq�G" + totalRecycleMarble + "</color>");

            if(totalRecycleMarble == totleCountMarble)
            {
                print("�^�������A���ĤH�^�X");
                onTurnEnemy.Invoke();
            } 
        }
        /// <summary>
        /// 
        /// </summary>
        public void MoveEndSpawnEnemy()
        {
            systemSpawn.SpawnRandomEnemy();
        }
    }

}