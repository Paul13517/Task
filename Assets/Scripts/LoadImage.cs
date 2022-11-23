using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LoadImage : MonoBehaviour
{
   [SerializeField] private string url;
    private Image img;

    void Start()
    {
        img = GetComponent<Image>();
        StartCoroutine (GetImage());
    }

  
    private IEnumerator GetImage()
    {
        UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture(url);
        
        yield return webRequest.SendWebRequest();

        if(webRequest.isDone == false){
            Debug.Log(webRequest.error);
        }
        else{
            Texture texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;

            img.sprite = Sprite.Create((Texture2D)texture, new Rect (0,0,texture.width, texture.height), Vector2. zero);


        }



    }
}
