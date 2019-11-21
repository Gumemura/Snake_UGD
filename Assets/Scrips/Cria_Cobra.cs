using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cria_Cobra : MonoBehaviour
{
    public GameObject maca_contato;
    public Rigidbody2D corpo_Cobra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(maca_contato.transform.Find("Maca(Clone)").position == transform.position){
            Instantiate(corpo_Cobra, transform.position, Quaternion.identity, transform); }
    }
}
