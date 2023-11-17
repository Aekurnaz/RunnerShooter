using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowersSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _RangeUp;
    [SerializeField] private GameObject _RateUp;


    private int _randomValue;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PowerSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator PowerSpawn()
    {
        while (true)
        {
            _randomValue = Random.Range(1, 5);
            if (_randomValue == 1)
            {
                Instantiate(_RateUp, new Vector3(0, 3f, -70), Quaternion.identity);
            }
            else if (_randomValue == 2)
            {
                Instantiate(_RangeUp, new Vector3(0, 3f, -70), Quaternion.identity);
            }
            else
            {
                Instantiate(_RateUp, new Vector3(1, 3f, -70), Quaternion.identity);
                Instantiate(_RangeUp, new Vector3(-1, 3f, -70), Quaternion.identity);
            }
            yield return new WaitForSeconds(5f);
            
        }
    }
}
