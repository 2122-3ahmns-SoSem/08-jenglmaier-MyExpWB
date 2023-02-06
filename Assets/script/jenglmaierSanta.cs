using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class jenglmaierSanta : MonoBehaviour
{
    public GameObject[] giftprefab;
    public GameObject spawnPos;
    public Vector3 giftForce;
    public Transform spawnPostransform;
    public float targetTime = 1;

    private void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0f)
        {
            GameObject clone = Instantiate(giftprefab[Random.Range(0, 4)]);
            clone.transform.position = spawnPostransform.position;
            //float scalefactor = Random.Range(1f, 3f);
            //clone.transform.localScale = new Vector3(1, 1, 1);
            Rigidbody rbClone = clone.GetComponent<Rigidbody>();
            rbClone.AddForce(giftForce);
            //float x = Random.Range(1, 3);
            //clone.transform.localScale = new Vector3(x, x, x);
            targetTime = 5;
        }
    }



    private void Start()
    {
        spawnPostransform = spawnPos.transform;
    }

    
}
