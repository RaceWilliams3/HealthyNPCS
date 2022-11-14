using UnityEngine;

public class NPC : MonoBehaviour
{
    internal void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }

   void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            TakeDamage(10);
        }
    }
}