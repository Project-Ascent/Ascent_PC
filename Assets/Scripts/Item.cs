using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public static Item item;
    public bool beans=false;
    public bool airballon=false;
    public bool goose=false;
    

    private void Awake()
    {
        if (item != null)
        {
            Destroy(gameObject);
            return;
        }
        item = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
