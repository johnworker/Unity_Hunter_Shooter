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
        print("�Ǧ^10��k���G�G" + ReturnTen());
        print("�ӫ~�`���G" + CalculatePrice());

        Shoot("���y");                        //�S��|�H�w�]����Ѽ�
        Shoot("�q�y");
        Shoot("�B�y", "������");              //�Ѽ��л\
        Shoot("��q�y", "���W");              //�����w���浲�G���~
        Shoot("��q�y", effect: "���W");      //��q�y,�������A���w �ѼƦW��: ���W

        //��Z������
        Attack(50);
        //���Z������
        Attack(20, "���y");
    }

    // ��k�y�k
    // �^������ ��k�ۭq�W�� (�Ѽ�1, �Ѽ�2, ...) { ��k���e }
    // ���W�z���ѼƳq�`����ĳ�g�Ӧh�A���٬O���ּƹC���O���g�W�L10�ӰѼ�
    // �L�^�� void
    // ��k�W�� Unity �ߺD�Τj�g�}�Y
    private void Text()
    {
        // ��X(���e)
        print("hello world");

    }

    #region ��k�m��
    private void PrintColorText()
    {
        print("<color=yellow>����</color>");
        print("<color=red>����</color>");
        print("<color=#003366>�Ŧ�</color>");
    }

    // �Ǧ^��k
    // �����f�treturn
    private int ReturnTen()
    {
        // �Ǧ^ ��� (��������������P�Ǧ^�����ۦP)
        return 10;
    }

    // �ө��t�ΡG99���A�p��������ӫ~����
    public int countProduct = 10;
    public int countPrice = 99;

    private int CalculatePrice()
    {
        return countProduct * countPrice;
    }

    #endregion

    // �o�g���y�B�o�g�p�q
    // ���񭵮�
    private void shootFire()
    {
        print("�o�g���y");
        print("���񭵮�");
    }

    private void shotLighting()
    {
        print("�o�g�q�y");
        print("���񭵮�");
    }


    // �Ѽƻy�k�G�Ѽ����� �ѼƦW�� ���w �w�]��
    private void Shoot(string type, string sound = "������", string effect = "����")
    {
        print("�o�g�G" + type);
        print("���ġG" + sound);
        print("�S�ġG" + effect);
    }

    // ��k���h�� overload
    // �w�q�G
    // 1.�ۦP�W�٪���k
    // 2.�����P�ƶq���ѼƩΪ̤��P�������Ѽ�
    private void TestMethod()
    {

    }

    private void TestMethod(int number)
    {

    }


    private void Attack(float atk)
    {
        print("��Z�������A�����O�G" + atk);
    }

    private void Attack(float atk, string ball)
    {
        print("���Z�������A�����O�G" + atk);
        print("�o�g����G" + ball);
    }

}
