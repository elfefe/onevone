using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopCollider : MonoBehaviour
{






    public Transform DepartDuRayonHit;

    Vector3 TourneRayon = Vector3.zero;


    Vector3 directionRayon = Vector3.forward ;
    /*** on cree un 2 eme rayon qui nous permet de ne pas stopper le deplacement vers le haut en cas ou on fait un haut droite et que la position est bloquez juste avec le mur de droite **/
    Vector3 directionRayon2 = Vector3.forward;

    float longueurDuRayon =   2f ;


    /** donne l information au script de deplacement pour savoir si notre joueur touche le mur ou si il peut avancer **/
    public static bool toucheMur = false;


    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {




        ///droite
        if (Input.GetAxisRaw("Horizontal") > 0)
        {

             directionRayon = Vector3.right;

        }

        ///gauche
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
             directionRayon = Vector3.left;
        }

        //haut
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            directionRayon = Vector3.forward;
        }



        //bas
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            directionRayon = Vector3.back;
        }


        ///droite haut
        if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") > 0)
        {
            directionRayon = Vector3.right + Vector3.forward;

            /** 2 eme rayon on verifie si ya un mur en haut si c est pas le cas on debbloquera le mouvement haut mais on bloquera celui de droite **/
            directionRayon2 = Vector3.forward;

        }


        ///gauche haut
        if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") > 0)
        {
            directionRayon = Vector3.left + Vector3.forward;


            /** 2 eme rayon on verifie si ya un mur en haut si c est pas le cas on debbloquera le mouvement haut mais on bloquera celui de gauche **/
            directionRayon2 = Vector3.forward;
        }





        ///droite bas
        if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") < 0)
        {
            directionRayon = Vector3.right + Vector3.back;

            /** 2 eme rayon on verifie si ya un mur en bas si c est pas le cas on debbloquera le mouvement bas mais on bloquera celui de droite **/
            directionRayon2 = Vector3.back;
        }


        ///gauche bas
        if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") < 0)
        {
            directionRayon = Vector3.left + Vector3.back;

            /** 2 eme rayon on verifie si ya un mur en bas si c est pas le cas on debbloquera le mouvement bas mais on bloquera celui de gauche **/
            directionRayon2 = Vector3.back;
        }






         








        /** affiche le rayon  dans la scene   pas en game **/
        Debug.DrawRay(DepartDuRayonHit.transform.position, directionRayon * longueurDuRayon );

        /** permet de voir le 2 eme rayon**/
        Debug.DrawRay(DepartDuRayonHit.transform.position, directionRayon2 * longueurDuRayon * 100 );

         


        RaycastHit hit;

        Ray ray = new Ray(DepartDuRayonHit.transform.position, directionRayon * longueurDuRayon); 
        Ray ray2 = new Ray(DepartDuRayonHit.transform.position, directionRayon2 * longueurDuRayon);



        int layer_Mur = LayerMask.GetMask("Mur");  ///valeur debut Default


        //si on touche le sol le saut est possible 
        if (Physics.Raycast(ray, out hit, longueurDuRayon, layer_Mur, QueryTriggerInteraction.UseGlobal))
        {

            Debug.Log("mur touché");
            toucheMur = true ;

        }else
        {
            toucheMur = false;

        }


    }



     
   







}
