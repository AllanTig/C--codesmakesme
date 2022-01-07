import 'dart:io';
void main() {
	Pet pet = Pet();

  print ("Qual e o nome que voce deseja atribuir ao seu pet?");

  pet.setnome = stdin.readLineSync();

  print ("Qual e o tipo do seu pet?");

  pet.settipoDeAnimal = stdin.readLineSync();

  print ("Qual e a idade do seu pet?");
  
  pet.setidade = int.parse(stdin.readLineSync());
  print('----------------------------');
  print ("nome:");
  print (pet.getnome);
  print ("Tipo:");
  print(pet.gettipoDeAnimal);
  print ("Idade:");
  print (pet.getidade);
  print('----------------------------');
}

class Pet {

String _nome;
String _tipoDeAnimal; 
int _idade;

set setnome(String novoNome){
_nome = novoNome;
}

String get getnome => _nome;

set settipoDeAnimal(String novotipoDeAnimal){
_tipoDeAnimal = novotipoDeAnimal;
}

String get gettipoDeAnimal => _tipoDeAnimal;

set setidade(int novoidade){
_idade = novoidade;
}

int get getidade => _idade;

 
}