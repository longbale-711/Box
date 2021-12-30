using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public BoxEffect bxl;
    public GameObject[] itemPref;
    public Transform itemPos;
    public GameObject _parent;
    
    void Start(){
        if (bxl.level == 1){
            //Classic
            GameObject _pa = Instantiate(itemPref[0],itemPos.transform.position,itemPos.transform.rotation);
            _pa.transform.SetParent (_parent.transform);
        }
        else if (bxl.level == 2){
            //Dirtbike
            GameObject _pa = Instantiate(itemPref[1],itemPos.transform.position,itemPos.transform.rotation);
            _pa.transform.SetParent (_parent.transform);
        }
        else if (bxl.level == 3){
            //Dreamer
            GameObject _pa = Instantiate(itemPref[2],itemPos.transform.position,itemPos.transform.rotation);
            _pa.transform.SetParent (_parent.transform);
        }
        else if (bxl.level == 4){
            //Scramble
            GameObject _pa = Instantiate(itemPref[3],itemPos.transform.position,itemPos.transform.rotation);
            _pa.transform.SetParent (_parent.transform);
        }
        else if (bxl.level == 5){
            //Sportbike
            GameObject _pa = Instantiate(itemPref[4],itemPos.transform.position,itemPos.transform.rotation);
            _pa.transform.SetParent (_parent.transform);
        }
    }
    
}
