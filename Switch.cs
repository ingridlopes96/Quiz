using System;

public class Switch
{
    public static void Example()
    {
        int option = 0;

        Console.WriteLine(
          "O que é variável? \n\n" +
          "1. Uma caixa? \n" +
          "2. Um espaço de memória para armazenar dados? \n" +
          "3. Um comando de computador? \n\n"
          );
        option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("Apesar do exemplo da caixa, no qual temos uma compreensão palpável do que é uma variável, este não é o termo técnico utilizado.");
                break;
            case 2:
                Console.WriteLine("Parabéns!! Você compreendeu os conceitos da aula.");
                break;
            case 3:
                Console.WriteLine("Variável não é um comando de computador necessariamente, mas sim um conceito que retrata o armazenamento de dados na memória do computador. Os comandos para criação de uma variável podem até cumprir esse papel.");
                break;
        }

    }

        string 
}