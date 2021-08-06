import "dart:io";

void leAquivo(String arquivo) async{
  print("abertura do arquivo");
  File meuArquivo= new File("./bin/$arquivo");
  /*
  var linhas = meuArquivo.readAsLinesSync();
  linhas.forEach((e) => print(e));
  */
  /*
  Future future = meuArquivo.readAsLines();

  future.then(
      (e) => e.forEach((b)=>print(b))
  );
  */
  var lista = await meuArquivo.readAsLines();
  print('Terminei o arquivo');
  lista.forEach((e) => print(e) );
}

main(){
  print("abrindo o arquivo");
  leAquivo('idades.txt');
  leAquivo('numeros.txt');
  leAquivo('nomes.txt');
  print("fim da leitura");
}