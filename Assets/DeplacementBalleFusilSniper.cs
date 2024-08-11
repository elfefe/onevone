using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementBalleFusilSniper : MonoBehaviour
{


    float vitesseBalle = 0F;

    Vector3 directionBalle;

    //  float angle = 0F;

    // Start is called before the first frame update
    void Start()
    {

        vitesseBalle = tirPlayerFusilSniper.vitesseBalle;
        //  angle = Deplacement.angle  ;

        //   directionBalle = stopCollider.directionRayonPourBalle  ;

        directionBalle = RefObject.fusilAssautM.transform.right * Time.deltaTime * vitesseBalle;

    }

    // Update is called once per frame
    void Update()
    {

        //  directionBalle =   transform.position -   fusil.transform.position * Time.deltaTime;

        //transform.position += directionBalle;
        transform.position += directionBalle;






    }

}
