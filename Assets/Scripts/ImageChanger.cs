using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageChanger : MonoBehaviour
{

    public Image[] image;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

    private int a = 0;
    private int[] arr = new int[4];
    private int b = 0;
    private bool check;
    
    void Start()
    {
        ImageChange();
    }
    

    void GG() {
        
        if (arr[b] == 0) {
            if (Input.GetKeyDown(KeyCode.UpArrow) == true) {
                playSound("drumhitnormal");
                image[b].sprite = sprite5;
                b++;
            }
        } else if (arr[b] == 1) {
            if (Input.GetKeyDown(KeyCode.DownArrow) == true) {
                playSound("drumhitnormal");
                image[b].sprite = sprite5;
                b++;
            }
        } else if (arr[b] == 2) {
            if (Input.GetKeyDown(KeyCode.RightArrow) == true) {
                playSound("drumhitnormal");
                image[b].sprite = sprite5;
                b++;
            }
        } else if (arr[b] == 3) {
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true) {
                playSound("drumhitnormal");
                image[b].sprite = sprite5;
                b++;
            }
        }

        
    }

    void playSound(string snd){
        GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        if (b >= 4) {
            StartCoroutine(WaitForIt());
                if (check == true) {
                    playSound("drumhitclap");
                    b = 0;
                    ImageChange();
                    GG();
                    
                }
        } else {
            GG();
            check = false;
        }

        
        
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(0.5f);
        check = true;
    }

    void ImageChange() {
        for (int i = 0; i < 4; i++) {
            a = Random.Range(0, 4);
            if (a == 0) {
                image[i].sprite = sprite1;
                arr[i] = 0;
            } else if (a == 1) {
                image[i].sprite = sprite2;
                arr[i] = 1;
            } else if (a == 2) {
                image[i].sprite = sprite3;
                arr[i] = 2;
            } else {
                image[i].sprite = sprite4;
                arr[i] = 3;
            }
        }
    }
    
}
