import java.util.Scanner;

class Main {
  public static void main(String[] args) {
  Scanner entrada = new Scanner(System.in);
    
    int linha1=0, linha2=0, coluna1=0, coluna2=0, pts=0, contador2=0, linha=0, coluna=0, contador1=0, n=0,  ptsn=0,  quantj=0;
    int tabuleiro [][] = new int [6][6];
    int escolha=0, a=0, nulo=0;
    int aux[] = new int [30];
    int i, j;

      System.out.println("\n--------------------jogo-da-memoria--------------------\n");
      System.out.println("Acertos= 1ponto\nErros= -1ponto\nNao vale tira print....");
      try { 
      Thread.sleep (4000);
      } catch (InterruptedException ex) {}
      
      System.out.println("Nem roubar grrr.....");
        //FAZ A MENSAGEM DEMORAR 4 SEGUNDOS PARA APARECER//
        System.out.println("\n\nBOM JOGO!!!\n");
         try { 
      Thread.sleep (4000);
      } catch (InterruptedException ex) {}

        //REPETE O CODIGO 6 VZS PARA LINHA
      for(i = 0; i < 6; i++){
        //REPETE O CODIGO 6 VEZES PARA COLUNA  
        for(j = 0; j < 6; j++){
            do
            {
                n = (int)(Math.random()*18);
                tabuleiro[i][j] = n;
            }
            while(aux[tabuleiro[i][j]]-1 == 1);
            aux[tabuleiro[i][j]]++;
        }
       } 
//ESSE GERA NUMEROS RANDOMICOS IGUAIS PARA CADA 2 CARTAS   

for(linha = 0; linha < 6 ;linha++){
    for(coluna = 0; coluna < 6;coluna++){
      
     System.out.print("\t"+tabuleiro[linha][coluna]);

  }
  System.out.println();
  }




try { 
     Thread.sleep (8000);
} catch (InterruptedException ex) {}
//FAZ O CODIGO DEMORR 8 SEG. PARA SER CONTINUADO

for (a=0;a<150;a++){
  System.out.println();
}
//PULA 151 LINHAS

do{
    System.out.println("\ninforme linha e coluna (1): ");
     linha1 = entrada.nextInt ();
     linha1-=1;
     coluna1 = entrada.nextInt ();
     coluna1-=1;
     //LE A LINHA E A COLUNA QUE O USUARIO VAI INFORMAR//
    System.out.println("\ninforme linha  e coluna (2): ");
     linha2 = entrada.nextInt ();
     linha2-=1;
     coluna2 = entrada.nextInt ();
     coluna2-=1;
     //LE A LINHA E A COLUNA QUE O USUARIO AI INFORMAR PELA SEGUNDA VEZ//
    //SE LINHA E COLUNA DO TABULEIRO 1 E 2 INFORMADOS ANTERIORMENTE FOREM IGUAIS VAI RODAR ESTE
    if (tabuleiro[linha1][coluna1]==tabuleiro[linha2][coluna2]){
     for(linha = 0; linha < 6 ;linha++){
       //REPETE O CODIGO 6 VEZES PARA LINHA  
    for(coluna = 0; coluna < 6;coluna++){
      //REPETE O CODIGO 6 VEZES PARA COLUNA  
      
      if (tabuleiro[linha][coluna]==tabuleiro[linha1][coluna1]){
        //SE O O VALOR DESTES FOREM IGUAIS VAI PRINTAR NA LINHA CORRETA DO DO TABULEIRO MOSTRADO NO CONSOLE
     System.out.print("\t"+tabuleiro[linha][coluna]);
     }
     else if (tabuleiro[linha][coluna]==tabuleiro[linha2][coluna2]){
     System.out.print("\t"+tabuleiro[linha][coluna]);
     //SE O O VALOR DESTES FOREM IGUAIS VAI PRINTAR NA LINHA CORRETA DO DO TABULEIRO MOSTRADO NO CONSOLE
     }
     else{
       System.out.print("\t"+nulo);
       //SE NENHUM DOS ANTERIORES  FOR POSSIVEIS O VALOR PRINTADO SERA 0
     }

  }
  System.out.println();
  }
  try { 
     Thread.sleep (2000);
} catch (InterruptedException ex) {}
//FAZ O CODIGO DEMORAR 2 SEGUNDOS PARA APARECER A TABELA NOVAMENTE//
for (a=0;a<150;a++){
  System.out.println();
}
//PULA 151 LINHAS//

    }
    else{}
     
    if (tabuleiro[linha1][coluna1]==tabuleiro[linha2][coluna2])
    {
      //TESTA PARA SE FOR VALORES IGUAIS VAI SOMAR UM PONTO 

      pts+=1;//SOMA UM PONTO AOS PONTOS JA EXISTENTES//
      quantj+=1;//CONTA QUANTAS VEZES ELE JOGOU//
         System.out.println("Voce ganhou um ponto!!!!");
    }//VERIFICA SE O USUARIO ACERTOU E SE A CONDICAO FOR VERDADEIRA ELE GANHA UM PONTO//
    else if(tabuleiro[linha1][coluna1]!=tabuleiro[linha2][coluna2]){
      //TESTA PARA SE FOR VALORES IGUAIS VAI SOMAR UM PONTO NO CONTADOR PRA SABER QUANDO DIMINUIR UM PONTO NO SEU TOTAL
      contador2++;
      if(contador2==2){
        //TESTA O CONTADOR PARA SE FOR =2 VAI DIMINUIR UM PONTO 
      pts-=1;//TIRA UM PONTO DOS JA EXISTENTES//
      ptsn+=1;//CONTA QUANTAS VEZES ELE ERROU//
      quantj+=1;//CONTA QUANTAS VEZES ELE JOGOU//
        contador2=0;
        System.out.println("Voce perdeu um ponto");
      }//VERIFICA SE O USUARIO ERROU E SE A CONDICAO FOR VERDADEIRA ELE PERDE UM PONTO//
      else if(contador2==1){
        //AVISA ERRO TESTANDO O CONTADOR PARA SE FOR =1 ANTES DE DIMINUIR UM PONTO 
        System.out.println("Voce já errou uma vez, só tem mais uma chance!!!");
        quantj+=1;//CONTA QUANTAS VEZES ELE JOGOU//
      }
    }
    System.out.println("Deseja continuar: \nSe sim digite (s)");//PERGUNTA AO USUARIO SE ELE QUER CONTINUAR//
     escolha = entrada.next() .charAt(0);//LE A RESPOSTA DO USUARIO SOBRE CONTINUAR JOGANDO OU NAO//

  
} while(escolha == 's'||escolha == 'S');
//E USADO PARA FICAR VOLTANDO O CODIGO ATE A LINHA 65 ATE O USUARIO INFORMAR QUE NAO QUER MAIS CONTINUAR JOGANDO//

if(pts>=13 && pts<=23){
  
  System.out.println("Voce jogou: "+quantj); 
  System.out.println(" vezes.");
  System.out.println("E voce errou: "+ptsn);
  System.out.println(" vezes.");
  System.out.println("otimo!! Voce fez: " +pts);
  System.out.println(" pontos."); 
}//ESTA PARTE VAI MOSTRAR QUANTAS JOGADAS VOCE FEZ QUANTAS ERROU E VAI MOSTRAR OS PONTOS SE ELES FOREM MAIORES OU IGUAIS A 13 E MENORES OU IGUAIS A 23//
else if(pts<=12 && pts>=1){
  
  System.out.print("Voce jogou: "+quantj);
  System.out.println(" vezes.");
  System.out.print("E voce errou: "+ptsn);
  System.out.println(" vezes."); 
  System.out.print("Bom! Voce fez: " +pts);
  System.out.println(" pontos.");
}//ESTA PARTE VAI MOSTRAR QUANTAS JOGADAS VOCE FEZ QUANTAS ERROU E VAI MOSTRAR OS PONTOS SE ELES FOREM MENORES OU IGUAIS A 12 E MAIORES OU IGUAIS A 1//
else if(pts>=24){
 
  System.out.print("Voce jogou: "+quantj);
  System.out.println(" vezes.");
  System.out.print("E voce errou: "+ptsn);
  System.out.println(" vezes."); 
  System.out.print("Parabens!!!! Voce fez: " +pts);
  System.out.println(" pontos.");
}//ESTA PARTE VAI MOSTRAR QUANTAS JOGADAS VOCE FEZ QUANTAS ERROU E VAI MOSTRAR OS PONTOS SE ELES FOREM MAIORES OU IGUAIS A 24//
else if(pts==30){
 
  System.out.print("Voce jogou: "+quantj);
  System.out.println(" vezes.");
  System.out.print("E voce errou: "+ptsn);
  System.out.println(" vezes.");  
  System.out.print("PERFEITO!!!!!!!! Voce fez: " +pts);
  System.out.println(" pontos.");
}//ESTA PARTE VAI MOSTRAR QUANTAS JOGADAS VOCE FEZ QUANTAS ERROU E VAI MOSTRAR OS PONTOS SE ELES FOREM IGUAIS A 30//
else{
  System.out.print("Voce jogou: "+quantj);
  System.out.println(" vezes.");
  System.out.print("E voce errou: "+ptsn);
  System.out.println(" vezes."); 
  System.out.println("Ate que voce nao foi tao mal....\nSo nao pontuou nada.....\nTente outra vez!!");
}//ESTA PARTE VAI MOSTRAR QUANTAS JOGADAS VOCE FEZ QUANTAS ERROU E VAI INFORMAR AO USUARIO QUE ELE NAO PONTUOU NADA//
}
}