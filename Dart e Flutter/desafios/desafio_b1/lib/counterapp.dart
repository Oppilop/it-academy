import 'package:desafio_b1/counter.dart';
import 'package:flutter/material.dart';

class CounterApp extends StatefulWidget {

  const CounterApp({Key? key}) : super(key: key);

  @override
  _CounterAppState createState() => _CounterAppState();
}

class _CounterAppState extends State<CounterApp> {
  Counter counter = Counter();


  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.center,
      children: <Widget>[
        ElevatedButton(
          onPressed: counter.increment,
          child: const Text('Increment'),
        ),
        const SizedBox(width: 16),
        Text('Count: $counter'),
      ],
    );
  }
}
