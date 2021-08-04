import 'package:hellowiki/greeting.dart';
import 'package:flutter/material.dart';

class HelloWorldApp extends StatelessWidget {
  Greeting g = Greeting();

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Welcome to Flutter',
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Welcome to Flutter'),
        ),
        body: Center(
          child: Text(g.salutation, key: ValueKey('value'),
          ),
        ),
      ),
    );
  }
}