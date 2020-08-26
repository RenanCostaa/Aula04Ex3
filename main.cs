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

  public static (int, int, int, int, int) computa(){
    int cand,jose=0,joana=0,roberto=0,branco=0,nulo=0;
    bool parar=false;
    string teste;

    do{
      Console.Clear();
      exibe();
      Console.WriteLine("Digite o codigo do candidato: ");
      cand=int.Parse(Console.ReadLine());

      switch (cand){
        
        case 33:
          jose= jose+1;
          break;

        case 25:
          joana=joana+1;
          break;

        case 10:
          roberto=roberto+1;
          break;

        case 0:
          branco=branco+1;
          break;

        case 4:
          nulo=nulo+1;
          break;

      }
      Console.WriteLine("---- Voto Computado ----");
      Console.WriteLine("Votar novamente? (s/n) ");
      
      teste=Console.ReadLine();
      if (teste=="n"){
        parar=true;
      }
    }while(parar==false);
    //Console.Write("{0},{1},{2},{3},{4}",jose,joana,roberto,branco,nulo);
    return (jose,joana,roberto,branco,nulo);
  }

  public static void calcula(int cand1, int cand2, int cand3, int bco, int nul){
    if (cand1>cand2 && cand1>cand3){
      Console.WriteLine("O Candidato vencedor foi **José Couve** ");
    }
    if (cand2>cand1 && cand2>cand3){
      Console.WriteLine("O Candidato vencedor foi **Joana Bravo** ");
    }
    if (cand3>cand1 && cand3>cand2){
      Console.WriteLine("O Candidato vencedor foi **Roberto Nove** ");
    }
    Console.WriteLine("Total de votos brancos foi de {0} !",bco);
    Console.WriteLine("Total de votos nulos foi de {0} !",nul);

  }
  public static void Main () {
    int a,b,c,d,e;
    exibe();
    (a,b,c,d,e) = computa();
    calcula(a,b,c,d,e);

  }
}