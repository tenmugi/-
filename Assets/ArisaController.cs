using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArisaController : MonoBehaviour
{
    Animator animator;
    private float groundLevel = -0.3f;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.animator.SetFloat("Horizonal", 1);

        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);
    }
}
