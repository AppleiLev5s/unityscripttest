using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int JumpFactor = 2;
    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= JumpFactor;
    }
    public void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= JumpFactor;
    }
}
