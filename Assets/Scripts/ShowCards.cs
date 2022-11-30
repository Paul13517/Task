using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ShowCards : MonoBehaviour
{

    public GameObject cardBack;

    private bool coroutineAllowed, facedUp;


    void Start()
    {
        facedUp = false;
    }
    private void Update(){

       if(Input.GetMouseButtonDown(0)){
         OnMouseDown();
          }     
        }

    private void OnMouseDown()
    {
            StartCoroutine(RotateCards());
    }

    private IEnumerator RotateCards()
    {
      

        if (!facedUp)
        {
            for (float i = 0f; i <= 180f; i += 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    cardBack.SetActive(true);
                }
                yield return new WaitForSeconds(0.01f);
            }
        }


        else if (facedUp)
        {
            for (float i = 180f; i >= 0f; i -= 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    gameObject.SetActive(false);
                }
                yield return new WaitForSeconds(0.01f);
            }
        }
    }


}




  
    








        
    

