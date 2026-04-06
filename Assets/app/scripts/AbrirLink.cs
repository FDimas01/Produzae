using UnityEngine;

public class AbrirLink : MonoBehaviour
{
    public void AbrirPagina()
    {
        string url = "https://pt.scribd.com/document/715065182/Enem-2023-grade-de-correc-a-o";
        Application.OpenURL(url);
    }
}