using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAstroStayR : MonoBehaviour
{

    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject positionBullet;
    
    
    void Update()
    {
        if (Input.GetButtonDown("DownArrow"))
        { 
            Shoot();
        }
        

    }
    private void Shoot () 
    {Instantiate(positionBullet, controladorDisparo.position,controladorDisparo.rotation);
    }
}