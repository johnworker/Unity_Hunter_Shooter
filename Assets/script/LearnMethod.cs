using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMethod : MonoBehaviour
{

    // �ۭq��k
    // �ݭn�I�s�~�|����

    // Unity���J�f
    // �}�l�ƥ� (�Ŧ�W��)
    // ����C����|����@��
    // ��l�Ƴ]�w�G��l���B�B�T���R������

    private void Start()
    {
        // �I�s��k
        // ��k�W��
        Text();
        PrintColorText();
    }

    // ��k�y�k
    // �^������ ��k�ۭq�W�� () { ��k���e }
    // �L�^�� void
    // ��k�W�� Unity �ߺD�Τj�g�}�Y
    private void Text()
    {
        // ��X(���e)
        print("hello world");

    }

    private void PrintColorText()
    {
        print("<color=yellow>����</color>");
        print("<color=red>����</color>");
        print("<color=#003366>�Ŧ�</color>");
    }
}
