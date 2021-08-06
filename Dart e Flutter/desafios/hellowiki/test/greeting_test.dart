import 'package:hellowiki/greeting.dart';
import 'package:test/test.dart';

 void main() {
   test('Hello World Salutation', () {
     Greeting g = Greeting();
     expect(g.salutation, 'Hello World!');
   });
 }
