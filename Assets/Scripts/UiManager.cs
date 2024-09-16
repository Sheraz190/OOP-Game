using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChosePlayer()
    {
        SceneManager.LoadScene(1);
    }

    public void StrongPlayer()
    {
        //Spawn.Instance.strong.gameObject.SetActive(true);
        GameConstants.OopProjectEnums.PlayerStateCount = 2;
    }

    public void AveragePlayer()
    {
        //Spawn.Instance.average.gameObject.SetActive(true);
        GameConstants.OopProjectEnums.PlayerStateCount = 1;
    }

    public void weakPlayer()
    {
        //Spawn.Instance.weak.gameObject.SetActive(true);
        GameConstants.OopProjectEnums.PlayerStateCount = 0;
    }
}
