using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnim : MonoBehaviour
{
    CharHP HP;
    private Animator _animator;
    private Charactermove personController;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        personController = GetComponent<Charactermove>();
        HP = GetComponent<CharHP>();
    }
    private void OnEnable()
    {
        HP.onDeadAnim += DeadAnim;
        personController.onMovePerson += MoveAnim;
        personController.onJumpingPerson += JumpAnim;
        personController.onSliderPerson += SliderAnim;
    }
    private void OnDisable()
    {
        personController.onMovePerson -= MoveAnim;
        personController.onJumpingPerson -= JumpAnim;
        personController.onSliderPerson -= SliderAnim;
        HP.onDeadAnim -= DeadAnim;
    }
    private void MoveAnim(float horizontal)
    {
        _animator.SetFloat("X", Mathf.Abs(horizontal));
    }
    private void JumpAnim(bool isJumping)
    {
        _animator.SetBool("isJumping", isJumping);
    }
    private void SliderAnim(bool isSlide)
    {
        _animator.SetBool("isSlider", isSlide);
    }
    void DeadAnim()
    {
        _animator.SetTrigger("Dead Trigger");
    }
}
