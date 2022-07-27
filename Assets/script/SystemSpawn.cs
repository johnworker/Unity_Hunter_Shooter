using System.Collections;
using System.Collections.Generic;       // ��Ƶ��c�M��
using System.Linq;                      // �d�߻y��
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

        [SerializeField]
        private List<Transform> listScendPlace = new List<Transform>();
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

            int randomCount = Random.Range(min, max);
            print("�Ǫ��H���ƶq�G" + randomCount);

            // �M�� = �}�C.�ഫ�M��();
            listScendPlace = traSecondPlace.ToList();

            // �H������
            System.Random random = new System.Random();
            // �M�� = �M�檺�Ƨ�(�C�ӲM�椺�e => �H���Ƨ�).�ର�M��
            listScendPlace = listScendPlace.OrderBy(x => random.Next()).ToList();

            int sub = traSecondPlace.Length - randomCount;
            print("�n�������ƶq�G" + sub);

            // �j�� �R�� �n�������ƶq
            for (int i = 0; i < sub; i++)
            {
                // �R���Ĥ@�ӲM����
                listScendPlace.RemoveAt(0);
            }

            // �ͦ��Ҧ��Ǫ�
            for (int i = 0; i < listScendPlace.Count; i++)
            {
                // �H���Ǫ�
                int randomIndex = Random.Range(0, goEnemys.Length);
                // �ͦ��Ǫ�
                Instantiate(
                    goEnemys[randomIndex],
                    listScendPlace[i].position,
                    Quaternion.identity
                    );
            }
        }
        #endregion

    }

}