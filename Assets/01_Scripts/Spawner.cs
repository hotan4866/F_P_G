using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static List<Monster> m_Monsters = new List<Monster>();

    public bool isReSpawner;
    int maxCount = 3;
    int currentCount = 0;

    private void Update()
    {
        
    }


}
