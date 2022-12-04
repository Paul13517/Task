using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsManager : MonoBehaviour
{
    public GameObject[] cards;
    public GameObject[] cardsBack;


       void Start()
    {
       OneByOne();   
    }
    
  public void OneByOne(){
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
