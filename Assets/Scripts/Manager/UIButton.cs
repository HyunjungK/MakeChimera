using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIButton : MonoBehaviour
{
    public static UIButton Instance;
    Button btn;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        btn = this.transform.GetComponent<Button>();
    }

}
