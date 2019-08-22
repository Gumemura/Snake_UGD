using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Maca : MonoBehaviour
{
    public GameObject maca;
    bool flag_maca = true;
    
    public Rigidbody2D cobra_contato;

    void Start(){
    }

    void Update() {
        if(flag_maca){
            Invoke("GeraMaca", 5);
        }
    }

    void GeraMaca()
    {
        int posX = Random.Range(-8,8);
        int posY = Random.Range(-4, 4);

        flag_maca = false;

        Instantiate(maca, new Vector3(posX, posY, 0), Quaternion.identity);
    }

    void PegaContato(){
        if(cobra_contato.transform.position == maca.transform.position){
            Debug.Log("MACA E COBRA NO MESMO LUGAR");
        }

    }
}
