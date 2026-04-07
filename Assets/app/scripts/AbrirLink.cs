using UnityEngine;

public class AbrirLink : MonoBehaviour
{
    // Isso permite que você digite o link direto no componente do Botão
    public void AbrirPagina(string url)
    {
        if (!string.IsNullOrEmpty(url))
        {
            Application.OpenURL(url);
            Debug.Log("Abrindo link: " + url);
        }
        else
        {
            Debug.LogWarning("O link passado está vazio!");
        }
    }
}