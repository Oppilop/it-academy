import "dart:convert";
import "package:http/http.dart" as http;
import 'Address.dart';

Future<void> main(List<String> arguments) async {
  //var uri = Uri.parse("https://viacep.com.br/ws/90619900/json/");
  var uri = Uri.parse("https://viacep.com.br/ws/rs/porto%20alegre/silva/json/");

  var response = await http.get(uri);
  print(response.statusCode);

  /*
  Address a = new Address.fromJson(response.body);

  print(a.getValue("cep"));
  print(a.getValue("bairro"));
  */

  //var meuEnderecos = <Address>[];
  //List<Address?> meusEnderecos = List<Address?>.filled(1, null,growable: true);
  List<Address?> meusEnderecos = List<Address?>.empty(growable: true);

  var listaDeEnderecos = json.decode(response.body);

  for(Map<String, dynamic> item in listaDeEnderecos)
    meusEnderecos.add(new Address.fromJson(json.encode(item)));

  meusEnderecos.forEach((element) => print(element));
print('========================');
  print(response.body);
}
