using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassiopeiAnim : MonoBehaviour
{
    public Animator animator;
    public int level=1;
    void Start()
    {
        
    }
    void Update()
    {
        animator.SetInteger("level", level);
        
    }
}
