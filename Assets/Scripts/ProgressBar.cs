using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public float timeToFill = 2f;
    public UnityEvent onBarFilled;

    private Image progressBarImage;
    private Coroutine routine;
    private EventTrigger eventTrigger;
    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        progressBarImage = GetComponent<Image>();
        if (progressBarImage == null)
        {
            Debug.LogError("No image on progress bar");
        }
        eventTrigger = GetComponentInParent<EventTrigger>();
        if (eventTrigger == null)
        {
            eventTrigger = transform.parent.parent.gameObject.AddComponent<EventTrigger>();
        }

        EventTrigger.Entry pointerClick = new EventTrigger.Entry();
        pointerClick.eventID = EventTriggerType.PointerClick;
        pointerClick.callback.AddListener((eventData) => { onBarFilled.Invoke(); });
        eventTrigger.triggers.Add(pointerClick);

        EventTrigger.Entry pointerEnter = new EventTrigger.Entry();
        pointerEnter.eventID = EventTriggerType.PointerEnter;
        pointerEnter.callback.AddListener((eventData) => { StartFilling(); });
        eventTrigger.triggers.Add(pointerEnter);
        
        EventTrigger.Entry pointerExit = new EventTrigger.Entry();
        pointerExit.eventID = EventTriggerType.PointerExit;
        pointerExit.callback.AddListener((eventData) => { StopFilling(); });
        eventTrigger.triggers.Add(pointerExit);
    }

    public void StartFilling()
    {
        if (player != null) transform.parent.LookAt(Camera.main.transform); ;
        StopFilling();
        routine = StartCoroutine(StartFillingCoroutine());
    }

    public void StopFilling()
    {
        progressBarImage.fillAmount = 0;
        if (routine != null)
        {
            StopCoroutine(routine);
            routine = null;
        }
    }

    private IEnumerator StartFillingCoroutine()
    {
        float t = 0;
        while (t < 1)
        {
            progressBarImage.fillAmount = t;
            t += Time.deltaTime / timeToFill;
            yield return null;
        }
        progressBarImage.fillAmount = 0;
        onBarFilled.Invoke();
    }
}
