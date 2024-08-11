using System.Collections;
using UnityEngine;



public class tirPlayerFusilAssaut : MonoBehaviour
{


   public GameObject balle ;





    public static bool stopCadence = false ;
    public float tempCadence = 0.1F;


    public static float vitesseBalle = 0F  ;
    public   float vitesseBalleM = 80F;


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
         
            if(!stopCadence)
            {
                stopCadence = true  ;
               ///tir fusil assaut 
                 StartCoroutine(rafaleFusilAssaut());
            }
          

             // Debug.Log(stopCadence);
            //    Debug.Log(fusil.transform.eulerAngles.y);



            //   Debug.Log(transform.eulerAngles.z);
            //  Debug.Log(fusil.transform.eulerAngles.z);
        }





    }


    /*** lance la coroutine **/

    



   IEnumerator rafaleFusilAssaut()
    {

////tir 1
        GameObject balleclone = Instantiate(balle, transform.position, Quaternion.identity) as GameObject;
        //balleclone.transform.up =   transform.up   ;  
        /*** prend la rotation de notre depart de tir    on le tourne manuellement grace a l objet  depart de tir dans la scene on fait des test  pour que quand on tire la balle soit dans la bonne direction si c est pas le cas on tourne le depart de tir jus qu a trouver le bonne angle ***/
        balleclone.transform.rotation = transform.rotation;
        yield return new WaitForSeconds(tempCadence);
////tir 2
        GameObject balleclone2 = Instantiate(balle, transform.position, Quaternion.identity) as GameObject;
        balleclone2.transform.rotation = transform.rotation;

        yield return new WaitForSeconds(tempCadence);
////tir 3
        GameObject balleclone3 = Instantiate(balle, transform.position, Quaternion.identity) as GameObject;
        balleclone3.transform.rotation = transform.rotation;
        yield return new WaitForSeconds(tempCadence);
////tir 4
        GameObject balleclone4 = Instantiate(balle, transform.position, Quaternion.identity) as GameObject;
        balleclone4.transform.rotation = transform.rotation;


        yield return new WaitForSeconds(tempCadence);
        ////permet a nouveau de tirez 
        stopCadence = false  ;



    }




}
