using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Leo
{ 
    /// <summary>
    /// �ͦ��Ǫ��t��
    /// </summary>
    public class SystemSpawn : MonoBehaviour
        {
        #region ���
        [Header("�Ǫ��}�C"), SerializeField]
        private GameObject[] goEnemys;
        [Header("�ͦ���l�ĤG�Ʈy��"), SerializeField]
        private Transform[] traSecondPlace;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            SpawnRandomEnemy();
        }
        #endregion

        #region ��k
        /// <summary>
        /// �ͦ��H���ĤH
        /// </summary>
        private void SpawnRandomEnemy()
        {
            int min = 2;
            int max = traSecondPlace.Length;
            print(Random.Range(min, max));
        }
        #endregion

    }

}