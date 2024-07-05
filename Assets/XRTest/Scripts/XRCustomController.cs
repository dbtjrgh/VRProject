using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

//��Ʈ�ѷ� �Է¿� �߰� �׼��� �ϵ��� ����� ������Ʈ
public class XRCustomController : MonoBehaviour {

	public ActionBasedController targetCont;
	private InputActionReference activateRef;//���� Ʈ���� ��ư
	private InputActionReference selectRef;//���� ���� ��ư
	private ControllerAnimation contAnim;

	public InputActionReference buttonRef;

	private IEnumerator Start() {
		yield return new WaitForEndOfFrame();
		contAnim = GetComponentInChildren<ControllerAnimation>();

		activateRef = targetCont.activateAction.reference;
		selectRef = targetCont.selectAction.reference;

		activateRef.action.performed += delegate (InputAction.CallbackContext context) {
			contAnim.TriggerActivate(context.performed);
		};

		activateRef.action.canceled += delegate (InputAction.CallbackContext context) {
			contAnim.TriggerActivate(context.performed);
		};

		selectRef.action.performed += contAnim.BumperActivate;
		selectRef.action.canceled += contAnim.BumperActivate;

		buttonRef.action.performed += _ => print("B");
	}


}
