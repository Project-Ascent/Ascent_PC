using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToLobby : MonoBehaviour
{

    public void SceneChange()
    {
        SceneManager.LoadScene("LobbyScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        print(Item.item.beans);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
