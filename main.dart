import 'dart:io';
void main() {
	Cliente  cliente = Cliente();

  print ("Qual e o seu nome?");

  cliente.nome = stdin.readLineSync();

  print ("Qual e o seu email?");

  cliente.email = stdin.readLineSync();

  print ("Qual e o seu telfone?");
  
  cliente.telefone = int.parse(stdin.readLineSync());

  print ("Aceita receber emails promocionais?");

  int escolha = int.parse(stdin.readLineSync());
  
  if (escolha == 1){
  cliente.aceitaEmail = true;
  }
  else if (escolha == 0){
  cliente.aceitaEmail = false;
  }

print('----------------------------');
  print ("nome:");
  print (cliente.nome);
  print ("Tipo:");
  print (cliente.email);
  print ("Idade:");
  print (cliente.telefone);
  print ("emails promocionais:");
  print (cliente.aceitaEmail);
  print('----------------------------');


}

class Pessoa {

String nome;
String email; 
int telefone;


}
class Cliente extends Pessoa {

bool aceitaEmail;

}

