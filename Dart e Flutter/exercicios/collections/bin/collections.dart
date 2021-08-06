import 'Person.dart';

void main() {

  //instanciação de 4 pessoas
  var register = [
    Person(Gender.F, 18, 2000.00),
    Person(Gender.F, 40, 8000.00),
    Person(Gender.M, 18, 1500.00),
    Person(Gender.M, 30, 4000.00),
  ];

  //printa cada elemento da lista
  print('Register: ');
  register.forEach((element) => print(element));

  print('========================================');

  //validação de generos na lista
  //any retorna verdadeiro se ao menos um dos elementos satisfazem a condição a condição
  print('Woman?' + register.any((element) => element.gender == Gender.F).toString());
  print('Man?' + register.any((element) => element.gender == Gender.M).toString());
  //every retorna verdadeiro de todos os elementos satisfazem a condição
  print('Only Women?' + register.every((element) => element.gender == Gender.F).toString());
  print('Only Men?' + register.every((element) => element.gender == Gender.M).toString());



  //stoped here



  //média de idade das mulheres
  var listF = register.where((element) => element.gender == Gender.F).toList();
  var ageAvarF = listF.map((e) => e.age).fold(0, (int previousValue, element) => previousValue + element) / listF.length;
  print('Average age of women: $ageAvarF');

  //média de idade dos homens
  var listM = register.where((element) => element.gender == Gender.M).toList();
  var ageAvarM = listM.map((e) => e.age).fold(0, (int previousValue, element) => previousValue + element) / listM.length;
  print('Avarege age od men: $ageAvarM');

  print('========================================');

  //comparação do maior salario
  register.sort((a, b) => a.salary.compareTo(b.salary));
  var personHighestSalary = register.last;
  print("The person with the highest salary is ${personHighestSalary.gender.toString().split('.').last}, salary: ${personHighestSalary.salary.toStringAsFixed(2)}");

  //eliminando as mulheres abaixo da média
  var avarSalaryF = listF.map((e) => e.salary).fold(0.0, (double previousValue, element) => previousValue + element) / listF.length;
  register.removeWhere((element) => element.gender == Gender.F && element.salary < avarSalaryF );

  //eliminando os homens abaixo da média
  var avarSalaryM = listM.map((e) => e.salary).fold(0.0, (double previousValue, element) => previousValue + element) / listM.length;
  register.removeWhere((element) => element.gender == Gender.M && element.salary > avarSalaryM);

  //printando a lista restante
  print('========================================');
  print('Register: ');
  register.forEach((element) => print(element));
  
}