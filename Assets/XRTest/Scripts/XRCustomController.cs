using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

// ��Ʈ�ѷ� �Է¿� �߰� �׼��� �ϵ��� ����� ������Ʈ
// [RequireComponent(typeof(ActionBasedController))]
public class XRCustomController : MonoBehaviour
{
    public ActionBasedController targetCont;
    private InputActionReference activateRef; // ���� Ʈ���� ��ư
    private InputActionReference selectRef; // ���� ���� ��ư
    public InputActionReference AButton; // A ��ư
    public InputActionReference BButton; // B ��ư
    private ControllerAnimation contAnim;



    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        contAnim = GetComponentInChildren<ControllerAnimation>();

        activateRef = targetCont.activateAction.reference;
        selectRef = targetCont.selectAction.reference;

        activateRef.action.performed += delegate (InputAction.CallbackContext context)
        {
            contAnim.TriggerActivate(context.performed);
        };

        activateRef.action.canceled += delegate (InputAction.CallbackContext context)
        {
            contAnim.TriggerActivate(context.performed);
        };

        AButton.action.performed += delegate (InputAction.CallbackContext abutton)
        {
            contAnim.AbuttonActivate(abutton.performed);
        };

        AButton.action.canceled += delegate (InputAction.CallbackContext abutton)
        {
            contAnim.AbuttonActivate(abutton.performed);
        };

        selectRef.action.performed += contAnim.BumperActivate;
        selectRef.action.canceled += contAnim.BumperActivate;
    }

}
