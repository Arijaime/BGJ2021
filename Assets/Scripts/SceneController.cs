using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
  public GameObject pBTN;


  public void sceneTittleChanger()
  {
      SceneManager.LoadScene("MainTittleScene");

  }
  
  public void sceneGameChanger()
  {
      SceneManager.LoadScene("GameScene");

  }
  
  public void sceneOptionChanger()
  {
      SceneManager.LoadScene("OptionsScene");

  }
  
  public void sceneGalleryChanger()
  {
      SceneManager.LoadScene("GalleryScene");

  }

  public void quitGame()
  {
      Application.Quit();
  }




}

