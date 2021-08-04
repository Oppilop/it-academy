
import 'dart:ui';
import 'package:desafio_b1/counter.dart';
import 'package:flutter_test/flutter_test.dart';

void main(){

  test('Teste de incremento', (){
    
    final counter = Counter();
    
    counter.increment();
    
    expect(counter.contador, 1);

  });


}