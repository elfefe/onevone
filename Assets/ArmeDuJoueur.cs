using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmeDuJoueur : MonoBehaviour
{

    int armeActuel = 2;  ///  1 == fusil assaut    /// 2 === sniper 

    Animator animator  ;



    public static bool rangeArme = false ;
    public float tempsDuRangementArme = 2f;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Don't do anything if it's not the current player
        //if (!IsLocalPlayer) return;

        /** si on range l arme c est que l on passe a l arme suivante **/
        if (RefManette.btnR2isPressed)
        {
            if(!rangeArme)
            {
                rangeArme = true ;


                animator.SetBool("rangeArme", true)   ;
                //lance l animation range l arme et affiche l arme suivante 
                StartCoroutine(rangeArmeCoroutine());
            }
            

        }


         //rotation 35    76   270



    }



    IEnumerator rangeArmeCoroutine()
    {
        yield return new WaitForSeconds(0.01F);
        animator.SetBool("rangeArme", false);


        if (armeActuel == 1)
        {
            ///faire une legere rotation de l arme fusil   
              RefObject.fusilAssautM.transform.localRotation = Quaternion.Euler(new Vector3(-215, -104, 42));
              yield return new WaitForSeconds(tempsDuRangementArme / 3);
              RefObject.fusilAssautM.transform.localRotation = Quaternion.Euler(new Vector3(-1.17F, -93.695F, 153.917F));
             
        }
        if (armeActuel == 2)
        {  
            ///faire une legere rotation de l arme sniper  
        RefObject.fusilSniperM.transform.localRotation = Quaternion.Euler(new Vector3(-215, -104, 42));
        yield return new WaitForSeconds(tempsDuRangementArme/3);
        RefObject.fusilSniperM.transform.localRotation  = Quaternion.Euler(new Vector3(-1.17F, -93.695F, 153.917F));

            

              


        }

        if(armeActuel<2)///si on est pas au max des arme possible on passe a la suivante 
        {
            armeActuel++;
        }else///sinon on reviens sur l arme 1  le fusil d assaut    0  n est pas attribuer a une arme peut etre on l utilisera pour le gun 
        {
            armeActuel = 1;

        }


        rendVisibleArmeVoulu(armeActuel) ;




        yield return new WaitForSeconds(tempsDuRangementArme);





        ////permet a nouveau de ranger l arme 
        rangeArme = false;



    }




    public void rendVisibleArmeVoulu(int armeActuel)
    {

        /** ferme toutes les armes **/
        RefObject.fusilSniperM.SetActive(false) ;
        RefObject.fusilAssautM.SetActive(false);


        /*** ouvre l arme voulu **/

        if(armeActuel == 1)///active le fusil assaut  
        {
            RefObject.fusilAssautM.SetActive(true);
            tirPlayerFusilAssaut.stopCadence = false;///enleve le stop cadence afin de reactivez la possibilitez de tir 
        }
        else //if (armeActuel == 2)  ///active le sniper 
        {
            RefObject.fusilSniperM.SetActive(true);
            tirPlayerFusilSniper.stopCadence = false;///enleve le stop cadence afin de reactivez la possibilitez de tir 

            

        }



    }





}
