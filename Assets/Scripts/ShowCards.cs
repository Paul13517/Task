using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ShowCards : MonoBehaviour
{

// public Image[] loadImages = new Image[3];
// [SerializeField] private string url;

public GameObject cardBack;
public bool cardBackIsAktive;
private Tween tween;
public int timer;

    void Start()
    {
       
      tween = transform.DORotate(new Vector3(0,-90,0), 0.5f).OnComplete(() =>  cardBack.SetActive(true));   
      
      tween = transform.DORotate(new Vector3(0,-180,0), 1f);
    
    }
}

  
    








        
    

