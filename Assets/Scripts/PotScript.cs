using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    // ---------------------------
    // Variables
    // ---------------------------

    [Header("Pot Script")]
    [SerializeField] GameObject particle;
    [SerializeField] Transform particleStartPos;

    [Header("Components")]
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject audioSource;
    [SerializeField] Game game;

    // ---------------------------
    // Functions
    // ---------------------------

    void Start()
    {
        // Set Variables
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void AddPoint(GameObject droppedObject)
    {
        // Set Variables
        PotObject objectScript = droppedObject.GetComponent<PotObject>();
        game.scores += objectScript.pointsValue;

        // Call Functions
        gameManager.UpdateScore();

        Instantiate(particle, particleStartPos.position, particle.transform.rotation);
        audioSource.GetComponent<RandomAudio>().PlayRandomAudio();
        Destroy(droppedObject);
    }

    // ---------------------------
    // Collision
    // ---------------------------

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PotObject>() != null)
        {
            // Call Functions
            AddPoint(other.gameObject);
        }
    }
}
