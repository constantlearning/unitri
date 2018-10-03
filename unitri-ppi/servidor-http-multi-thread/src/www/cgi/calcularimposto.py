import sys
import os

def calcularImposto(ammount):
    imposto = 0.0;
    if ammount <= 2000.0:
        imposto = 0;
    elif ammount > 2000 and ammount <= 5000:
        imposto = (ammount * 20) / 100;
    elif ammount > 5000 and ammount <= 12000:
        imposto = (ammount * 30) / 100;
    else:
        imposto = (ammount * 45) / 100;
    return imposto;

query_string = os.environ.get("QUERY_STRING")
args = query_string.split("&");
parameters = {};

for arg in args:
    temp = arg.split("=");
    parameters[temp[0]] = temp[1];

firstMonth = int(parameters.get("firstMonth"));
secondMonth = int(parameters.get("secondMonth"));
thirdMonth = int(parameters.get("thirdMonth"));

firstTax = calcularImposto(firstMonth);
secondTax = calcularImposto(secondMonth);
thirdTax = calcularImposto(thirdMonth);

result = firstTax + secondTax + thirdTax;

print('<!DOCTYPE html>');
print('<html>');
print('    <head>');
print('        <meta charset="UTF-8">');
print('        <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">');
print('        <link href="/calcularimposto.css" type="text/css" rel="StyleSheet">');
print('        <script type="text/javascript" src="/calcularimposto.js"></script>');
print('        <title>Calculadora</title>');
print('    </head>');
print('    <body>');
print('        <form name=calcularImposto action="/cgi/calcularimposto.py" onsubmit="return validateForm()">');
print('        <p>');
print('            Mês 1: <input name="firstMonth" type="number" value=' + str(firstMonth) + '><br>');
print('            Mês 2: <input name="secondMonth" type="number" value=' + str(secondMonth) + '><br>');
print('            Mês 3: <input name="thirdMonth" type="number" value=' + str(thirdMonth) + '>');
print('        </p>');
print('        <p>');
print('            <input class="calcular" type="submit" value="Calcular">');
print('        </p>');
print('        <p>');
print('            Resultado: <input id="resultado" type="text" value=' + str(result) + ' disabled>');
print('        </p>');
print('        </form>');
print('    </body>');
print('</html>');