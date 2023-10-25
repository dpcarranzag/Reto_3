using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Fruits : MonoBehaviour
{
    public Score score;
    public GameObject cereza;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (score.score == 1500)
        {
            Instantiate(cereza, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
}
