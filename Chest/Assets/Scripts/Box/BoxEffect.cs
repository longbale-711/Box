using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEffect : MonoBehaviour
{
    [Header("Item and Level")]
    public GameObject Item;
    public int level;
    [Header("Effect 1")]
    public GameObject firePref; public Transform firePos;
    public GameObject splashPref; public Transform splashPos;
    public float waitOpen1;
    public float waitItem1;
    [Header("Effect 2")]
    public GameObject coinPref; public Transform coinPos;
    public GameObject smokePref; public Transform smokePos;
    public float waitOpen2;
    public float waitItem2;
    [Header("Camera")]
    public GameObject _camera;
    public float showItem;
    [Header("Animation")]
    public Animator _ani;

    //Start
    private void Start() {
        _ani = GetComponent<Animator>();
        _camera.GetComponent<Animator>().enabled = false;
    }

    //Level btn
    public void Level1(){
        level = 1;
    }
    public void Level2(){
        level = 2;
    }
    public void Level3(){
        level = 3;
    }
    public void Level4(){
        level = 4;
    }
    public void Level5(){
        level = 5;
    }

    //Open btn
    public void OpenBtn(){
        BoxLevel();
        //Animation Open
        _ani.SetBool("isOpen",true);
    }
    
    //Chest's level
    public void BoxLevel(){
        //Effect 1
        if (level == 1){
            Debug.Log("Level 1");
            //SpawnEffect
            StartCoroutine(Effect1());
           
        }
        //Effect 2
        else if (level == 2){
            Debug.Log("Level 2");
            StartCoroutine(Effect2());
            
        }
        else if (level == 3){
            Debug.Log("Level 3");
           StartCoroutine(Effect2());
        }
        else if (level == 4){
            Debug.Log("Level 4");
            StartCoroutine(Effect2());
        }
        else if (level == 5){
            Debug.Log("Level 5");
            StartCoroutine(Effect2());
        }
    }

    //Spawn Open Box effect
    IEnumerator Effect1(){
        //Spawn a fire round and flying seed
        Instantiate(firePref,firePos.position,firePos.rotation);
        yield return new WaitForSeconds(waitOpen1);
        Instantiate(splashPref,splashPos.position,splashPos.rotation);
        Invoke("SpawnItem",waitItem1);
    }
    IEnumerator Effect2(){
        //Spawn smoke and flying coin 
        Instantiate(smokePref,smokePos.position,smokePos.rotation);
        yield return new WaitForSeconds(waitOpen2);
        Instantiate(coinPref,coinPos.position,coinPos.rotation);
        Invoke("SpawnItem",waitItem2);
    }
    
    void SpawnItem(){
        Item.SetActive(true);
        Invoke("CameraAni",showItem);
    }
    void CameraAni(){
        _camera.GetComponent<Animator>().enabled = true;
    }
}
