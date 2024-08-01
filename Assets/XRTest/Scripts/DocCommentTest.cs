using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

// �Ϲ� 1�� �ּ�

/*
   �Ϲ� ������ �ּ�

*/

/// 1��¥�� ���� �ּ�
/// ���� �ּ��� �������� : �±װ� ���� ���ڴ� �Ϲ� �ּ��� ���� �ƹ� ȿ���� ����.

/// <summary>
/// �Ʒ� ���� ��� (class, field, property, method ��)�� ���� �Ϲ� ����
/// </summary>


public class DocCommentTestClass 
{
    /// <summary>
    /// �ǹ� ���� <seealso cref="int"/> ����
    /// </summary>
    public int fieldA;

    /// <summary>
    /// �ǹ� ���� Method.
    /// </summary>
    /// <param name="param">�ǹ� ���� �Ķ����.</param>
    public void SomeMethod(string param)
    {

    }
    /// <summary>
    /// ���� �ǹ̾��� Method.
    /// </summary>
    /// <returns>�ǹ� ���� ��ȯ ��</returns>
    public int SomeReturnableMethod()
    {
        return 0; 
    }
}
/**
 * <summary>
 * ������ ����
 * </summary>
 */

public class DocCommentTest : MonoBehaviour
{
    /// <summary>
    /// �ʿ��� ��쿡�� ���� �Ҵ��ϼ���. �ƴϸ� 0
    /// </summary>
    [Tooltip("�ʿ��� ��쿡�� ���� �Ҵ��ϼ���. �ƴϸ� 0.")]
    public int fieldA;

    [Range(0,1)]
    public int fieldB;

    public string fieldC;

    private void Start()
    {
        DocCommentTestClass classA = new DocCommentTestClass();
        classA.fieldA = 1;
        fieldA = 1; 
        // fieldC = Extentions.IntValueToString(fieldA);

        // ���� �Ķ���� ��, �Ķ���� ������ ��� ���� Ư�� �Ķ���Ϳ� ���� �����ϰ� ���� ���
        // (�Ķ���� �� : ��) ���·� �Լ� ȣ�� ����.
        fieldC = fieldA.IntValueToString(postfix :"cm");

        string jsonData = new MyData().ToJson();
    }
}

[Serializable]
public class MyData
{
    public int level;
    public int stage;
    public int @class;
    // todo : ���� �� �� : ����.
    // ToDo : ���� �� �� : ����.
    // tOdO : ���� �� �� : ����.
}


public static class Extentions
{
    //public static string IntValueToString(this int param)
    //{
    //    return param.ToString();
    //}

    /// <summary>
    /// Ȯ�� �޼��� : ù��° �Ķ���͸� .�����ڸ� ���ؼ� ���� �� �� �ִ� �޼���.
    /// <br/>
    /// ���� ���� : ������ <see langword="static""/> �޼��忩�� �ϰ�, <see langword="static""/> Ŭ������ ������� ��.
    /// </summary>
    /// <param name="param"></param>
    /// <param name="postfix">default �Ķ���� �Ҵ� : �޼��� ȣ�� �� �Ķ���� ���� �Է�����
    /// �ʾƵ� ��. �⺻���� ���޵�. </param>
    /// <returns></returns>
    public static string IntValueToString(this int param, string prefix = "", string postfix = "")
    {
        return $"{prefix}{param.ToString()}{postfix}";
    }

    public static string ToJson(this MyData data)
    {
        // TODO : �̰� ���߿� ������ �������� List�� �ٲ��ּ���.
        return JsonUtility.ToJson(data);
    }
}