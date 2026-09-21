using UnityEngine;

public class Character : MonoBehaviour
{
    protected Health health;
    protected Collider characterCollider;
    protected Animator characterAnimator;

    protected virtual void Awake()
    {
        health = GetComponent<Health>();
        characterCollider = GetComponent<Collider>();
        characterAnimator = GetComponent<Animator>();
    }
}