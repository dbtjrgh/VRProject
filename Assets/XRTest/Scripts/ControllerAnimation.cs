using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerAnimation : MonoBehaviour
{
    public Transform trigger;
    public Transform bumper;
    public Transform Abutton;

    public void TriggerActivate(bool isPush)
    {
            trigger.transform.Rotate(isPush ? -10 : 10, 0, 0);
    }

    public void BumperActivate(InputAction.CallbackContext context)
    {
        bumper.transform.Translate(context.performed ? 0.002f : -0.002f, 0, 0);
    }

    public void AbuttonActivate(bool Push)
    {
        Abutton.transform.Rotate(Push ? -10 : 10, 0, 0);
    }
}
