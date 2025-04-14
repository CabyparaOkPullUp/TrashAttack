using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;//PRefab do Inimigo

    [SerializeField]
    private float _minimumSpawnTime;//Tempo minimo de spawn

    [SerializeField]
    private float _maximumSpawnTime;//Tempo Maximo de spawn 

    private float _timeUntilSpawn;//Sei oque é mas não sei explicar
    // Start is called before the first frame update
    void Start()
    {
        SetTimeUntilSpawn();//Colocar tempo porra
    }

    // Update is called once per frame
    void Update()//código que define como e quando o inimigo vai spawnar
    {
        _timeUntilSpawn -= Time.deltaTime;
        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);//Agora é o código escolhendo um lugar aleatório mas com o time
    }
}
