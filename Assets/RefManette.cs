using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class RefManette : MonoBehaviour
{













    ///MANETTE PS4 ET X BOX 

    /////btn 
    public bool btnCircleisPressed = false;  


    //croix
    public bool btnCroixisPressed = false;
    //is pressed up croix 
    public bool btnCroixisPressedUp = false;
    private bool appuisFaisSurCroix;
    private bool uneFoisPourCroix;
    ///*******************************************/



    bool btnTriangleisPressed = false;
    /** utilisez pour la roulade **/
    public static bool btnCarrezisPressed = false;

    public bool btnL1isPressed = false; 

    /** utilisez pour le tir **/
    public static bool btnR1isPressed = false;




    public bool btnL2isPressed = false;
    private bool uneFoisPourL2;
    public bool btnL2isPressedUp;
    private bool appuisFaisSurL2;    




   
    public static bool btnR2isPressed = false; 


    private bool uneFoisPourR2;
    private bool appuisFaisSurR2;
    public bool btnR2isPressedUp;
    ///////////////



    //a faire dans le script la function manette car il sont pas initialisez 
    bool btnStickGaucheisPressed = false;
    bool btnStickDroitisPressed = false;


    ///axe stick droit
    public bool btnStickDroitAxezDroiteisPressed = false; 
    public bool btnStickDroitAxezGaucheisPressed = false; 
    public bool btnStickDroitAxezHautisPressed = false; 
    public bool btnStickDroitAxezBasisPressed = false; 

    ///axe stick Gauche
    public bool btnStickGaucheAxezDroiteisPressed = false;
    public bool btnStickGaucheAxezGaucheisPressed = false;
    bool btnStickGaucheAxezHautisPressed = false;
    bool btnStickGaucheAxezBasisPressed = false;












    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManettePs4XboxEtatDesBtnEtAxe();
    }













    public void ManettePs4XboxEtatDesBtnEtAxe()
    {

        if (Gamepad.all.Count > 0)
        {


            //  4 button sur la face de la manette


            ///
            //  Le bouton triangle 
            if (Gamepad.current.triangleButton.isPressed)
            {
                btnTriangleisPressed = true;
            }
            else
            {
                btnTriangleisPressed = false;
            }


            ///
            ///  Le bouton croix
            if (Gamepad.current.crossButton.isPressed)
            {
                btnCroixisPressed = true;



                //pour croix isPressedUp
                uneFoisPourCroix = true;
            }
            else
            {
                btnCroixisPressed = false;

                //pour Croix isPressedUp
                /*************************************************************************************************************/
                if (appuisFaisSurCroix)
                {  ///mise a false pour 1 fois 
                    appuisFaisSurCroix = false;
                    uneFoisPourCroix = false;


                    btnCroixisPressedUp = true;
                    Debug.Log(btnCroixisPressedUp + " croix is pressed up");

                    ////c est le script qui se sert du bouton qui remet sa valeur  btnCroixisPressedUp = false;
                    ///  afin d avoir le temps de lire que le btn a etait relevez dans script sauteRoody

                }
                /*************************************************************************************************************/

            }

            //pour Croix isPressedUp
            /*************************************************************************************************************/
            if (uneFoisPourCroix)
            {
                uneFoisPourCroix = false;

                appuisFaisSurCroix = true;
            }
            /*************************************************************************************************************/









            ///
            ///Le bouton carre
            if (Gamepad.current.squareButton.isPressed)
            {
                btnCarrezisPressed = true;
            }
            else
            {
                btnCarrezisPressed = false;
            }

            ///
            ///Le bouton rond 
            if (Gamepad.current.circleButton.isPressed)
            {
                btnCircleisPressed = true;

            }
            else
            {

                btnCircleisPressed = false;

            }


            ///////////////////////////////////////////


            ///  4 button superieur de la manette

            //  Le bouton de l'épaule gauche.   L1
            if (Gamepad.current.leftShoulder.isPressed)
            {
                btnL1isPressed = true;
            }
            else
            {
                btnL1isPressed = false;
            }

            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/

            ////Special sur L2 on a fais comme un ecouteur manuelle pour savoir quand btnL2isPressedUp

            //Le bouton de déclenchement gauche.  L2
            if (Gamepad.current.leftTrigger.isPressed)
            {
                btnL2isPressed = true;



                //pour L2 isPressedUp
                uneFoisPourL2 = true;
            }
            else
            {
                btnL2isPressed = false;




                //pour L2 isPressedUp
                /*************************************************************************************************************/
                if (appuisFaisSurL2)
                {  ///mise a false pour 1 fois 
                    appuisFaisSurL2 = false;
                    uneFoisPourL2 = false;


                    btnL2isPressedUp = true;
                    //Debug.Log(btnL2isPressedUp);

                    ////c est le script qui se sert du bouton qui remet sa valeur  btnL2isPressedUp = false afin d avoir le temps de lire que le btn a etait relevez   dans script RoodyViseurGobezArraignez

                }
                /*************************************************************************************************************/


            }

            ////ici specialement on doit savoir si le btn L2 est relachez    
            //pour L2 isPressedUp
            /*************************************************************************************************************/
            if (uneFoisPourL2)
            {
                uneFoisPourL2 = false;

                appuisFaisSurL2 = true;
            }
            /*************************************************************************************************************/





            //  Le bouton de l'épaule droite.  R1
            if (Gamepad.current.rightShoulder.isPressed)
            {
                btnR1isPressed = true;
            }
            else
            {
                btnR1isPressed = false;
            }



            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/

            ////Special sur r2 on a fais comme un ecouteur manuelle pour savoir quand btnR2isPressedUp

            ///Le bouton de déclenchement droit.  R2
            if (Gamepad.current.rightTrigger.isPressed)
            {
                btnR2isPressed = true;



                //pour r2 isPressedUp
                uneFoisPourR2 = true;
            }
            else
            {
                btnR2isPressed = false;




                //pour r2 isPressedUp
                /*************************************************************************************************************/
                if (appuisFaisSurR2)
                {  ///mise a false pour 1 fois 
                    appuisFaisSurR2 = false;
                    uneFoisPourR2 = false;


                    btnR2isPressedUp = true;
                    //    Debug.Log("btnR2isPressedUp");

                    ////c est le script qui se sert du bouton qui remet sa valeur  btnR2isPressedUp = false afin d avoir le temps de lire que le btn a etait relevez dans script RoodyViseurGobezArraignez

                }
                /*************************************************************************************************************/


            }

            ////ici specialement on doit savoir si le btn r2 est relachez    
            //pour r2 isPressedUp
            /*************************************************************************************************************/
            if (uneFoisPourR2)
            {
                uneFoisPourR2 = false;

                appuisFaisSurR2 = true;
            }
            /*************************************************************************************************************/






            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/
            /*******************************************************************************************************************************************************************************************************************/




            ///2 JOYSTICK CONTROLE

            ///joystique gauche


            ///joystique gauche a gauche 

            if (Gamepad.current.leftStick.left.isPressed)
            {
                btnStickGaucheAxezGaucheisPressed = true;
            }
            else
            {
                btnStickGaucheAxezGaucheisPressed = false;
            }


            ///joystique gauche a droite 

            if (Gamepad.current.leftStick.right.isPressed)
            {
                btnStickGaucheAxezDroiteisPressed = true;
            }
            else
            {
                btnStickGaucheAxezDroiteisPressed = false;
            }


            ///joystique gauche en haut

            if (Gamepad.current.leftStick.up.isPressed)
            {
                btnStickGaucheAxezHautisPressed = true;
            }
            else
            {
                btnStickGaucheAxezHautisPressed = false;
            }


            ///joystique gauche en bas

            if (Gamepad.current.leftStick.down.isPressed)
            {
                btnStickGaucheAxezBasisPressed = true;
            }
            else
            {
                btnStickGaucheAxezBasisPressed = false;
            }








            /*************************************************************************************************************/



            ///joystique droite 



            ///joystique droite a gauche  

            if (Gamepad.current.rightStick.left.isPressed)
            {
                btnStickDroitAxezGaucheisPressed = true;
            }
            else
            {
                btnStickDroitAxezGaucheisPressed = false;
            }


            ///joystique droite a droite 

            if (Gamepad.current.rightStick.right.isPressed)
            {
                btnStickDroitAxezDroiteisPressed = true;
            }
            else
            {
                btnStickDroitAxezDroiteisPressed = false;
            }


            ///joystique droite en haut

            if (Gamepad.current.rightStick.up.isPressed)
            {
                btnStickDroitAxezHautisPressed = true;
            }
            else
            {
                btnStickDroitAxezHautisPressed = false;
            }


            ///joystique droite en bas

            if (Gamepad.current.rightStick.down.isPressed)
            {
                btnStickDroitAxezBasisPressed = true;
            }
            else
            {
                btnStickDroitAxezBasisPressed = false;
            }








            ///voir btn select  et start 


        }//fin de if (Gamepad.all.Count > 0)


    }//fin de public void ManettePs4XboxEtatDesBtnEtAxe()


}
