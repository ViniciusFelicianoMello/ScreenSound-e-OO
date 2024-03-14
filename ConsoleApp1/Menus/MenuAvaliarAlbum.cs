﻿using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar Álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        // Se a banda existir no dicionario >> atribuir uma nota, Se nao existir voltar ao menu principal
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual nota o Álbum {tituloAlbum} merece? : ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum} com sucesso!");
                Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }

        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi registrada!");
            Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!");
            Console.ReadKey();
            Console.Clear();
        }   
        
    }
}
