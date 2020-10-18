using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCoroutine : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canPlayerFire)
            {
                StartCoroutine(coRoutineTest());
            }
        }

    }

    bool canPlayerFire = true;
    IEnumerator coRoutineTest()
    {
        Debug.Log("Fire");

        canPlayerFire = false;

        yield return new WaitForSeconds(3);

        canPlayerFire = true;

    }
}
