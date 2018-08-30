using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChangerTest : MonoBehaviour
{
    public GameObject spriteChangerGO;

    private SpriteChanger spriteChanger;
    private float lastUpdateTime;
    private int index;
    void Start()
    {
        spriteChangerGO = Instantiate(spriteChangerGO);
        spriteChangerGO.transform.SetParent(transform, false);
        spriteChanger = spriteChangerGO.GetComponent<SpriteChanger>();
    }

    void Update()
    {
        if (Time.time - lastUpdateTime >= 1f)
        {
            index++;
            spriteChanger.ChangeToIndex(index % spriteChanger.GetSpriteListLength());
            Debug.Log("CurrentIndex: " + spriteChanger.Index);
            lastUpdateTime = Time.time;
        }
    }
}
