﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public ParticleSystem explosion;
    public GameObject player;

    void Start()
    {
        explosion.Stop();
    }

    void FixedUpdate()
    {
        explosion.transform.position = player.transform.position;
    }

    public void GameOver()
    {
        player.SetActive(false);
        Invoke("Reload", 2);
        explosion.Play();
    }

    void Reload()
    {
        SceneManager.LoadScene(0);
    }
}


