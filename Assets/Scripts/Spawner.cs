using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;
    public GameObject pipe;
    public float height;
    // Update is called once per frame
    void Update()
    {
        if(time > queueTime)
        {
            GameObject go = Instantiate(pipe);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            time = 0;
            Destroy(go, 10);
        }
        time += Time.deltaTime;
    }
}