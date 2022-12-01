using System;

class Program
{
    static void Main(string[] args)
    {
        int hi, mi, hf, mf;
        string[] s = Console.ReadLine().Split(' ');
        hi = int.Parse(s[0]);
        mi = int.Parse(s[1]);
        hf = int.Parse(s[2]);
        mf = int.Parse(s[3]);

        int tempoInicial = (int)hi * 60 + mi;
        int tempoFinal = (int)hf * 60 + mf;

        int tempoTotal;
        if (tempoInicial < tempoFinal)
        {
            tempoTotal = tempoFinal - tempoInicial;
        }
        else
        {
            tempoTotal = (int)((24 * 60) - tempoInicial) + tempoFinal;
        }

        int resultadoHora = tempoTotal / 60;
        int resultadoMinuto = tempoTotal % 60;

        Console.WriteLine("O JOGO DUROU " + resultadoHora + " HORA(S) E " + resultadoMinuto + " MINUTO(S)");        
    }
}