using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public GameObject gameOverScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen = FindInactiveObjectWithTag("gameOver");
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOverScreen.activeInHierarchy)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
    
    GameObject FindInactiveObjectWithTag(string tag)
    {
        foreach (GameObject obj in Resources.FindObjectsOfTypeAll<GameObject>()) 
        {
            if (obj.tag == tag && !obj.scene.name.Equals(null))
            {
                return obj;
            }
        }
        return null;
    }
}
