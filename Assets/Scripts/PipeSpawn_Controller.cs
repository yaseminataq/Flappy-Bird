using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn_Controller : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minY;
    public float maxY;
    public float x;
    public float interval;
    private void OnEnable()
    {
        InvokeRepeating(nameof(PipeSpawn), interval, interval);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(PipeSpawn));
    }

    private void PipeSpawn()
    {
        GameObject instance = Instantiate(pipePrefab);
        instance.transform.position = new Vector2(x, Random.Range(minY, maxY));
    }
}