using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class WeatherSystem : MonoBehaviour
{
    [Header("Global")]
    public Material globalMaterial;
    public Light sunLight;
    public Material skyboxMaterial;

    [Header("Winter Assets")]
    public ParticleSystem winterParticleSystem;
    public Volume winterVolume;

    [Header("Rain Assets")]
    public ParticleSystem rainParticleSystem;
    public Volume rainVolume;

    [Header("Autumn Assets")]
    public ParticleSystem autumnParticleSystem;
    public Volume autumnVolume;

    [Header("Summer Assets")]
    public ParticleSystem summerParticleSystem;
    public Volume summerVolume;


    public void Winter()
    {
        globalMaterial.SetFloat("_SnowFade", 1);

        winterParticleSystem.Play();
        winterVolume.weight = 1;
        winterVolume.priority = 5;

        rainVolume.priority = 0;
        autumnVolume.priority = 0;
        summerVolume.priority = 0;

        rainVolume.weight = 0;
        autumnVolume.weight = 0;
        summerVolume.weight = 0;

        rainParticleSystem.Stop();
        autumnParticleSystem.Stop();
        summerParticleSystem.Stop();

    }

    public void Rain()
    {
        globalMaterial.SetFloat("_SnowFade", 0);

        rainParticleSystem.Play();
        rainVolume.weight = 0.55f;
        rainVolume.priority = 5;

        winterVolume.priority = 0;
        autumnVolume.priority = 0;
        summerVolume.priority = 0;

        winterVolume.weight = 0;
        autumnVolume.weight = 0;
        summerVolume.weight = 0;

        winterParticleSystem.Stop();
        autumnParticleSystem.Stop();
        summerParticleSystem.Stop();

    }

    public void Autumn()
    {
        globalMaterial.SetFloat("_SnowFade", 0);

        autumnParticleSystem.Play();
        autumnVolume.priority = 5;
        autumnVolume.weight = 0.55f;

        winterVolume.priority = 0;
        rainVolume.priority = 0;
        summerVolume.priority = 0;

        winterVolume.weight = 0;
        rainVolume.weight = 0;
        summerVolume.weight = 0;

        winterParticleSystem.Stop();
        rainParticleSystem.Stop();
        summerParticleSystem.Stop();

        
    }

    public void Summer()
    {
        globalMaterial.SetFloat("_SnowFade", 0);

        summerParticleSystem.Play();
        summerVolume.weight = 1;
        summerVolume.priority = 5;


        winterParticleSystem.Stop();
        rainParticleSystem.Stop();
        autumnParticleSystem.Stop();

        winterVolume.priority = 0;
        rainVolume.priority = 0;
        autumnVolume.priority = 0;
    }

}
