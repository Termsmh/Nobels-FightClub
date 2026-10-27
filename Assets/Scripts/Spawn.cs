using UnityEngine;
using UnityEngine.InputSystem;

public class Spawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();

        if (playerInput != null)
        {
            GameObject spawn1 = GameObject.Find("spawn1");
            GameObject spawn2 = GameObject.Find("spawn2");

            if (playerInput.playerIndex == 0 && spawn1 != null)
            {
                transform.position = spawn1.transform.position;
                
            }

            if (playerInput.playerIndex == 1 && spawn2 != null)
            {
                
                if (spawn2 != null)
                {
                    transform.position = spawn2.transform.position;
                }
            }
        }
    }

   
}
