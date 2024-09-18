using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class UI_skript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Decrypt()
    {
        TextMeshPro.text = TextMeshPro.text.Replace('*', 'u');
    }
    public void Correct()
    {
        TextMeshPro.text = TextMeshPro.text.Replace('>', '\n');
    }
    public void Peel()
    {
        int i = TextMeshPro.text.Length - 1;
        while (TextMeshPro.text[i] != '.')
        {
            print(i);
            TextMeshPro.text = TextMeshPro.text.Remove(i);
            i--;
        }
        TextMeshPro.text = TextMeshPro.text.Replace('$', 's');
    }
    public void Encrypt ()
    {
        TextMeshPro.text = string.Concat(TextMeshPro.text.Select(c => $@"\u{(int)c:x4}"));
        TextMeshPro.text = TextMeshPro.text.Replace('0', '#');
    }
}
