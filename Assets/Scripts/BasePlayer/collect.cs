using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour {
    private SpriteRenderer renderer;
    private Sprite[] sprites;

    private Sprite Random_Sprite(int min, int max)
    {
        var randomValue = Random.Range(min, max);
        return sprites[randomValue];
    }

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>("Coins");
        renderer.sprite = Random_Sprite(0, sprites.Length - 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Moving.score += 13.0f;
        Destroy(gameObject);
        Debug.Log(Moving.score);
    }
}
