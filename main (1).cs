 using System;

 
/*
class MainClass {
  public static void Main (string[] args) {
    int temf;
    double celsius;
    Console.WriteLine ("informe a temperatura atual em ºF: ");
    temf =int.Parse(Console.ReadLine());
    celsius=(temf-32)*(5.0/9.0);
    Console.Write ("Sua temp. em ºF e: " +temf);
    Console.Write ("\nSua temp. em ºC e: " +celsius);
 Console.ReadKey();
    
  }
}*/
/*
class MainClass {
  public static void Main (string[] args) {
    double a,b,c,d,e,f,x,y;
    Console.WriteLine ("informe o valor de a: ");
    a =double.Parse(Console.ReadLine());
    Console.WriteLine ("informe o valor de b: ");
    b =double.Parse(Console.ReadLine());
    Console.WriteLine ("informe o valor de c: ");
    c =double.Parse(Console.ReadLine());
    Console.WriteLine ("informe o valor de d: ");
    d =double.Parse(Console.ReadLine());
    Console.WriteLine ("informe o valor de e: ");
    e =double.Parse(Console.ReadLine());
    Console.WriteLine ("informe o valor de f: ");
    f =double.Parse(Console.ReadLine());
    x=((c*e)-(b*f))/((a*e)-(b*d));
    y=((a*f)-(c*d))/((a*e)-(b*d));
Console.Write("valor de x="+x);
Console.Write("\nvalor de y="+y);
 Console.ReadKey();
    
  }
}*/
/*
class MainClass {
  public static void Main (string[] args) {
    int a,b,c;
    Console.WriteLine("informe o valor de a:");
    a=int.Parse(Console.ReadLine());
    Console.WriteLine("informe o valor de b:");
    b=int.Parse(Console.ReadLine());
    c=a;
    a=b;
    b=c;
    Console.Write("a="+a);
    Console.Write("\nb="+b);
 Console.ReadKey();
    
  }
}*/
/*
class MainClass {
  public static void Main (string[] args) {
    int escolha;
    double valor;
    Console.WriteLine ("informe um codigo de 1 a 5: ");
    escolha =int.Parse(Console.ReadLine());
    Console.WriteLine ("informe um valor: ");
    valor =double.Parse(Console.ReadLine());
    switch (escolha){
      case 1:
      Console.WriteLine ("libra esterlina "+valor);
      break;
      case 2:
      Console.WriteLine ("franco suiço "+valor);
      break;
      case 3:
      Console.WriteLine ("dolar americano "+valor);
      break;
      case 4:
      Console.WriteLine ("marco alemao "+valor);
      break;
      case 5:
      Console.WriteLine ("real "+valor);
      break;
      default:
      Console.WriteLine ("nao listado");
      break;
    }

 Console.ReadKey();
    
  }
}*/

/*class MainClass {
  public static void Main (string[] args) {
    double salario;
    double valor;
    Console.WriteLine ("informe sua um salario: ");
    salario =double.Parse(Console.ReadLine());
    
    if (salario <= 400.00)
    valor=salario*1.15;
    else
    if (salario >400.00 &&salario <=700.00)
    valor=salario*1.12;
    else
    if (salario > 700.00 &&salario <=1000.00)
    valor=salario*1.10;
    else
    if (salario >1000.00 &&salario <=1500.00)
    valor=salario*1.07;
    else
    if (salario >1500.00 &&salario <=2000.00)
    valor=salario*1.04;
    else
    if (salario > 2000.00)
    valor=salario;
    else
    Console.Write("Nao consta no sistema");

    Console.Write("Seu salario anterior: "+salario); Console.Write("\nSeu salario atual: "+valor);
   

    Console.ReadKey();
  }
}*/
/*
class MainClass {
  public static void Main (string[] args) {
    int escolha;
    Console.WriteLine ("informe um valor de 100 a 103:");
    escolha =int.Parse(Console.ReadLine());
    switch (escolha){
      case 100:
      Console.WriteLine ("cachorro quente + refrigerante");
      break;
      case 101:
      Console.WriteLine ("misto quente + refrigerante");
      break;
      case 102:
      Console.WriteLine ("misti frio + refrigerante");
      break;
      case 103:
      Console.WriteLine ("queijo quente + refrigerante");
      break;
      default:
      Console.WriteLine ("nao listado");
      break;
    }
    Console.ReadKey();
  }
}*/

