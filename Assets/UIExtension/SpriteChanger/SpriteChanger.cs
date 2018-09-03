using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public List<Sprite> ImageList;      // 图片列表
    public bool AutoNativeSize;         // 是否自适应大小

    private Image _currentImage;        // 当前显示的Image
    public int Index{ set; get; }       // 当前索引

    void Awake()
    {
        _currentImage = GetComponent<Image>();
        ChangeToIndex(0);
    }

    /// <summary>
    /// 根据下标切换图片，下标从0开始
    /// </summary>
    public void ChangeToIndex(int idx)
    {
        Index = idx;
        _currentImage.sprite = ImageList[idx];
        if (AutoNativeSize)
        {
            _currentImage.SetNativeSize();
        }
    }

    /// <summary>
    /// 获取图片个数
    /// </summary>
    public int GetSpriteListLength()
    {
        return ImageList.Count;
    }
}
