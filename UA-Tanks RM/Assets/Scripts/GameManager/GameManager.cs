using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // singleton
    public static GameManager instance;

    // arrays
    

    // accesser
    public TankData tankData;
    public UserInput userInput;
    public MoveDrive moveDrive;


    // AWAKE >>> dedicated to singletion instance
    private void Awake()
    {
        // if there is no instance currently
        if(instance == null)
        {
            // instance equals this gameobject
            // do not destroy this gameobject on load
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        // otherwise
        else
        {
            // destry this gameobject
            Destroy(gameObject);
        }//E
    }//E
}//E
