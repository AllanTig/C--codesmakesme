void main() {
Carro carro = Carro(2017, "CamaroDaMamae");
double velocidade = 0;

print('----------------------------');
print ('Ano:');
print(carro.ano);
print ('Modelo:');
print(carro.modelo);
print('----------------------------');

print('----------------------------');
print ('acelera');
print('----------------------------');
for(int i=0 ; i<5 ; i++){
carro.acelerar = 5;
print(carro.velocidade);
} 
print('----------------------------');
print ('frea');
print('----------------------------');
for(int i=0 ; i<2 ; i++){
carro.frear = 10;
print(carro.velocidade);
} 


}

class Carro {

int ano;
String modelo; 
double _velocidade = 0;

set acelerar(double acelera){
_velocidade += acelera;
}

set frear(double frea){
_velocidade -= frea;
}

double get velocidade => this._velocidade;

Carro(this.ano, this.modelo);
 
}