/*class MainClass {
  public static void Main (string[] args) {
    double i=1, valor=0;
  
    for (i=1;i<=100;i++){
      if(i%2==0)
      valor+=i;
      else
      valor=valor;
    }
    Console.Write("o valor total dos pares e: "+valor);
 Console.ReadKey();
    
  }
}*/

/*class MainClass {
  public static void Main (string[] args) {
    double valor=0, mvalor=0;
    int escolha,contador=0;
    do{
      contador++;
      Console.WriteLine("informe o valor "+contador);
      valor =double.Parse (Console.ReadLine());
      mvalor+=valor;
      Console.WriteLine("Deseja continuar 1 para sim ");
      escolha =int.Parse (Console.ReadLine());
    }
    while(escolha==1);

    mvalor=mvalor/contador;
    Console.Write("O valor = "+mvalor);
 Console.ReadKey();
    
  }
}
*/
/*class MainClass {
  public static void Main (string[] args) {
    double idade,i=0, midade=0;
    for(i=1;i<=20;i++){
    Console.WriteLine ("informe sua altura "+i);
    idade =double.Parse(Console.ReadLine());
    midade+=idade;
    }
    midade=midade/20;
    Console.Write("A media e "+midade);
 Console.ReadKey();
    
  }
}*/

/*class MainClass {
  public static void Main (string[] args) {
   int  [] v= new int[15];
   int maior=0,menor=0,i=0;
   for (i=0;i<=15;i++){
     Console.WriteLine("informe vetor "+i);
     v[i]=int.Parse(Console.ReadLine());
     for(i=0;i<=15;i++){
       if (v[i]<menor)
       menor=v[i];
       else if (v[i]>maior)
       maior=v[i];
     }
   }
   Console.Write("O menor valor e: "+menor);
   Console.Write("O maior valor e: "+maior);
 Console.ReadKey();
    
  }
}*/

class MainClass {
  public static void Main (string[] args) {
   int [] v= new int[10];
   int i1=1, c=0, s=0, conta=0, contador=1;
  
   for (i1=0;i1<10;i1++){
     contador=i1+1;
       Console.WriteLine("informe a distancia da cidade "+i1);
       Console.WriteLine("ate "+contador);
       v [i1]=int.Parse(Console.ReadLine());
     
   }

       Console.WriteLine("informe a distancia da cidade de saida ");
       s=int.Parse(Console.ReadLine());
       Console.WriteLine("informe a distancia da cidade de chegada ");
       c=int.Parse(Console.ReadLine());

   for (i1=s;i1<c;i1++){
       conta+=v[i1];
     }
   
   Console.Write(" a distancia percorrida foi "+conta);
 Console.ReadKey();
    
  }
}*/


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
class MainClass {
  public static void mais (double a,double b,double c) {
    double delta;
    double bas1;
    delta=b-4*a*c;
    if (delta>=0){
      bas1=(-b+(Math.Sqrt(delta)))/2*a;
      Console.Write("baskara x1="+bas1);}
    else{
     Console.Write("nao e possilvo: ");}

   
}
public static void menos (double a,double b,double c) {
    double delta;
    double bas2;
    delta=b-4*a*c;
    if (delta>=0){
      bas2=(-b-(Math.Sqrt(delta)))/2*a;
      Console.Write("baskara x2="+bas2);}
    else{
    Console.Write("nao e possilvo: ");}

}
  public static void Main (string[] args) {
    double a,b,c;
    Console.WriteLine("informe a: ");
    a=double.Parse(Console.ReadLine());
    Console.WriteLine("informe b: ");
    b=double.Parse(Console.ReadLine());
    Console.WriteLine("informe c: ");
    c=double.Parse(Console.ReadLine());
     
     mais( a, b, c);
     menos(a, b, c);

    Console.ReadKey();

  }
}*/