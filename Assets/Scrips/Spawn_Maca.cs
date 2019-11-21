using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn_Maca : MonoBehaviour
{
    public GameObject maca;
    public Rigidbody2D cobra_contato;
    public GameObject parent;
    bool can_spawn = true;

    void Update(){
        if(can_spawn){
            Invoke("GeraMaca", 3);
            can_spawn = false;
        }
        PegaContato();
    }

    void GeraMaca(){
        int posX = Random.Range(-8,8);
        int posY = Random.Range(-4, 4);

        Instantiate(maca, new Vector3(posX, posY, 0), Quaternion.identity, parent.transform);
    }

    void PegaContato(){

        if(parent.transform.Find("Maca(Clone)").position == cobra_contato.transform.position){
            foreach (Transform child in gameObject.transform){
                GameObject.Destroy(child.gameObject);
            }
            can_spawn = true;
        }
    }
}
