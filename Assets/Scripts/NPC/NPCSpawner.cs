using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] private float Intervalo = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(Intervalo, target));
    }

    private IEnumerator spawnEnemy(float interval, Transform npc)
    {
        yield return new WaitForSeconds(interval);
        Transform newNpc = Instantiate(npc, new Vector3(Random.Range(2, 11), Random.Range(4, -4), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, npc));
    }
}
