using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public int poolSize = 10;

    private List<GameObject> pool;
    
    // Start is called before the first frame update
    void Start()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetObject()
    {
        foreach (var obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }
        
        GameObject newobj = Instantiate(prefab);
        pool.Add(newobj);
        return newobj;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
    }
}
