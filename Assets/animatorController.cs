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
    private float scrollValue;
    public bool boolValue;
    public float floatValue;
    void Start()
    {
        boolValue = false;
        scrollValue = Input.mouseScrollDelta.y;
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
                boolAnimator.SetBool("ActiveAnim", true);
            }
            else if (boolValue == true)
            {
                boolValue = false;
                boolAnimator.SetBool("ActiveAnim",false);
            }
        }
        if (scrollValue < 1.0f)
        {
            floatMat.color = Color.yellow;
        }
        else if (scrollValue < 2.0f)
        {
            floatMat.color = Color.green;
        }
        else if (scrollValue < 3.0f)
        {
            floatMat.color = Color.blue;
        }
        else if (scrollValue > 3.0f)
        {
            //Input.mouseScrollDelta.y = 3.0f;
        }
    }
}
