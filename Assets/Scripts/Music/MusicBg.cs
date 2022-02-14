using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBg : MonoBehaviour
{
    public static MusicBg bgmus;

    private void Awake()
    {
        if (bgmus != null && bgmus != this)
        {
            Destroy(this.gameObject);
            return;
        }

        bgmus = this;
        DontDestroyOnLoad(this);
    }
}
