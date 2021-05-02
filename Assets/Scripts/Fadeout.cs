using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Fadeout : MonoBehaviour
{
    public float timeToFade = 2f;
    public UnityEvent onFadeOut;
    public bool changeColor = false;

    private Image fadeout;
    private Color c;

    private void Awake()
    {
        fadeout = GetComponent<Image>();
        
    }

    private void Start()
    {
        FadeIn();
    }

    public void FadeIn()
    {
        StartCoroutine(FadeInCoroutine());
    }

    public void FadeOut()
    {
        StartCoroutine(FadeInCoroutine(false));
    }

    private IEnumerator FadeInCoroutine(bool isFadeIn = true)
    {
        c = fadeout.color;
        if (isFadeIn)
        {
            float t = 1f;
            while (t > 0)
            {
                fadeout.color = new Color(c.r, c.g, c.b, t);
                t -= Time.deltaTime / timeToFade;
                yield return null;
            }
            fadeout.color = new Color(c.r, c.g, c.b, 0);
            if (changeColor)
                fadeout.color = new Color(1, 1, 1, 0);
        }
        else
        {
            float t = 0f;
            while (t < 1)
            {
                fadeout.color = new Color(c.r, c.g, c.b, t);
                t += Time.deltaTime / timeToFade;
                yield return null;
            }
            fadeout.color = new Color(c.r, c.g, c.b, 1);
            onFadeOut.Invoke();
        }
    }
}
