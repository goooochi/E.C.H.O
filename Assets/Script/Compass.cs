using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{

    [SerializeField] Image image;
    [SerializeField] Transform player;
    [SerializeField] public Transform destination;

    RectTransform rt;

    public static Compass instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        rt = image.rectTransform;
        destination = GameObject.Find("Key(Clone)").transform;
    }

    // Update is called once per frame
    void Update()
    {
        var qrot = Quaternion.LookRotation(destination.position - player.position);
        rt.rotation = new Quaternion(0,0 , -qrot.y, qrot.w);
    }
}
