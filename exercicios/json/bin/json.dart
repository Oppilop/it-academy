import "dart:convert";

main(){

  final favNum=5;
  final pi=3.141592;
  final chocolate=true;
  final name='Ana';
  final favoriteList = ['inter', 'desafios', 'cerveja', 18, 3.33, false, null];
  // final formData = {
  //   'favoriteNumber':favNum,
  //   'ValueOfPi':pi,
  //   'chocolate': chocolate,
  //   'sign': favoriteList,
  //   'anyThing':null
  // };


  var formData ={
    'nome':'Rodrigo',
    'idade':22,
    'telefone':555
  };

  //INFOS FORMULÁRIO EM JSON
  var dataInJson = json.encode(formData);
  print(dataInJson);

  print('===========================');

  //DECODIFICAR JSON EM UM MAP
  var dataBackJson = json.decode(dataInJson);
  print(dataBackJson);

  //ATRIBUIR VALORES DO MAP NO OBJETO DA CLASSE PESSOA
  Pessoa p1 = Pessoa();
  p1.nome = dataBackJson['nome'];
  p1.idade = dataBackJson['idade'];
  p1.telefone = dataBackJson['telefone'];

  print(p1.idade);
  p1.mudarIdade();
  print(p1.idade);
}

class Pessoa{
  var nome;
  var idade;
  var telefone;

  void mudarIdade(){
    this.idade ++;
  }
}





// print(json.encode(favNum));
// print("=-=-=-=-=-=-=-=-=-");
// print(json.encode(pi));
// print("=-=-=-=-=-=-=-=-=-");
// print(json.encode(chocolate));
// print("=-=-=-=-=-=-=-=-=-");
// print(json.encode(name));
// print("=-=-=-=-=-=-=-=-=-");
// print(json.encode(favoriteList));
// print("=-=-=-=-=-=-=-=-=-");
// print(json.encode(formData));
// print("=-=-=-=-=-=-=-=-=-");
