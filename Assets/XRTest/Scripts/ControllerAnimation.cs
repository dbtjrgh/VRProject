using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ControllerAnimation : MonoBehaviour
{
    public Transform trigger;
    public Transform bumper;
    public Transform Abutton;
    public Transform Bbutton;

    public UnityEngine.XR.Content.Interaction.LaunchProjectile launch;

    public void TriggerActivate(bool isPush)
    {
            trigger.transform.Rotate(isPush ? -10 : 10, 0, 0);

        if (launch is not null && isPush)
        {
            launch.Fire();
        }
    }

    public void BumperActivate(InputAction.CallbackContext context)
    {
        bumper.transform.Translate(context.performed ? 0.002f : -0.002f, 0, 0);
    }

    public void AbuttonActivate(InputAction.CallbackContext context)
    {
        Abutton.transform.Translate(0.0f, context.performed ? -0.001f : 0.001f, 0.0f);
    }
    public void BbuttonActivate(InputAction.CallbackContext context)
    {
        Bbutton.transform.Translate(0.0f, context.performed ? -0.001f : 0.001f, 0.0f);
    }
}
