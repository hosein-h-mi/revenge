using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public LevelManeger levelManeger;
    // Start is called before the first frame update
    void Start()
    {
        levelManeger = FindObjectOfType<LevelManeger>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManeger.currentcheckPoint = gameObject;
        }
    }
}