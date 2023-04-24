using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerMenu : MonoBehaviour
{
  public GameObject Panel;
  
    public void ShowMenu()
    {
      Animator animator = Panel.GetComponent<Animator>();
      bool Open = animator.GetBool("slide");
      animator.SetBool("slide",!Open); 
    }  
}
