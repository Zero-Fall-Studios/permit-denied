using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RFG
{
  [AddComponentMenu("RFG/Effects/Effect")]
  public class Effect : MonoBehaviour, IPooledObject
  {
    [field: SerializeField] public EffectData EffectData { get; set; }
    private Transform _transform;
    private List<AudioSource> _audioSources;
    private Animator _animator;
    private SpriteRenderer _sr;

    private void Awake()
    {
      _transform = transform;
      _audioSources = new List<AudioSource>(GetComponents<AudioSource>());
      _animator = GetComponent<Animator>();
      _sr = GetComponent<SpriteRenderer>();
    }

    public void OnObjectSpawn(params object[] objects)
    {
      Play(objects);
    }

    private void OnEnable()
    {
      if (EffectData != null && !EffectData.pooledObject)
      {
        OnObjectSpawn();
      }
    }

    public void Dispose()
    {
      gameObject.SetActive(false);
    }

    public void Play(params object[] objects)
    {
      if (EffectData == null)
        return;

      if (_sr != null)
      {
        _sr.enabled = true;
      }

      // Play Audio
      if (_audioSources != null)
      {
        PlayAudio();
      }

      // Play Animtions
      if (_animator != null && EffectData.animationClip != null)
      {
        _animator.Play(EffectData.animationClip);
      }

      // Spawn Effects
      _transform.SpawnFromPool(EffectData.spawnEffects, objects);

      // Camera Shake
      if (EffectData.cameraShakeIntensity > 0)
      {
        CinemachineShake.Instance.ShakeCamera(EffectData.cameraShakeIntensity, EffectData.cameraShakeTime, EffectData.cameraShakeFade);
      }

      if (EffectData.lifetime > 0)
      {
        StartCoroutine(StartTtl());
      }
    }

    private IEnumerator StartTtl()
    {
      yield return new WaitForSeconds(EffectData.lifetime);
      gameObject.SetActive(false);
    }

    private void PlayAudio()
    {
      if (EffectData == null)
        return;

      for (int i = 0; i < EffectData.soundEffects.Count; i++)
      {
        AudioData audioData = EffectData.soundEffects[i];
        AudioSource audioSource = _audioSources[i];
        audioData.ConfigureAudioSource(audioSource);
        if (audioData.randomPitch)
        {
          audioSource.pitch = UnityEngine.Random.Range(audioData.minPitch, audioData.maxPitch);
        }
        if (audioData.fadeTime != 0f)
        {
          StartCoroutine(audioSource.FadeIn(audioData.fadeTime));
        }
        else
        {
          audioSource.Play();
        }
      }
    }
  }
}