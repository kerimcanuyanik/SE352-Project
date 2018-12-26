using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" || collision.gameObject.tag != "Shield" || collision.gameObject.tag != "Speed")
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "ActiveShield")
        {
            Destroy(collision.gameObject.transform.GetChild(3).gameObject);
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "ActiveSpeed")
        {
            collision.gameObject.GetComponent<PlayerMover>().SpeedBuffer(0.5f);
            Destroy(collision.gameObject.transform.GetChild(2).gameObject);
            Destroy(this.gameObject);
        }
    }

    private void DestroyBuff(GameObject buff)
    {
        Destroy(buff);
    }
}
