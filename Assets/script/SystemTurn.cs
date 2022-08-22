using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LEO{ 
public class SystemTurn : MonoBehaviour
{
        /// <summary>
        /// 寄
        /// </summary>
        public UnityEvent onTurnEnemy;

        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        /// <summary>
        /// 紆痌羆计
        /// </summary>
        private int totleCountMarble;

        /// <summary>
        /// ┣籔紆痌羆计
        /// </summary>
        private int totalCountEnemyLive;

        /// <summary>
        /// Μ紆痌计秖
        /// </summary>
        private int totalRecycleMarble;
        private void Awake()
        {
            systemControl = GameObject.Find("ガ狶").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("ネΘ┣╰参").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("Μ紆痌").GetComponent<RecycleArea>();

            recycleArea.onRecycle.AddListener(RecycleMarble);
        }

       private void RecycleMarble()
        {
            totleCountMarble = systemControl.canShootMarbleTotal;

            totalRecycleMarble++;
            print("<color=yellow>紆痌Μ计秖" + totalRecycleMarble + "</color>");

            if(totalRecycleMarble == totleCountMarble)
            {
                print("ΜЧ拨传寄");
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