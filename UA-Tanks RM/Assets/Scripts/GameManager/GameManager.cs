using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // singleton
    public static GameManager instance;

    // arrays


    // accesser
    public GameObject g_TankPrefab;
    public GameObject g_WayPointPrefab;
    public List<UserInput> g_PlayerNumber;
    public List<EnemyInput> g_Enemy;
    public List<Transform> g_WayPoint;


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
        GameObject newWayPoint = Instantiate(g_WayPointPrefab) as GameObject;
        Transform newPoint = newWayPoint.GetComponent<Transform>();
        g_WayPoint[0] = newPoint;

        GameObject newTank = Instantiate(g_TankPrefab) as GameObject;
        TankData newData = newTank.GetComponent<TankData>();
        g_PlayerNumber[0].u_tankData = newData;

        newTank = Instantiate(g_TankPrefab) as GameObject;
        newData = newTank.GetComponent<TankData>();
        g_Enemy[0].e_tankData = newData;
    }
}//E
