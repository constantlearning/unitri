import sys
import os

query_string = os.environ.get("QUERY_STRING")
args = query_string.split("&");
parameters = {};

for arg in args:
    temp = arg.split("=");
    parameters[temp[0]] = temp[1];

firstNumber = 0;
secondNumber = 0;
result = 0;

if parameters.get("operation") == 'soma':
    firstNumber = int(parameters.get("firstNumber"));
    secondNumber = int(parameters.get("secondNumber"));
    result = firstNumber + secondNumber;
else:
    firstNumber = int(parameters.get("firstNumber"));
    secondNumber = int(parameters.get("secondNumber"));
    result = firstNumber - secondNumber;

print('<!DOCTYPE html>');
print('<html>');
print('    <head>');
print('        <meta charset="UTF-8">');
print('        <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">');
print('        <title>Calculadora</title>');
print('    </head>');
print('    <body>');
print('        <form action="/cgi/calculadora.py">');
print('        <p>');
print('            Número1: <input name="firstNumber" type="text" value=' + str(firstNumber) + ' required><br>');
print('            Número2: <input name="secondNumber" type="text" value=' + str(secondNumber) + ' required>');
print('        </p>');
print('        <p>');
print('            <input type="radio" name="operation" id="adicao" value="soma" checked><label for="adicao">Adição</label><br>');
print('            <input type="radio" name="operation" id="subtracao" value="subtracao"><label for="subtracao">Subtração</label><br>');
print('            <input type="submit" value="Calcular">');
print('        </p>');
print('        <p>');
print('            Resultado: <input id="resultado" type="text" value=' + str(result) + ' disabled>');
print('        </p>');
print('        </form>');
print('    </body>');
print('</html>');