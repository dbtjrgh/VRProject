using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void SomeEvent(int a);

public class CsharpEventTest : MonoBehaviour
{
    // C#�� �̺�Ʈ��
    // 1. �̺�Ʈ�� ������ Ŭ������ ȣ���� �� �ִ�.
    // 2. delegate �ʵ�� Interface���� ������ �� ������ event�� ����.
    // �̷� ������ Event�� �����ϴ� ������ Observer ������ ������ ���ؼ�
    public event SomeEvent someEvent;
    public event Action<int, int> someAction;

    void Start()
    {
        EventTestClass testClass = new EventTestClass();
        testClass.OnInit(this);

        someEvent?.Invoke(1);
    }
}

public class EventTestClass
{
    public void OnInit(CsharpEventTest tester)
    {
        tester.someEvent += (int a) => { new GameObject(a.ToString()); };
    }
}

public interface IDestroyable
{
    public event SomeEvent OnDestroy;
}

public class DestroyWhen10Sec : IDestroyable
{
    public event SomeEvent OnDestroy;

    // 10�� �Ŀ� �ı��Ǹ鼭 ȣ��� �Լ�
    private void WhenDestroy()
    {
        // �ı��Ǵ� ������ ���� �Ŀ� 
        OnDestroy?.Invoke(1);
    }
}


