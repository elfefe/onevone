using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.Netcode;

public class PositionCamera : MonoBehaviour
{ 

    // public Transform target;
    public float smoothTime = 1F;
    private Vector3 velocity = Vector3.zero;



    //  public Transform Target;

    public float AxeY;

    public float AxeX;




    public GameObject player;       // Variable publique pour stocker la r�f�rence vers l'objet du joueur

   /// Deplacement scriptDeplacement;

    private Vector3 offset;         // Variable priv�e pour stocker le d�calage entre le joueur et la cam�ra



    // Set the player this camera should be attached to
    public void SetPlayer(GameObject player)
    {
        this.player = player;

        // Calcul et stocke le d�calage entre le joueur et la cam�ra
        offset = transform.position - player.transform.position;

    }




    // La fonction LateUpdate() est appel�e apr�s la fonction Update() � chaque image
    // void FixedUpdate()
    void Update()
    {
        // Exit if player not yet attached
        if (!player) return;
        
        
        // D�finit la position de la cam�ra avec celle du joueur tout en ajoutant un d�calage.

        /*
           if (player.transform.position.y < 1.2f)
          {
              transform.position = player.transform.position + offset;

              transform.position = new Vector3(player.transform.position.x, AxeY, -10);


          }*/


        float positionX;
            float positionY;

             positionX = player.transform.position.x   ;
             positionY = player.transform.position.z   ;
            // positionY = 10 ;


             Vector3 targetPosition = new Vector3(positionX, 50, positionY);


            // Smoothly move the camera towards that target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);


       


        /*

               if (player.transform.position.y < 1.2f)
               {
                   float positionX;

                   // transform.position = new Vector3(player.transform.position.x, player.transform.position.y +1, -10);
                   if (scriptDeplacement.regardTournezadroite)
                   {
                       positionX = player.transform.position.x + 3;
                   }
                   else
                   {
                       positionX = player.transform.position.x - 3;

                   }
                   Vector3 targetPosition = new Vector3(positionX, AxeY, -10);


                   // Smoothly move the camera towards that target position
                   transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);


               }



               if (player.transform.position.y >= 1.2f)
               {
                   // transform.position = new Vector3(player.transform.position.x, player.transform.position.y +1, -10);
                   float positionX  = player.transform.position.x;

                   // transform.position = new Vector3(player.transform.position.x, player.transform.position.y +1, -10);
                   /*     if (scriptDeplacement.regardTournezadroite)
                        {
                            positionX = player.transform.position.x + 3;
                        }
                        else
                        {
                            positionX = player.transform.position.x - 3;

                        }

                   Vector3 targetPosition = new Vector3(positionX, player.transform.position.y + 2, -10);

                   // Smoothly move the camera towards that target position
                   transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);


               }

           */

        /* if (transform.position.y == player.transform.position.y)
             {
                 transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, -10);
             }*/
    }



}