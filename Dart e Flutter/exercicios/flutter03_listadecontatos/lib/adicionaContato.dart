import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import "contato.dart";

class adicionaContato extends StatefulWidget {
 // const adicionaContato({Key? key}) : super(key: key);
  @override
  _adicionaContatoState createState() => _adicionaContatoState();
}

class _adicionaContatoState extends State<adicionaContato> {
  late String nome, idade, telefone, email;
  bool ehHomem = true;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("Tela de adição de contato"),),
      body: Column(
        children: [
          TextField( //nome
            decoration: InputDecoration(
              border: OutlineInputBorder(),
              labelText: "Nome"
            ),
            onChanged: (value) => nome = value,
          ),
          TextField( //idade
            decoration: InputDecoration(
                border: OutlineInputBorder(),
                labelText: "Idade"
            ),
            onChanged: (value) => idade = value,
          ),
          TextField( //telefone
            decoration: InputDecoration(
                border: OutlineInputBorder(),
                labelText: "Telefone"
            ),
            onChanged: (value) => telefone = value,
          ),
          TextField( //email
            decoration: InputDecoration(
                border: OutlineInputBorder(),
                labelText: "Email"
            ),
            onChanged: (value) => email = value,
          ),
          Row(
            children: [
              Text("É homem? "),
              Checkbox(
              value: ehHomem,
              onChanged: (value) => setState(() =>ehHomem = value!),
              )
            ],
          ),
        ],
      ),
        floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        onPressed: (){
          contato contatoAdicionado = contato(nome, int.parse(idade), telefone, email, ehHomem);
          Navigator.pop(context, contatoAdicionado);
        },
      ),
    );
  }
}
