using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelButton : MonoBehaviour
{
  public TextMeshProUGUI levelText;
  public int level;
  public string levelToLoad;
  // Start is called before the first frame update
  void Start()
  {
    Setup(level);
  }

  void Setup(int level)
  {
    levelText.text = "" + level;
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void Play()
  {
    PlayerPrefs.SetInt("Current Level", level - 1);
    SceneManager.LoadScene(levelToLoad);
  }
}
