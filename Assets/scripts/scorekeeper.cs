using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scorekeeper : MonoBehaviour
{

    public int Alive;
    public static scorekeeper Instance;
    // Use this for initialization
    void Start()
    {
        Instance = this;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LessAlive(int Less)
    {
        Alive += Less;
        //print(Alive);
    }
    private void ResetAlive()
    {
        Alive =0;
        // print(Alive);
        if (Alive == 0)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }

}
