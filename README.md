# Leitura de Sensores RS485 via USB Serial e publicação de dados na TagoIO

Esse app apenas para testar sensores RS485 sendo eles:
- Sensor de solo (temperatura, umidade e condutividade) : https://s.click.aliexpress.com/e/_DdYJZ0P
- Sensor de folha (temperatura e umidade) : https://s.click.aliexpress.com/e/_Dl4MnmF
- Sensor do ar (temperatura e umidade) : https://s.click.aliexpress.com/e/_DeBnASR

o App em si foi feito para uso pessoal, mas pode sua estrutrua pode ser usada para outras aplicações, por isso vou deixar este exemplo. Além disso, foi utilizado um conversor USB - Serial - RS485 deste link: https://s.click.aliexpress.com/e/_DFVF43D

Para usar o app, deve primeiro configurar cada sensor com os respectivos ID:
- 1
- 2
- 3

Além disso, mude sua porta serial no código Form1.cs, caso contrário retornará um erro no log. 
No caso de uso da TagoIO você deve descomentar a chamada de função da Tago e adicionar 2 tokens, para cada dispositivo. Quando essa função foi criada, foi apenas para testar os dois primeiros sensores (solo e folha), por isso a função só publica em dois dispositivos. Caso não saiba como adicionar um dispositivo e criar token, veja este tutorial: https://elcereza.com/integracao-https-para-tagoio/

