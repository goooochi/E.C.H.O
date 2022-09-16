using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrintFadeout : MonoBehaviour
{

    // フェードアウトするまでの時間(10sec)
    public float fadeTime = 10f;
    private float time;
    private SpriteRenderer render;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < fadeTime)
        {
            float alpha = 1.0f - time / fadeTime;
            Color color = render.color;
            color.a = alpha;
            render.color = color;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
