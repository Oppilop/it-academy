enum Gender {
  M,
  F,
}

class Person {
  Gender _gender;
  int _age;
  double _salary;

  Person(this._gender, this._age, this._salary);

  double get salary => _salary;

  set salary(double value) {
    _salary = value;
  }

  int get age => _age;

  set age(int value) {
    _age = value;
  }

  Gender get gender => _gender;

  set gender(Gender value) {
    _gender = value;
  }
  @override
  String toString() {
    return 'Person {Gender: $_gender, Age: $_age, Salary: ${_salary.toStringAsFixed(2)}}';
  }

}