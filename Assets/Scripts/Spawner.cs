using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public float queueTime = 1.2f;
    private float time = 0;
    public GameObject pipe;
    public float height;
    // Update is called once per frame
    void Update()
    {
        if(time > queueTime)
        {
            GameObject go = Instantiate(pipe);
            go.transform.position = transform.position + new Vector3(Random.Range(0.5f, 1.5f), Random.Range(-height, height), 0);
            Debug.Log(transform.position + " " + go.transform.position);
            time = 0;
            Destroy(go, 20);
        }
        time += Time.deltaTime;
    }
}