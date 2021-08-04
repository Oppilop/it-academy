import 'dart:developer';

import 'Person.dart';

void main() {

  var register = [
    Person(Gender.F, 18, 2000.00),
    Person(Gender.F, 40, 8000.00),
    Person(Gender.M, 18, 1500.00),
    Person(Gender.M, 30, 4000.00),
  ];

  print('Register: ');
  register.forEach((element) => print(element));

  print('========================================');
  
  print('Woman?' + register.any((element) => element.gender == Gender.F).toString());
  print('Man?' + register.any((element) => element.gender == Gender.M).toString());
  print('Only Women?' + register.any((element) => element.gender == Gender.F).toString());
  print('Only Men?' + register.any((element) => element.gender == Gender.M).toString());

  var listF = register.where((element) => element.gender == Gender.F).toList();
  var ageAvar = listF.map((e) => e.age).fold(0, (int previousValue, element) => previousValue + element) / listF.length;
  print('Average age of women: $ageAvar');

  var listM = register.where((element) => element.gender == Gender.M).toList();

  
  
}