using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Maca : MonoBehaviour
{
    public GameObject maca;

    void Start()
    {
        InvokeRepeating("GeraMaca", 5, 10);
    }

    void GeraMaca()
    {
        int posX = Random.Range(-8,8);
        int posY = Random.Range(-4, 4);

        Instantiate(maca, new Vector3(posX, posY, 0), Quaternion.identity);
    }
}
