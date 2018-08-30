using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public List<Sprite> ImageList;      // 图片列表
    public bool AutoNativeSize;         // 是否自适应大小

    private Image _currentImage;
    public int Index{ set; get; }

    void Start()
    {
        _currentImage = GetComponent<Image>();
//        _currentImage.sprite = ImageList[0];
        ChangeToIndex(0);
    }

    public void ChangeToIndex(int idx)
    {
        Index = idx;
        _currentImage.sprite = ImageList[idx];
        if (AutoNativeSize)
        {
            _currentImage.SetNativeSize();
        }
    }

    public int GetSpriteListLength()
    {
        return ImageList.Count;
    }
}
