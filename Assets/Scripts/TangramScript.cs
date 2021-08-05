using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangramScript : MonoBehaviour
{
    public bool Tap = false;
    private float t = 0;
    public float speed = 35f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.05f;
        t += Time.deltaTime;
        if (Tap)
        {
            gameObject.GetComponent<Rigidbody2D>().MoveRotation(-speed*t);
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.05f, 0), ForceMode2D.Impulse);
        }
        
    }
    public void Tapped()
    {
        if (!Tap)
        {
            t = 0;
            Tap = true;
        }

        else
        {
            Tap = false;
        }
    }
}
