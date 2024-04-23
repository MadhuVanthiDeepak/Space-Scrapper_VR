using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputActionReference gripReferences;
    [SerializeField] private Animator handAnimator;

    [SerializeField] private InputActionReference triggerReferences;
   



    // Update is called once per frame
    void Update()
    {
        float gripValue = gripReferences.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);

        float triggerValue = triggerReferences.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);


    }
}
