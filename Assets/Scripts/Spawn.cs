using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Spawn : MonoBehaviour
{
    
    public List<EnemyMove> blocks = new List<EnemyMove>();
    public  int health = 4;
    public bool isgameOver;
    public static Spawn Instance;
    public GameObject text;
    public GameObject strong;
    public GameObject average;
    public GameObject weak;
    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        isgameOver = false;
        Instance = this;
        InvokeRepeating("SpawnBlock", 3.0f, 2.0f);
        SetPlayerState();



    }
    void ResetAll()
    {
        weak.gameObject.SetActive(false);
        average.gameObject.SetActive(false);
        strong.gameObject.SetActive(false);
    }
    void SetPlayerState()
    {
        ResetAll();
        if (GameConstants.OopProjectEnums.PlayerStateCount == 0)
        {
            weak.gameObject.SetActive(true);
        }
        else if (GameConstants.OopProjectEnums.PlayerStateCount == 1)
        {
            average.gameObject.SetActive(true);
        }
        else if (GameConstants.OopProjectEnums.PlayerStateCount == 2)
        {
            strong.gameObject.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
       
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

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    private void GameOver()
    {
        if (isgameOver)
        {
            text.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }
    }
}
