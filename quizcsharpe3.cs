﻿using System;

    static int acertos;
    static void QuizDois()
    {
        Console.WriteLine(" BEM VINDO AO QUIZ SOBRE BIOLOGIA"); //APRESENTAÇÃO
        Console.WriteLine("=================================\n");

        Console.WriteLine("A. O que é um herbívoro?\n\t" +
          "1) Animais predominantemente nativos do bioma de mangue.\n\t" +
          "2) Animais que voam.\n\t" +
          "3) Animais que possuem dieta que inclui vegetais ou algas.\n\t"); // resposta certa
        string resposta = Console.ReadLine();

        //if (resposta == "3") { Console.WriteLine("RESPOSTA CERTA!\n"); acertos++; }
        //else
        //{
        //    Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 3.\n");
        //}

        Console.WriteLine("B. Qual é o maior felino do planeta?\n\t" +
          "1) Girafa.\n\t" +
          "2) Elefane.\n\t" +
          "3) Baleia azul.\n\t"); // resposta certa
        resposta = Console.ReadLine();

        switch (resposta)
        {
            case "1":
                Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 3.\n");
                break;
            case "2":
                Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 3.\n");
                break;
            case "3":
                Console.WriteLine("RESPOSTA CERTA!\n");
                acertos++;
                break;
            
        }
        //if (resposta == "3") { Console.WriteLine("RESPOSTA CERTA!\n"); acertos++; }
        //else
        //{
        //    Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 3.\n");
        //}

        Console.WriteLine("C. Qual animal mais rápido do planeta?\n\t" +
          "1) Tigre siberiano.\n\t" +
          "2) Falcão peregrino.\n\t" + // resposta certa
          "3) Guepardo.\n\t");
        resposta = Console.ReadLine();

        switch (resposta)
        {
            case "1":
                Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 2.\n");
                break;

            case "2":
                Console.WriteLine("RESPOSTA CORRETA!\n");
                break;

            case "3":
                Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 2.\n");
                break; 
        }
        //if (resposta == "2") { Console.WriteLine("RESPOSTA CERTA!\n"); }
        //else
        //{
        //    Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 2.\n"); acertos++;
        //}

        Console.WriteLine("D. Quais desses animais não foram extintos?\n\t" +
          "1) Texugo negro.\n\t" + //resposta certa
          "2) Titanoboa\n\t" +
          "3) Megalodonte\n\t");
        resposta = Console.ReadLine();

        switch (resposta)
        {
            case "1":
                Console.WriteLine("RESPOSTA CORRETA!");
                break;
            case "2":
                Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 2\n");
                break;
            case "3":
                Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 2\n");
                break;
        }
        //if (resposta == "1") { Console.WriteLine("RESPOSTA CERTA!\n"); acertos++; }
        //else
        //{
            //Console.WriteLine("RESPOSTA INCORRETA. A resposta certa é a 1.\n");
        //}
        Console.WriteLine($"VOCÊ ACERTOU {acertos} PERGUNTAS!");

    }