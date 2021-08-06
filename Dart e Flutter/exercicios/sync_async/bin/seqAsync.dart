import "dart:io";

Future<String> fctA() async{
  print("fct a in");
  await Future.delayed(Duration(seconds: 9));
  print("fct a out");
  return "fct A result";
}

Future<String> fctB() async{
  print("fct B in");
  await Future.delayed(Duration(seconds: 5));
  print("fct B out");
  return "fct B result";
}

Future<String> fctC() async{
  print("fct C in");
  await Future.delayed(Duration(seconds: 1));
  print("fct C out");
  return "fct C result";
}

Future<void> main() async{
  print("Inicio da main");

  /*fctA()
      .then( (e) => fctB() )
      .then( (e) => fctC() );
*/

  Future
    .wait([fctA(), fctB(), fctC()])
    .then( (List<String> lista) => lista.forEach((e) => print(e) ) );

  print("Fim da main");
}