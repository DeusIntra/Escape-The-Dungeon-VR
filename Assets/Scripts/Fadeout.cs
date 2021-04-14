using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Fadeout : MonoBehaviour
{
    public float timeToFade = 2f;
    public UnityEvent onFadeOut;

    private Image fadeout;

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
        if (isFadeIn)
        {
            float t = 1f;
            while (t > 0)
            {
                fadeout.color = new Color(0, 0, 0, t);
                t -= Time.deltaTime / timeToFade;
                yield return null;
            }
            fadeout.color = new Color(0, 0, 0, 0);

        }
        else
        {
            float t = 0f;
            while (t < 1)
            {
                fadeout.color = new Color(0, 0, 0, t);
                t += Time.deltaTime / timeToFade;
                yield return null;
            }
            fadeout.color = new Color(0, 0, 0, 1);
            onFadeOut.Invoke();
        }

    }
}
