using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public Wave[] waves;
	public Transform spawnPoint;
	public float timeBetweenWaves = 6f;
	private float countdown = 2f;
	public Text waveCountdownText;
	private int waveIndex = 0;



    void Update ()
	{
        if (waveIndex == waves.Length) // removing the timer
        {
            Destroy(waveCountdownText);
        }

        if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
			return;
		}

		countdown -= Time.deltaTime;

		countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
        if (waveCountdownText)
        {
            waveCountdownText.text = Mathf.Round(countdown).ToString();
        }
	}

	IEnumerator SpawnWave ()
	{
		Wave wave = waves[waveIndex];


            for (int j = 0; j < wave.enemy.Length; j++)
            {
                SpawnEnemy(wave.enemy[j]);
                yield return new WaitForSeconds(1f / wave.rate);
            }
		waveIndex++;
	}

	void SpawnEnemy (GameObject enemy)
	{
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
	}

}
