using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticleEffectController : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public string nextSceneName;

    public void Start()
    {
        // Desactiva el sistema de partículas al inicio
        particleSystem.Stop();
    }

    public void ToggleParticleEffect()
    {
        if (particleSystem.isPlaying)
        {
            // Si el sistema de partículas está activo, lo detenemos
            particleSystem.Stop();
        }
        else
        {
            // Si el sistema de partículas está inactivo, lo activamos
            particleSystem.Play();
            Invoke("ChangeScene", 8f);
        }
    }

    private void ChangeScene()
    {
        // Cambia a la próxima escena
        SceneManager.LoadScene(nextSceneName);
    }
}