using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LightSpawner : MonoBehaviour
{
    public GameObject MinionLight;
    public SettingOnOff Setting;
    public int Wait2Spawn;
    public bool Spawning;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Setting.issettingOn && !Spawning)
        {
            Wait2Spawn = Random.Range(1,5);
            StartCoroutine(SunLight(Wait2Spawn));
        }
    }
    IEnumerator SunLight(int TimetoWait)
    {
        Spawning = true;
        yield return new WaitForSeconds(TimetoWait);
        Instantiate(MinionLight,transform.position,transform.rotation);
        Spawning = false;
    }
}
