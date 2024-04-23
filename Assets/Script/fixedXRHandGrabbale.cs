using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class fixedXRHandGrabbale :XRGrabInteractable
{
    // Start is called before the first frame update
    [SerializeField] private Transform leftHandAttachTransform;
    [SerializeField] private Transform rightHandAttachTransform;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = leftHandAttachTransform;
        }
        if (args.interactableObject.transform.CompareTag("RightHand"))
        {
            attachTransform = rightHandAttachTransform;
        }
        base.OnSelectEntered(args);
    }

}
