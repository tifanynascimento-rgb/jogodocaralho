using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int pontuacaoAtual;

    void Awake()
    {
        instance = this;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pontuacaoAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao(int pontosParaGanhar)
    {
        Debug.Log("Pontuação atual: " + pontuacaoAtual);
        pontuacaoAtual =+ pontosParaGanhar;
    }
}
