using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnRate=3;
    private float timer=0;
    private float heightOffset=10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPillar();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate){
            timer+=Time.deltaTime;
        }
        else{
        spawnPillar() ; 
        timer=0;
        }
    }

    void spawnPillar(){
        float lowestPoint=transform.position.y-heightOffset;
        float highestPoint=transform.position.y+heightOffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),transform.position.z),transform.rotation);   
    }
}
