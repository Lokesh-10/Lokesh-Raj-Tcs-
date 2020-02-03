using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorekeeperui : MonoBehaviour
{

    public Text aliveText;

    void Update()
    {
        aliveText.text = scorekeeper.Instance.Alive.ToString();

    }

}
