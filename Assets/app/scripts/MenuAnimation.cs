using UnityEngine;
using System.Collections;

public class SlideSinglePanel : MonoBehaviour
{
    private RectTransform rectTransform;
    private bool painelExpandido = false;

    [Header("Configurações de Movimento")]
    public float posicaoXFechado = 0f;    // Posição encostado na borda
    public float posicaoXAberto = 400f;   // Quanto ele deve "entrar" na tela
    public float velocidade = 0.5f;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        // Garante que comece na posição fechada
        rectTransform.anchoredPosition = new Vector2(posicaoXFechado, rectTransform.anchoredPosition.y);
    }

    public void MoverPainel()
    {
        StopAllCoroutines(); // Para a animação atual se você clicar rápido demais
        float destino = painelExpandido ? posicaoXFechado : posicaoXAberto;
        StartCoroutine(Animar(destino));
        painelExpandido = !painelExpandido;
    }

    IEnumerator Animar(float destinoX)
    {
        float tempo = 0;
        Vector2 posInicial = rectTransform.anchoredPosition;
        Vector2 posFinal = new Vector2(destinoX, posInicial.y);

        while (tempo < velocidade)
        {
            tempo += Time.deltaTime;
            rectTransform.anchoredPosition = Vector2.Lerp(posInicial, posFinal, tempo / velocidade);
            yield return null;
        }
        rectTransform.anchoredPosition = posFinal;
    }
}