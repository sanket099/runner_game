
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button button;
    public newScore ns;
    public player_move pm;
    public Button btn;

    bool gameEnd = false;

    public void EndGame(){
        if(gameEnd == false){
            gameEnd = true;
           // Invoke("Restart",2f);
            Restart();
        }

    }
    void Restart(){ 
        button.gameObject.SetActive(true);
        pm.enabled = false;
        ns.enabled = false;
       // btn.gameObject.SetActive(true);
    }
}
