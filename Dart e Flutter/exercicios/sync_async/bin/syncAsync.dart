import "dart:io";
import "dart:async";

Future<void> main() async{
  print("Fetching user order");
  print(await CreateOrderedMessage());
}

Future<String> CreateOrderedMessage() async{
  var order = await fetchUserOrder();
  return "Your order is: $order ";
}

Future<String> fetchUserOrder(){
  var valor = Future.delayed(
      Duration(seconds: 5),
      () => "large Latte"
  );
  return valor;
}