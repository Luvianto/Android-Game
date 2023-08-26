using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Animator animator;
    [SerializeField] Joystick joystick;
    [SerializeField, Range(0,10)] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var moveDir = joystick.Direction;
        this.transform.Translate(moveDir * speed * Time.deltaTime);

        if(moveDir.x > 0){
            spriteRenderer.flipX = false;
        }else if(moveDir.x < 0){
            spriteRenderer.flipX = true;
        }
        animator.SetBool("isMove", moveDir != Vector2.zero);
    }
}
