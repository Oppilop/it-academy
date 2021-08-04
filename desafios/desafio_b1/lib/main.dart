import 'package:flutter/material.dart';
import 'package:desafio_b1/counterapp.dart';

void main() {
  runApp(
    const MaterialApp(
      home: Scaffold(
        body: Center(
          child: CounterApp(),
        ),
      ),
    ),
  );
}