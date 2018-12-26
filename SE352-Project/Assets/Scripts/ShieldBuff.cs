using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBuff : MonoBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.transform.GetChild(3).gameObject.SetActive(true);
            Debug.Log("Shield Up");
            Destroy(this.gameObject);
        }
    }
}
