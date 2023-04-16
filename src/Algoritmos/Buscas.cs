namespace Algoritmos;

public class Buscas
{
    public int? PesquisaBinaria<T>(IEnumerable<T> lista, T item) where T : IComparable<T>
    {
        var baixo = 0;
        var alto = lista.Count() - 1;
        while (baixo <= alto)
        {
            var meio = (baixo + alto) / 2;
            var chute = lista.ElementAt(meio);

            var comparacao = item.CompareTo(chute);
            if (comparacao == 0)
                return meio;
            if (comparacao < 0)
                alto = meio - 1;
            else
                baixo = meio + 1;
        }

        return null;
    } 
}