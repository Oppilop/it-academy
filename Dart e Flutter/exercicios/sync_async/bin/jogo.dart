import 'dart:io';

Future<String> games() async{
  sleep(Duration(seconds: 5));
  return "Jogando jogo B";
}

main() async{
  print("Jogando jogo A");
  var test = await games();
  print(test);
}