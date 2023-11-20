using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThrough : MonoBehaviour, ISelectionResponse
{
    [SerializeField] public Material seeThroughMat;
    [SerializeField] public Material normalMat;

    [SerializeField] private AudioSource hi;
    [SerializeField] private AudioSource bye;


    public void OnSelect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = this.seeThroughMat;
            if(!bye.isPlaying)
            {
                bye.Play();
            }
        }
    }

    public void OnDeselect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = this.normalMat;
            hi.Play();
        }
    }
}
