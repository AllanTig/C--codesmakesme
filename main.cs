using System;

/*
//Exercicio 11
class MainClass {
  public static void Main (string[] args) {


int [] a= new int [20];
int [] b= new int [20];
int contador1=1,  contador2=20;

for(contador1=1;contador1<=20;contador1++){

Console.WriteLine("informe valor a " +contador1);
 a [contador1] =int.Parse(Console.ReadLine());
}
for(contador1=1;contador1<=20;contador1++){
contador2--;

b[contador1]=a[contador2];
}

for(contador1=1;contador1<=20;contador1++){

Console.Write ("valor a = " +a [contador1]);
Console.Write ("valor b = " +b [contador1]);
}

}
}*/
/*
//Exercicio 12
class MainClass {
  public static void Main (string[] args) {

string [] alunos= new string [8];
double [,] notas= new double[8 , 4] ;
double [] conta= new double [8];
double contatotal=0; 
double maiornota=0;
int contador=0;
int contador1=0;

for(contador=1;contador>=8;contador++){

Console.WriteLine ("informe nome aluno" +contador);
alunos [contador]= (Console.ReadLine());

for(contador1=1;contador1<=4;contador1++){
Console.WriteLine ("informe nota aluno"+contador);
notas [contador, contador1]= double. Parse(Console.ReadLine());

conta[contador]+=notas [contador, contador1];

conta[contador]=conta[contador]/4;

contatotal+=conta[contador];

}

}

contatotal=contatotal/8;

for(contador=1;contador>=8;contador++){
if(conta [contador]>maiornota){
  maiornota= conta [contador];
}
else{}
}
Console.Write ("\nMaior nota =" +maiornota);
Console.Write ("\nMedia da turma =" +contatotal);
for(contador=1;contador>=8;contador++){
Console.Write ("\nNome: " +alunos [contador]);
Console.Write ("\nMedia do aluno =" +conta [contador]);
}
Console.ReadKey();
}
}*/
/*
//Exercicio 13
class MainClass {
  public static void Main (string[] args) {

  int [,] A = new int [10, 10]; 
  double conta=0;
  int contador1=1, contador2=10, i=1;
  

for (i=1;i<=10;i++){
conta+=A[contador1, contador2];
contador1++;
contador2--;
}

Console.Write ("Conta =" +conta);

}
}*/
/*
//Exercicio 14
class MainClass {
  public static double ad (double x, double y)  {
  double conta;
  conta=x+y;
  return conta;
}
  public static double sub (double x, double y)  {
  double conta;
  conta=x-y;
  return conta;
}
  public static double mult (double x, double y) {
  double conta;
  conta=x*y;
  return conta;
}
  public static double div (double x, double y)  {
  double conta;
  conta=x/y;
  return conta;
}
  public static void Main (string[] args) {
    double x, y, conta,escolha2;
    char escolha;
    do{
      Console.WriteLine("informe seu x: ");
      x= double.Parse(Console.ReadLine());

      Console.WriteLine("informe seu y: ");
      y= double.Parse(Console.ReadLine());

      Console.WriteLine("informe sua op. +,-,*,/,z para nenhuma: ");
      escolha= char.Parse(Console.ReadLine());

      switch (escolha){
      case '+':
      conta = ad (x,y);
      Console.WriteLine ("valor= "+conta);
      break;
      case '-':
      conta = sub (x,y);
      Console.WriteLine ("valor= "+conta);
      break;
      case '*':
      conta = mult (x,y);
      Console.WriteLine ("valor= "+conta);
      break;
      case '/':
      conta = div (x,y);
      Console.WriteLine ("valor= "+conta);
      break;
      case 'z':
      break;
      default:
      Console.WriteLine ("nao listado");
      break;
    }
    Console.WriteLine("informe 1 para continuar: ");
    escolha2= int.Parse(Console.ReadLine());
    }
    while (escolha2==1);
  }
}*/
/*
//Exercicio 15
class MainClass{
public static void desligar (int n1)
{
Console.WriteLine("Sistema foi desligado");
}

public static void ligar (int n1){

Console.WriteLine("Sistema foi ligado");
}

public static void status (int n1)
{
if (n1==1){
  Console.WriteLine("Sistema esta ligado");
}
else 
Console.WriteLine("Sistema esta desligado");
}


public static void Main (string[] args){
int escolha1=1, escolha2=1;
int continuar;
do {
  Console.WriteLine ("informe 1 para ligar ou desligar e 2 para status : ");
  escolha1= int.Parse (Console.ReadLine());
if (escolha1==1){
  Console.WriteLine ("informe 1 para ligar e 0 para desligar : ");
  escolha2= int.Parse(Console.ReadLine()) ;
  switch (escolha2){

    case 0:
    desligar (escolha2);

    break ;
    case 1:
    ligar (escolha2);
    
    break ;
  }}
  else if(escolha1==2){
    status (escolha2);
  }

  Console.WriteLine ("Para continuar 1 : ");
  continuar= int.Parse (Console.ReadLine()) ;
}
  while (continuar ==1);
}
}*/