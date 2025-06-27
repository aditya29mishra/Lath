using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationCompletionEvent : MonoBehaviour
{
    public bool PlayOnEnable = false;
    public bool DisableAnimatorAfterAnimationComplete = false;
    [Space]
    public Animator animator;
    public string AnimationName;

    [Space, Header("If you want to add delay before start animation, \nthen add a BeforeDelay value.")]
    public float BeforeDelay;
    public UnityEvent BeforeAnimationStart;
    
    [Space, Header("If you want to call the event after some time of playing the animation, \nthen add a Mid_Delay value.")]
    public float Mid_Delay;
    public UnityEvent A_WhileAfterTheAnimation;
    
    [Space]
    public float ExtraDelay = 0;
    public UnityEvent AfterAnimationComplete;

    void OnEnable()
    {
        if (PlayOnEnable)
        {
            StartAnimationCount();
        }
    }

    public void StartAnimationCount()
    {
        StartCoroutine(WaitForAnimation());
    }
    IEnumerator WaitForAnimation()
    {
        yield return new WaitForSeconds(BeforeDelay);
        BeforeAnimationStart.Invoke();
        animator.enabled = true;
        animator.Play(AnimationName);

        StartCoroutine(WaitForMid());

        yield return new WaitForSeconds(.1f);
        float Length = animator.GetCurrentAnimatorStateInfo(0).length + ExtraDelay;

        yield return new WaitForSeconds(Length);
        AfterAnimationComplete.Invoke();
        if (DisableAnimatorAfterAnimationComplete)
        {
            animator.Rebind();
            animator.enabled = false;
        }
    }
    IEnumerator WaitForMid()
    {
        yield return new WaitForSeconds(Mid_Delay);
        A_WhileAfterTheAnimation.Invoke();
    }
}
