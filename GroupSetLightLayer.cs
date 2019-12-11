using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.HDPipeline;

[ExecuteInEditMode]
public class GroupSetLightLayer : MonoBehaviour
{
    public LightLayerEnum LightLayer;

    private MeshRenderer[] _meshRenderers;
    
    public void SetLightLayerToChildren()
    {
        _meshRenderers = GetComponentsInChildren<MeshRenderer>();

        foreach (MeshRenderer meshRenderer in _meshRenderers)
        {
            meshRenderer.renderingLayerMask = (uint)LightLayer;
        }
    }
    
}
