using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cobra_Mov : MonoBehaviour
{
    public int speed = 5;

    private bool canMove = true, moving = false;
    private Vector3 pos;

    bool mov_up = false;
    bool mov_down = false;
    bool mov_left = false;
    bool mov_right = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            mov_up = false;
            mov_down = true;
            mov_left = false;
            mov_right = false;
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow)){
            mov_up = true;
            mov_down = false;
            mov_left = false;
            mov_right = false;
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow)){
            mov_up = false;
            mov_down = false;
            mov_left = true;
            mov_right = false;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow)){
            mov_up = false;
            mov_down = false;
            mov_left = false;
            mov_right = true;
        }

        else if(Input.GetKeyDown(KeyCode.Space)){
            mov_up = false;
            mov_down = false;
            mov_left = false;
            mov_right = false;
        }

        if(canMove){
            pos = transform.position;
            move();
        }

        if(moving){
            if(transform.position == pos){
                moving = false;
                canMove = true;

                move();
            }

            transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        }
    }

    private void move(){
        if(mov_up){
            canMove = false;
            moving = true;
            pos += Vector3.up;
        }
        else if (mov_down){
            canMove = false;
            moving = true;
            pos += Vector3.down;
        }
        else if(mov_left){
            canMove = false;
            moving = true;
            pos += Vector3.left;
        }
        else if (mov_right){
            canMove = false;
            moving = true;
            pos += Vector3.right;
        }
    }
}
