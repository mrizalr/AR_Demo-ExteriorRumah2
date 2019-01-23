using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorType : MonoBehaviour {

    public Material[] materialsType1;
    public Material[] materialsType2;
    public Material[] materialsType3;
    public Material[] materialAtap;
    public Renderer[] atapRend;

    public Text title;
    Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.sharedMaterials = materialsType1;

        foreach (var atapMat in atapRend)
        {
            atapMat.sharedMaterial = materialAtap[0];
        }
        title.text = "Warna Rumah Tipe 1";
    }

    public void type1Color()
    {
        rend.sharedMaterials = materialsType1;
        foreach (var atapMat in atapRend)
        {
            atapMat.sharedMaterial = materialAtap[0];
        }
        title.text = "Warna Rumah Tipe 1";
    }

    public void type2Color()
    {
        rend.sharedMaterials = materialsType2;
        foreach (var atapMat in atapRend)
        {
            atapMat.sharedMaterial = materialAtap[1];
        }
        title.text = "Warna Rumah Tipe 2";
    }

    public void type3Color()
    {
        rend.sharedMaterials = materialsType3;
        foreach (var atapMat in atapRend)
        {
            atapMat.sharedMaterial = materialAtap[2];
        }
        title.text = "Warna Rumah Tipe 3";
    }
}
