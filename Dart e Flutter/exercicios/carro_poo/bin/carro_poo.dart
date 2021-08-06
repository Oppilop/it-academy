import 'dart:io';

class Car {
  double _odometro = 0;
  double _statusTanque = 0; //foi preciso inicializar, estava dando erro de falta de inicialização
  double _capacidadeMax;
  static double _maxKmLitro = 15;

  Car(this._capacidadeMax);

  setOdometro(double odometro){
    this._odometro = odometro;
  }
  double getOdometro(){
    return this._odometro;
  }
  setStatusTanque(double statusTanque){
    this._statusTanque = statusTanque;
  }
  double getStatusTanque(){
    return this._statusTanque;
  }

  void abastecerCarro(double litros){
    var qtdDisponivel = _capacidadeMax - _statusTanque;
    print('Você pode abastecer até $qtdDisponivel litros de gasolina');

    if ((_statusTanque + litros) > _capacidadeMax ){
      print('Tanque cheio, você não pode abastecer.');
    }else {
     _statusTanque = _statusTanque + litros;
      print('Adicionado $litros ao tanque.');
    }
  }

  void deslocarCarro (double kmARodar){
    if(_statusTanque == 0){
      print('Você não tem gasolina para rodar, necessario abastecer.');
    }else {
      _statusTanque = _statusTanque - (kmARodar / 15);
      _odometro = _odometro + kmARodar;
      print('Você rodou $kmARodar e está com ${_statusTanque.toStringAsFixed(2)} de gasolina.');
    }
  }
}


void main(List<String> arguments) {

  Car car1 = Car(75);

  var opcao;

  do {
    var menu = '''
==============MENU===============
1 - Visualizar o Odometro
2 - Visualizar o estado do tanque
3 - Abastecer o tanque
4 - Deslocar-se
0 - Sair
=================================

Digite a sua opção: ''';
    print(menu);
    opcao = int.parse(stdin.readLineSync().toString());

    switch(opcao){
      case 1:
        print('=================================');
        print('Você tem ${car1.getOdometro()}Km rodados');
        print('=================================');
        break;
      case 2:
        print('=================================');
        print('Você tem ${car1.getStatusTanque().toStringAsFixed(2)} Litros');
        print('=================================');
        break;
      case 3:
        print('Digite a quantidade de litros que deseja abastecer: ');
        double litros = double.parse(stdin.readLineSync().toString());
        car1.abastecerCarro(litros);
        break;
      case 4:
        print('Digite a quantidade de Km que deseja dirigir: ');
        double kmARodar = double.parse(stdin.readLineSync().toString());
        car1.deslocarCarro(kmARodar);
        break;
      default:
        print('Opção invalida!');
    }
  } while (opcao != 0);






}
