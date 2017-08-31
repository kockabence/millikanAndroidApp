using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour {



    [SerializeField]
    private float _speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (transform.position.x < -4)
        {
            float randomYPosition = UnityEngine.Random.Range(-5, 5);
            transform.position = new Vector3(4, randomYPosition, 0);
        }
    }
}
