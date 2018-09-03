using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class FoldTabView : ScrollRect
{
    [SerializeField]
    public GameObject FatherTabPrefab;

    [SerializeField]
    public GameObject ChildTabPrefab;

    protected override void Start()
    {
        base.Start();

        
    }

    private void CheckState()
    {

    }

    void Update()
    {

    }
}
