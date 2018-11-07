import sys
import os

def gerarSenha(nome, sobrenome):
    senha = "";
    nameFirst = nome[0];
    nameLast = nome[-1:];
    sobrenomeFirst = sobrenome[0];
    sobrenomeLast = sobrenome[-1:];
    return senha.join((nameFirst, nameLast, sobrenomeFirst, sobrenomeLast));

query_string = os.environ.get("QUERY_STRING")
args = query_string.split("&");
parameters = {};

for arg in args:
    temp = arg.split("=");
    parameters[temp[0]] = temp[1];

nome = str(parameters.get("nome"));
sobrenome = str(parameters.get("sobrenome"));

result = gerarSenha(nome, sobrenome);

print('<!DOCTYPE html>');
print('<html>');
print('    <head>');
print('        <meta charset="UTF-8">');
print('        <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">');
print('        <link href="/v1.css" type="text/css" rel="StyleSheet">');
print('        <script type="text/javascript" src="/v1.js"></script>');
print('        <title>V1</title>');
print('    </head>');
print('    <body>');
print('        <form name="gerarSenha" action="/cgi/v1.py" onsubmit="return validateForm()">');
print('        <p>');
print('            Mês 1: <input name="nome" type="text" value=""><br>');
print('            Mês 1: <input name="sobrenome" type="text" value=""><br>');
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