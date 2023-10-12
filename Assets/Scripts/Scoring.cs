using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Chicken attack");
            GameManager.gm.IncreaseScore();
        }
    }
}
