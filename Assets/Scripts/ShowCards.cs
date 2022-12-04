using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ShowCards : MonoBehaviour
{

    public GameObject[] cardsBack;

    public GameObject[] cards;

    public LoadImage lI;
    


    void Start()
    {
       OneByOne();    
       
    }
    
    public void OneByOne(){
         
        lI.StartLoading();
        StartCoroutine(Sequence());
        
         
    }
    private IEnumerator Sequence()
    {    
        
      
        for(int i = 0; i < cardsBack.Length; i++){
        
        for (float j = 0f; j <= 180f; j += 10f)
            {
                cards[i].transform.rotation = Quaternion.Euler(0f, j, 0f);
                
                
                if (j == 90f)
                {
                    
                    cardsBack[i].SetActive(true);
                    
                }
                
                yield return new WaitForSeconds(0.01f);
                
            }
   
       }
       
   }
   




}






  
    








        
    

