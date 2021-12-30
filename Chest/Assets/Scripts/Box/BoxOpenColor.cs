using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOpenColor : MonoBehaviour
{
    public Texture[] m_Text;
    public BoxEffect bx;    
    // Start is called before the first frame update
    void Start()
    {
        SkinnedMeshRenderer smR = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bx.level == 1){
            GetComponent<SkinnedMeshRenderer>().material.mainTexture = m_Text[0];
        }
        else if (bx.level == 2){
            GetComponent<SkinnedMeshRenderer>().material.mainTexture = m_Text[1]; 
        }
        else if (bx.level == 3){
            GetComponent<SkinnedMeshRenderer>().material.mainTexture = m_Text[2]; 
        }
        else if (bx.level == 4){
            GetComponent<SkinnedMeshRenderer>().material.mainTexture = m_Text[3]; 
        }
        else if (bx.level == 5){
            GetComponent<SkinnedMeshRenderer>().material.mainTexture = m_Text[4]; 
        }
    }
}
