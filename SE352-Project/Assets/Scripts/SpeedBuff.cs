using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.transform.GetChild(2).gameObject.SetActive(true);
            collider.gameObject.GetComponent<PlayerMover>().SpeedBuffer(2f);
            Debug.Log("Speed Up");
            Destroy(this.gameObject);
        }
    }
}
