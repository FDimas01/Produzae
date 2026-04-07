using UnityEngine;
using System.Collections.Generic;

public class ScreenManager : MonoBehaviour
{
    [Header("Lista de todos os Painéis")]
    public List<GameObject> todosOsPaineis;

    [Header("Painel Inicial")]
    public GameObject painelInicial;

    void Awake()
    {
        // Ao iniciar, garante que apenas o Start Panel esteja ativo
        AbrirPainel(painelInicial);
    }

    // Função principal para trocar de tela
    public void AbrirPainel(GameObject painelParaAbrir)
    {
        if (painelParaAbrir == null) return;

        // Desativa todos os painéis da lista
        foreach (GameObject p in todosOsPaineis)
        {
            if (p != null)
                p.SetActive(false);
        }

        // Ativa apenas o painel desejado
        painelParaAbrir.SetActive(true);
    }
}