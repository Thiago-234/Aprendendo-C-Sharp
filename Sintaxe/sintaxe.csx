// Para códigos mais simples, pode-se usar arquivos .csx (C# Script) que não precisam de toda a estrutura
using System;  // Classe que possui métodos comuns, como WriteLine
Console.WriteLine("Hello, World!");  // Imprime a mensagem no console

// Códigos mais complexos devem ser feitos em arquivos .cs e precisam de uma estrutura completa
// A estrutura básica de um programa em C# inclui namespaces, classes e o método Main
// Usando "dotnet new console -n HelloWorld" para criar um projeto de console

// Estrutura básica de um programa em C#
// Para arquivos .cs, você precisa de namespaces, classes e o método Main

// namespace HelloWorld // Container para classes
// {
//     // Por ser um arquivo de script .csx, não é necessário o namespace, só quando for um arquivo .cs
//     class Program
//     {
//         static void Main(string[] args)
//         { 
//             // Código que será executado dentro das chaves
//             Console.WriteLine("Hello, World!");  // Imprime a mensagem no console
//                                                 // Caso o using System não estivesse presente, seria necessário usar System.Console.WriteLine
//         }
//     }
// }
