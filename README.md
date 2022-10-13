<h1>DIO - Trilha .NET - Programação orientada a objetos</h1>
www.dio.me

<h2>Desafio de projeto</h2>
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

<h2>Contexto</h2>
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

<h2>Proposta</h2>
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. Você deve criar as suas classes de acordo com o diagrama abaixo:

![image](https://user-images.githubusercontent.com/48958294/195615061-b1a56ece-3952-4bb0-8203-f8bdaf6b5503.png)

<h2>Regras e validações</h2>
<ol>
  <li>A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.</li>
  <li>A classe Nokia e Iphone devem ser classes filhas de Smartphone.</li>
  <li>O método InstalarAplicativo deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.</li>
</ol>

<h2>Solução</h2>
Foram criadas implementações que estavam faltando e um novo método Apresentar().
