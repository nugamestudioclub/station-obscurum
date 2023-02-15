using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DGemItem : MonoBehaviour
{
    [SerializeField]
    private float decSpeed = 5f;



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerMovementController>().SetSpeed(decSpeed);
            Destroy(this.gameObject);

        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
