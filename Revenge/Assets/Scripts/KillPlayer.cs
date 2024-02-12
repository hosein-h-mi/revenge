using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public LevelManeger levelmaneger;
    // Start is called before the first frame update
    void Start()
    {
        levelmaneger =FindObjectOfType<LevelManeger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other .name=="Player")
        {
            levelmaneger.RespawonPlayer();
        }
    }
}
