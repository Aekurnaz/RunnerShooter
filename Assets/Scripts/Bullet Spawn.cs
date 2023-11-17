using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{

    [SerializeField] private GameObject _bullet;
    [SerializeField] public float _spawnTime;
    [SerializeField] public float _bulletRange = 10f;
    [SerializeField] private GameObject _bulletWall;

    private float _spawntimer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BulletSpawnn());
        
    }

    private void Update()
    {
        BulletWallPos();
        _spawntimer = _spawnTime;
    }
    IEnumerator BulletSpawnn()
    {
        while (true)
        {
            Instantiate(_bullet, transform.position + new Vector3(0.15f,.9f,.6f), Quaternion.identity);
            yield return new WaitForSeconds(_spawnTime);
            
        }
    }

    private void BulletWallPos()
    {
        _bulletWall.transform.position = transform.position + new Vector3(0,0,_bulletRange);
    }

    
}
