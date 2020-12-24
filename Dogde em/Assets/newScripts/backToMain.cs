
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMain : MonoBehaviour
{
    // Start is called before the first frame update
   public void back(){
       SceneManager.LoadScene("Main");
   }
}
