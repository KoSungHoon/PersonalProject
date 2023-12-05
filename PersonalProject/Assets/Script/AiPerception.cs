using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFindEnemy
{
    void OnFindEnemy(Transform target);
}

public class AiPerception : MonoBehaviour
{
    public LayerMask enemyMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
