﻿namespace ConversorDeNumerosRomanos;

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
        for (int i = numeroRomano.Length -1; i >= 0; i--)
        {
        
            int atual = tabela[numeroRomano[i]];
            int multiplicador = 1;

            if (atual < ultimoVizinhoDaDireita) multiplicador = -1;
            
            acumulador += atual * multiplicador;
            
            ultimoVizinhoDaDireita = atual;
        }

        return acumulador;
     }

 }