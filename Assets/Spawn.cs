using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float maxTime;
    public float height;
    float timer;
    private void Update()
    {
        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(pipe, new Vector3(transform.position.x,transform.position.y+Random.Range(-height,height),0), Quaternion.identity);
            Destroy(tmp,10f);
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    
}
