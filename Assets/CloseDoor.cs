using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{

    public ButtonPushDoorOpen b;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            b.animator.SetBool("Open", false);
        }
    }
}
