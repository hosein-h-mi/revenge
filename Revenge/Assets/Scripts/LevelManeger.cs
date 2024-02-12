using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManeger : MonoBehaviour
{
    public GameObject currentcheckPoint;
    private MovePlayer Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<MovePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawonPlayer()
    {
        Player.transform.position = currentcheckPoint .transform.position;
    }
}
