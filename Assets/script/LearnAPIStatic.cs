using UnityEngine;

/// <summary>
/// �ǲ� �R�A API
/// �R�A static
/// </summary>
public class LearnAPIStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ� static properties
        // 1.���o get
        // ���o�R�A�ݩʻy�k�G
        // ���O�W��.�R�A�ݩʦW��
        print("�H���ȡG" + Random.value);
        print("�ù��e�סG" + Screen.width);
        print("��P�v�G" + Mathf.PI);
        // 2.�]�w set (Read Only ����]�w)
    }
}
