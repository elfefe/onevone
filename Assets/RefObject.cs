using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefObject : MonoBehaviour
{



    public GameObject fusilAssaut ;
    public static GameObject fusilAssautM ;





    public GameObject fusilSniper;
    public static GameObject fusilSniperM;




    private void Awake()
    {
        fusilAssautM = fusilAssaut;
        fusilSniperM = fusilSniper;

    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
