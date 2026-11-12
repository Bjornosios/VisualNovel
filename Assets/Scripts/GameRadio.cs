using UnityEngine;

public class GameRadio : MonoBehaviour
{
    [SerializeField] AudioSource BoomBox;
    [SerializeField] AudioClip HoverSound;
    [SerializeField] AudioClip ClickSound;

    public void Hovering()
    {
        BoomBox.PlayOneShot(HoverSound);
    }
    public void Clicking()
    {
        BoomBox.PlayOneShot(ClickSound);
    }
}
