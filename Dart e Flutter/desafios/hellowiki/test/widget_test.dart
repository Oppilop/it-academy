// This is a basic Flutter widget test.
//
// To perform an interaction with a widget in your test, use the WidgetTester
// utility that Flutter provides. For example, you can send tap and scroll
// gestures. You can also use WidgetTester to find child widgets in the widget
// tree, read text, and verify that the values of widget properties are correct.

import 'package:flutter/material.dart';
import 'package:flutter_test/flutter_test.dart';
import 'package:hellowiki/hellowordapp.dart';
import 'package:hellowiki/main.dart';

void main() {
  testWidgets('Counter increments smoke test', (WidgetTester tester) async {
    // Build our app and trigger a frame.
    await tester.pumpWidget(HelloWorldApp());

    //teste de interface
    var byKeyValue = find.byKey(ValueKey('value'));
    Text text = tester.firstWidget(byKeyValue) as Text;
    expect(text.data, 'Hello World!');

  });
}
