using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeBlack : MonoBehaviour
{
    Image image;
    [SerializeField] float startFadeDuration = 3f;
    
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        Fade(1, 0, startFadeDuration);
    }

    public void Fade(float from, float too, float duration)
    {
        LeanTween.value(gameObject, from, too, duration).setOnUpdate((float val) =>
        {
            Color c = image.color;
            c.a = val;
            image.color = c;
        });
    }

}
