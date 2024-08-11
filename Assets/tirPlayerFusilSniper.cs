using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirPlayerFusilSniper : MonoBehaviour
{
    public GameObject balle;





   public static bool stopCadence = false;
        float tempCadence = 0.45F;


    public static float vitesseBalle = 0F;///donne l information de vitesse a la balle 
     float vitesseBalleM = 140F;


    // Start is called before the first frame update
    void Start()
    {
        // mode prod vitesseBalle = vitesseBalleM  ;
    }

    // Update is called once per frame
    void Update()
    {
        //test
        vitesseBalle = vitesseBalleM;


        if (RefManette.btnR1isPressed)
        {

             

            if (!stopCadence)
            {
                stopCadence = true;
                ///tir fusil assaut 
                StartCoroutine(rafaleFusilSniper());
            }


            //    Debug.Log(transform.eulerAngles.y);
            //    Debug.Log(fusil.transform.eulerAngles.y);



            //   Debug.Log(transform.eulerAngles.z);
            //  Debug.Log(fusil.transform.eulerAngles.z);
        }





    }


    /*** lance la coroutine **/





    IEnumerator rafaleFusilSniper()
    {

        ////tir 1
        GameObject balleclone = Instantiate(balle, transform.position, Quaternion.identity) as GameObject;
        //balleclone.transform.up =   transform.up   ;  
        /*** prend la rotation de notre depart de tir    on le tourne manuellement grace a l objet  depart de tir dans la scene on fait des test  pour que quand on tire la balle soit dans la bonne direction si c est pas le cas on tourne le depart de tir jus qu a trouver le bonne angle ***/
        balleclone.transform.rotation = transform.rotation;


        yield return new WaitForSeconds(tempCadence*6);
         

      
        ////permet a nouveau de tirez 
        stopCadence = false;



    }

}
