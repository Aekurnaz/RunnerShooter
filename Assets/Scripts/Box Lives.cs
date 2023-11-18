using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxLives : MonoBehaviour
{
    private TextMeshPro _text;

    public float _boxLives;
    

    private void Awake()
    {
        _text = GetComponent<TextMeshPro>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _boxLives = Random.Range(8, 12);
        _text.text= _boxLives.ToString();
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out BulletMovement _))
        {
            _boxLives--;
            Destroy(other.gameObject);
            _text.text = (_boxLives.ToString());

            if(_boxLives <= 0)
            {
                Destroy(this.transform.parent.gameObject);
            }
        }

        if (other.gameObject.TryGetComponent(out BulletSpawn player))
        {
            Destroy(this.gameObject);
            Debug.Log("Player Damaged");
        }
    }
}
