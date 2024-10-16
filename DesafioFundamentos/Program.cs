﻿using DesafioFundamentos.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;
static void Main(string[] args)
{
    decimal precoInicial = 0;
    decimal precoPorHora = 0;

    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                      "Digite o preço inicial:");
    precoInicial = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Agora digite o preço por hora:");
    precoPorHora = Convert.ToDecimal(Console.ReadLine());

    Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

    bool exibirMenu = true;

    do
    {
        MostrarMenu();
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                es.AdicionarVeiculo();
                break;

            case "2":
                es.RemoverVeiculo();
                break;

            case "3":
                es.ListarVeiculos();
                break;

            case "4":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    } while (exibirMenu);
    Console.WriteLine("O programa se encerrou");
}

static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
}