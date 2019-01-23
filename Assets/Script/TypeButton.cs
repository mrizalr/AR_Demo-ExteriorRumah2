using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeButton : MonoBehaviour {

    Animator m_Animator;
    bool isOpen;

	// Use this for initialization
	void Start () {
        m_Animator = GetComponent<Animator>();
        m_Animator.Play("TypeButton 0");
        isOpen = false;
    }
	
    public void ClickOpen()
    {
        if (!isOpen)
        {
            m_Animator.Play("TypeButton");
            isOpen = true;
        }
        else if (isOpen)
        {
            m_Animator.Play("TypeButton 0");
            isOpen = false;
        }
    }

}
