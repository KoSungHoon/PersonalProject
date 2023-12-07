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
    public List<Transform> enemyList = new List<Transform>();
    public List<IFindEnemy> obserbList = new List<IFindEnemy>();
    public Transform myTarget = null;
    public bool isObserb;
    // Start is called before the first frame update
    void Start()
    {
        Transform p = transform.parent;
        while (p != null)
        {
            IFindEnemy fe = p.GetComponent<IFindEnemy>();
            if (fe != null) obserbList.Add(fe);
            p = p.transform.parent;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((1 << collision.gameObject.layer & enemyMask) != 0)
        {
            if (!enemyList.Contains(collision.transform))
            {
                enemyList.Add(collision.transform);
            }
            if (myTarget == null)
            {
                myTarget = collision.transform;
                foreach (IFindEnemy fe in obserbList)
                {
                    fe.OnFindEnemy(myTarget);
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if ((1 << collision.gameObject.layer & enemyMask) != 0)
        {
            enemyList.Remove(collision.transform);
        }
        
    }
}
