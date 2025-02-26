using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class animatorController : MonoBehaviour
{
    public Animator animator;
    public Vector2 scrollValue = Vector2.zero;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("");
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {

        }
        if (Input.mouseScrollDelta.y < 1.0f)
        {

        }
        else if (Input.mouseScrollDelta.y < 2.0f)
        {

        }
        else if (Input.mouseScrollDelta.y < 3.0f)
        {

        }
        else if (Input.mouseScrollDelta.y > 3.0f)
        {
            Input.mouseScrollDelta.y = 3.0f;
        }
    }
}
