namespace Algoritmos.Tests;

public class BuscasTests
{
    private readonly Buscas _buscas;

    public BuscasTests()
    {
        _buscas = new Buscas();
    }

    [Fact(DisplayName = "Deve encontrar a posição correta do item na lista de inteiros"),Trait("Busca Binária","Buscas")]
    public void DeveEncontrarAPosicaoDoItemDentroDaListaDeInteiros()
    {
        var listaNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

        var resultado = _buscas.PesquisaBinaria(listaNumeros, 7);
        
        Assert.Equal(6, resultado);
    }
    [Fact(DisplayName = "Deve encontrar a posição correta do item na lista de strings"),Trait("Busca Binária","Buscas")]
    public void DeveEncontrarAPosicaoDoItemDentroDaListaDeStrings()
    {
        var listaNumeros = new List<string> { "Andre", "Biel", "Carlos", "Daniel", "Ederson" };

        var resultado = _buscas.PesquisaBinaria(listaNumeros, "Andre");
        
        Assert.Equal(0, resultado);
    }

    [Fact(DisplayName = "Deve retornar null quando item não for encontrado na lista"),Trait("Busca Binária","Buscas")]
    public void DeveRetornarNullQuandoItemNaoEncontrado()
    {
        var listaNumeros = new List<string> { "Andre", "Biel", "Carlos", "Daniel", "Ederson" };

        var resultado = _buscas.PesquisaBinaria(listaNumeros, "Igor");
        
        Assert.Null(resultado);
    }
}