using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.Netcode;
using Unity.Collections;
using Mirror;
//using Unity.Netcode.Components;

public class Deplacement : NetworkBehaviour
{

    // Player minimal movement speed
    public float vitesseBase = 20F;
    public float vitesseRoulade = 30F;
    private float vitesse = 0;

    // The distance where collision will be detected
    public float collisionDistance = 3f; ///valeur debut Default

    private Animator animator;

    // Transmit the player animations to all the players
    //private NetworkVariable<bool> playerMoving = new NetworkVariable<bool>(writePerm: NetworkVariableWritePermission.Owner);
    //private NetworkVariable<bool> playerRolling = new NetworkVariable<bool>(writePerm: NetworkVariableWritePermission.Owner);

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        // Don't do anything if it's not the current player
        if (!isLocalPlayer) return;

        // Attach the camera to the player
        Camera.main.GetComponent<PositionCamera>().SetPlayer(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        //Only do this ifit's the play doing it
        if (!isLocalPlayer) return;
            // Is the player moving ?
        var playerMoving = Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0;


        // Is the player rolling ?
        var playerRolling = RefManette.btnCarrezisPressed || Input.GetButtonDown("Jump");

        if (playerRolling || animator.GetCurrentAnimatorStateInfo(0).IsName("roulade"))
        {
            /** la vitesse double le temps de la roulade **/
            vitesse = vitesseRoulade * Time.deltaTime;
        }
        else
        {
            if (playerMoving)
            {
                // Calcul the player body angle depending on the input
                float bodyAngle = Mathf.Atan2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, bodyAngle, 0));
            }

            // vitess depend on if the player is moving, the current time step and the base speed
            vitesse = (playerMoving ? 1 : 0) * Time.deltaTime * vitesseBase;
        }

        // Move the player forward
        transform.position += AvailableDirection() * vitesse;


        anim("marche", playerMoving);
        anim("roulade", playerRolling);
    }

    [Command]
    private void anim(string name, bool status)
    {
        animator.SetBool(name, status);
    }

    // Return available directions depending on player direction
    private Vector3 AvailableDirection()
    {
        var direction = Vector3.zero;

        if (ToucheMur(DirectionalRay(transform.forward)))
        {
            if (ToucheMur(DirectionalRay(transform.right)))
            {
                direction = -transform.right;
            } else if (ToucheMur(DirectionalRay(-transform.right)))
            {
                direction = transform.right;
            }
        } else
        {
            direction = transform.forward;
        }


        return direction;
    }

    // Check if the player is touching the wall
    private bool ToucheMur(Ray ray)
    {
        int layer_Mur = LayerMask.GetMask("Mur");
        return Physics.Raycast(ray, collisionDistance, layer_Mur, QueryTriggerInteraction.UseGlobal);
    }

    // Create a ray from the player to the specified direction
    private Ray DirectionalRay(Vector3 direction)
    {
        return new Ray(transform.position, direction);
    }

}//fin de class 
