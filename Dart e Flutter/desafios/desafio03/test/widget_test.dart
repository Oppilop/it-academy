// This is a basic Flutter widget test.
//
// To perform an interaction with a widget in your test, use the WidgetTester
// utility that Flutter provides. For example, you can send tap and scroll
// gestures. You can also use WidgetTester to find child widgets in the widget
// tree, read text, and verify that the values of widget properties are correct.

import 'package:flutter/material.dart';
import 'package:flutter_test/flutter_test.dart';

import 'package:desafio03/main.dart';

void main() {
  testWidgets('Counter 1 increments smoke test', (WidgetTester tester) async {
    // Build our app and trigger a frame.
    await tester.pumpWidget(MyApp());

    //valores descritos na main
    const button1Key = Key('button1');
    const textButton1Key = Key('textButton1');

    //valores para comparaçao e analise do texto
    var button1Text = find.byKey(textButton1Key).evaluate().single.widget as Text;
    var button1 = find.byKey(button1Key);

    //teste que compra se o texto do contador começa em 0
    expect(button1Text.data,'0');

    //pressiona o botão 1 que acresenta 1 no contador 1
    await tester.tap(button1);
    await tester.pump();

    //analisa o texto do contador
    button1Text = find.byKey(textButton1Key).evaluate().single.widget as Text;

    //compara se o texto do contador 1 foi alterado para 1
    expect(button1Text.data, '1');

  });

  testWidgets('Counter 2 increments smoke test', (WidgetTester tester) async {
    //Build our app and trigger a frame.
    await tester.pumpWidget(MyApp());

    //valores descritos na main
    const button2Key = Key('button2');
    const textButton2Key = Key('textButton2');

    //valores para comparaçao e analise do texto
    var button2Text = find.byKey(textButton2Key).evaluate().single.widget as Text;
    var button2 = find.byKey(button2Key);

    //compara se o texto do contador do botão 2 começa em 0
    expect(button2Text.data, '0');

    //presssiona o botão 2 que acresenta 1 no contador 2
    await tester.tap(button2);
    await tester.pump();

    //analisa o texto do botao 2
    button2Text = find.byKey(textButton2Key).evaluate().single.widget as Text;

    //compara se o texto do contador 2 foi alterado para 1
    expect(button2Text.data, '1');
  });
}
