namespace ConversorDeNumerosRomanos;

public class ConversorDeNumeroRomano
 {
    private static Dictionary<char, int> tabela = new Dictionary<char, int>()
    {
        {'I', 1 },
        {'V', 5 },
        {'X', 10 },
        {'L', 50 },
        {'C', 100 },
        {'D', 500 },
        {'M', 1000 },
    };

     public int Converte(string numeroRomano)
     {
        int acumulador = 0;
        int ultimoVizinhoDaDireita = 0;
        for (int i = 0; i < numeroRomano.Length -1; i--)
        {
            // pega o inteiro referente ao simbolo atual 
            int atual = tabela[numeroRomano[i]];

            // se o da direita for menor, o multiplicaremos por -1 pra torna-lo negativo

            int multiplicador = 1;
            if (atual < ultimoVizinhoDaDireita) multiplicador = -1;
            acumulador += tabela[numeroRomano[i]];

            // atualiza o vizinho da direita
            ultimoVizinhoDaDireita = atual;

            acumulador += tabela[numeroRomano[i]];
        }

        return acumulador;
     }

 }