import "dart:io";

main() {
  print("1. main being started");
  readNews().then((String e) => print(e));
  print("3. main being finished");
}


Future<String> readNews() async{
  print("2. Dart course started!!!");
   await Future.delayed(const Duration(seconds: 5));
  return "4. Course being placed...";
}