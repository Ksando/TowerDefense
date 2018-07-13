//Sasha
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public Wave[] waves;
	public Transform spawnPoint;
	public float timeBetweenWaves = 6f;
	private float countdown = 0f;
	public Text waveCountdownText;
	private int waveIndex = 0;
    
    public int getWaveIndex()
    {
        return waveIndex;
    }



    void Update()
    {
        if (waveIndex == waves.Length)
            waveCountdownText.text = "Last";
        
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
        if (waveCountdownText.text != "Last")
        {
            //waveCountdownText.text = Mathf.Round(countdown).ToString();
            waveCountdownText.text = timeLeft(countdown);
        }
	}

	IEnumerator SpawnWave ()
    {
		Wave wave = waves[waveIndex];
        waveIndex++;


            for (int j = 0; j < wave.enemy.Length; j++)
            {
                SpawnEnemy(wave.enemy[j]);
                yield return new WaitForSeconds(1f / wave.rate);
            }
	}

	void SpawnEnemy (GameObject enemy)
	{
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
	}

    string timeLeft(float c)
    {
        //c = Mathf.Round(c);
        int mins = (int)c / 60;
        int secs = (int)c % 60;
        return mins + ":" + ((secs < 10) ? "0" : "") + secs;
    }

}
