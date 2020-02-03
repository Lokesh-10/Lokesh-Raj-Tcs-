using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{

    public GameObject theEnemy;
    public int xpos;
    public int zpos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

 IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xpos = Random.Range(1, 360);
            zpos = Random.Range(1, 360);
            Instantiate(theEnemy, new Vector3(xpos, 50, zpos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 2;
        }
    }
}
