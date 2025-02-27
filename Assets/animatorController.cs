using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class animatorController : MonoBehaviour
{
    public Animator boolAnimator;
    public Animator scrollAnimator;
    public Animator triggerAnimator;
    public Material floatMat;
    private Vector2 scrollValue = Vector2.zero;
    public bool boolValue;
    public float floatValue;
    void Start()
    {
        boolValue = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            triggerAnimator.SetTrigger("TriggerVal");
            Debug.Log("Triggered");
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (boolValue == false)
            {
                boolValue = true;
            }
            if (boolValue == true)
            {
                boolValue = false;
            }
        }
        if (Input.mouseScrollDelta.y < 1.0f)
        {
            floatMat.color = Color.yellow;
        }
        else if (Input.mouseScrollDelta.y < 2.0f)
        {
            floatMat.color = Color.green;
        }
        else if (Input.mouseScrollDelta.y < 3.0f)
        {
            floatMat.color = Color.blue;
        }
        else if (Input.mouseScrollDelta.y > 3.0f)
        {
            //Input.mouseScrollDelta.y = 3.0f;
        }
        if (boolValue == false)
        {
            boolAnimator.SetBool("ActiveAnim", true);
        }
        if (boolValue == true)
        {
            boolAnimator.SetBool("ActiveAnim", false);
        }
    }
}
