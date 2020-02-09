using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTransparent : MonoBehaviour
{
    private Material[] oldMaterials = null;

    private float m_Transparency = 1.0f;
    public float TargetTransparency { get; set; }

    public float FadeInTimeout { get; set; }

    public float FadeOutTimeout { get; set; }

    public Material TransparentMaterial { get; set; }

    private bool shouldBeTransparent = true;

    public void BeTransparent()
    {

        shouldBeTransparent = true;
    }

    private void Start()
    {
        // reset the transparency;
        m_Transparency = 1.0f;

        if (oldMaterials == null)
        {
            // Save the current materials
            oldMaterials = GetComponent<Renderer>().materials;

            Material[] materialsList = new Material[oldMaterials.Length];

            for (int i = 0; i < materialsList.Length; i++)
            {
                // repalce material with transparent
               materialsList[i] = Object.Instantiate(TransparentMaterial);
                materialsList[i].SetColor("_EmissionColor", oldMaterials[i].GetColor("_EmissionColor"));
                //materialsList[i].SetTextureOffset ("_BumpMap", oldMaterials[i].GetTextureOffset("_BumpMap"));
            }

            // make transparent
            
            GetComponent<Renderer>().materials = materialsList;
        }
    }

    // Update is called once per frame
    private void Update()
    {
       

        
        if (!shouldBeTransparent && m_Transparency >= 1.0)
        {
            Destroy(this);
        }

        //Are we fading in our out?
        
        if (shouldBeTransparent)
        {
            //Fading out
            if (m_Transparency > TargetTransparency)
            {
                m_Transparency -= ((1.0f - TargetTransparency) * Time.deltaTime) / FadeOutTimeout;
            }
        }
        else
        {
            //Fading in
            m_Transparency += ((1.0f - TargetTransparency) * Time.deltaTime) / FadeInTimeout;
        }
        //TransparentMaterial.SetFloat("Vector1_510072BE", m_Transparency);
        Material[] materialsList = GetComponent<Renderer>().materials;
        for (int i = 0; i < materialsList.Length; i++)
        {
            Color C = oldMaterials[i].GetColor("_EmissionColor");
            //Vector3 N = oldMaterials[i].GetTextureOffset("_BumpMap");
            C.a = m_Transparency;
            //TransparentMaterial.SetFloat("Vector1_510072BE", m_Transparency);
            materialsList[i].SetColor("_EmissionColor",C);
            //materialsList[i].mainTextureOffset = N;
        }

        //The object will start to become visible again if BeTransparent() is not called
        shouldBeTransparent = false;
        
    }

    private void OnDestroy()
    {
        // restore old materials
        GetComponent<Renderer>().materials = oldMaterials;
    }

}
