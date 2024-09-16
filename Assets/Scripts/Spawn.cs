using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    
    public List<EnemyMove> blocks = new List<EnemyMove>();
    public  int health = 4;
    public bool isgameOver;
    public static Spawn Instance;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        isgameOver = false;
        Instance = this;
        InvokeRepeating("SpawnBlock", 3.0f, 2.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
           
        if(isgameOver)
        {
            text.gameObject.SetActive(true);
        }
    }

    public void SpawnBlock()
    {
        //Vector3 position = new Vector3(1, 2.5f, 0);
        //Instantiate(blocks[Random.Range(0, 3)], position, Quaternion.identity);
        if (!isgameOver)
        {
            GameObject InstObj = Instantiate(blocks[Random.Range(0, 3)].gameObject);
            InstObj.transform.position = new Vector3(1, InstObj.GetComponent<EnemyMove>().YPos, 0);
        }
    }
}
