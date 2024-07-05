using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerAnimation : MonoBehaviour {
	public Transform trigger;
	public Transform bumper;
	public void TriggerActivate(bool isPush) {
		trigger.transform.Rotate(isPush ? -10 : 10, 0, 0);
	}

	public void BumperActivate(InputAction.CallbackContext context) {
		bumper.transform.Translate(context.performed ? 0.002f : -0.002f, 0, 0);
	}

}
