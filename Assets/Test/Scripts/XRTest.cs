using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRTest : MonoBehaviour
{
    public void Print(string message) => print(message); // => = {}

    public void FirstSelectEnterEvent(SelectEnterEventArgs args)
    {
        print($"{args.interactableObject.transform.name}" + 
            $"는 {args.interactorObject.transform.parent.name} 에게 먼저 선택됨.");  
    }
    public void LastSelectEnterEvent(SelectExitEventArgs args)
    {
        print($"{args.interactableObject.transform.name}" +
           $"는 {args.interactorObject.transform.parent.name} 에게 마지막으로 선택해제됨.");
    }
    public void SelectEnterEvent(SelectEnterEventArgs args)
    {
        print($"{args.interactableObject.transform.name}" +
           $"는 {args.interactorObject.transform.parent.name} 에게 선택됨.");
    }
    public void SelectExitEvent(SelectExitEventArgs args)
    {
        print($"{args.interactableObject.transform.name}" +
           $"는 {args.interactorObject.transform.parent.name} 에게 선택해제됨.");
    }
}
