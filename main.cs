using System;
/*
3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo

Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;
*/

class MainClass {

  public static void exibe(){
    Console.WriteLine("--- Lista de Candidatos ---");
    Console.WriteLine("33 - José Couve");
    Console.WriteLine("25 - Joana Bravo");
    Console.WriteLine("10 - Roberto Nove");
    Console.WriteLine("0  - Voto branco");
    Console.WriteLine("4  - Voto nulo");
    Console.WriteLine("");
    Console.WriteLine("Selecione seu candidato utlizando seu numero");
  }
  public static void votacao(){
    int cand;
    bool parar=false
    do{
      exibe();
      Console.WriteLine("Digite o codigo do candidato: ");
      cand=int.Parse(Console.ReadLine());
      Console.WriteLine("Votar novamente? (s/n) ");
      teste=Console.ReadLine();
    }while(parar==false);


  public static void Main () {

  }
}