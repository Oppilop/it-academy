class Counter {

  int _contador = 0;


  int get contador => _contador;

  set contador(int value) {
    _contador = value;
  }

  void increment(){
   _contador++;
  }

}