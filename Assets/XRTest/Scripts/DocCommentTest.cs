using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

// 일반 1줄 주석

/*
   일반 여러줄 주석

*/

/// 1줄짜리 설명서 주석
/// 설명서 주석의 강제사항 : 태그가 없는 문자는 일반 주석과 같이 아무 효과가 없음.

/// <summary>
/// 아래 오는 요소 (class, field, property, method 등)에 대한 일반 설명
/// </summary>


public class DocCommentTestClass 
{
    /// <summary>
    /// 의미 없는 <seealso cref="int"/> 변수
    /// </summary>
    public int fieldA;

    /// <summary>
    /// 의미 없는 Method.
    /// </summary>
    /// <param name="param">의미 없는 파라미터.</param>
    public void SomeMethod(string param)
    {

    }
    /// <summary>
    /// 역시 의미없는 Method.
    /// </summary>
    /// <returns>의미 없는 반환 값</returns>
    public int SomeReturnableMethod()
    {
        return 0; 
    }
}
/**
 * <summary>
 * 여러줄 설명문
 * </summary>
 */

public class DocCommentTest : MonoBehaviour
{
    /// <summary>
    /// 필요한 경우에만 값을 할당하세요. 아니면 0
    /// </summary>
    [Tooltip("필요한 경우에만 값을 할당하세요. 아니면 0.")]
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

        // 여러 파라미터 중, 파라미터 순서에 상관 없이 특정 파라미터에 값을 전달하고 싶을 경우
        // (파라미터 명 : 값) 형태로 함수 호출 가능.
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
    // todo : 오늘 살 것 : 대파.
    // ToDo : 내일 살 것 : 양파.
    // tOdO : 어제 산 것 : 쪽파.
}


public static class Extentions
{
    //public static string IntValueToString(this int param)
    //{
    //    return param.ToString();
    //}

    /// <summary>
    /// 확장 메서드 : 첫번째 파라미터를 .연산자를 통해서 대입 할 수 있는 메서드.
    /// <br/>
    /// 제약 조건 : 무조건 <see langword="static""/> 메서드여야 하고, <see langword="static""/> 클래스의 멤버여야 함.
    /// </summary>
    /// <param name="param"></param>
    /// <param name="postfix">default 파라미터 할당 : 메서드 호출 시 파라미터 값을 입력하지
    /// 않아도 됨. 기본값이 전달됨. </param>
    /// <returns></returns>
    public static string IntValueToString(this int param, string prefix = "", string postfix = "")
    {
        return $"{prefix}{param.ToString()}{postfix}";
    }

    public static string ToJson(this MyData data)
    {
        // TODO : 이거 나중에 데이터 많아지면 List로 바꿔주세요.
        return JsonUtility.ToJson(data);
    }
}