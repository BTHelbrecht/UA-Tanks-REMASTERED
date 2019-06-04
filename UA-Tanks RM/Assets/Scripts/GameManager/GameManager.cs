using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // singleton
    public static GameManager instance;

    // arrays


    // accesser
    public GameObject g_tankPrefab;
    public List<UserInput> g_playerNumber;
    public List<AIController> g_enemy;


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

    private void Start()
    {
        GameObject newTank = Instantiate(g_tankPrefab) as GameObject;
        TankData newData = newTank.GetComponent<TankData>();
        g_playerNumber[0].u_tankData = newData;

        newTank = Instantiate(g_tankPrefab) as GameObject;
        newData = newTank.GetComponent<TankData>();
        g_enemy[0].a_tankData = newData;
    }
}//E
