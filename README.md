# <center>**ESTUDO DE M�TODOS LINQ C#**</center>

## <center><mark>OPERADORES SUPORTADOS</mark></center>

 ### M�todos de Proje��o e restri��o
 - ##### Select, SelectMany, Where
<br>

### M�todos  de ordena��o
- ##### OderBy, OrderByDescending, ThenByDescending, ThenBy, Reverse
<br>

### M�todos de Agrega��o
- ##### Average, Count, LongCount, Max, Min, Sum
<br>

### M�todos de Pagina��o
 - ##### First, FirstOrDefault, Last, LastOrDefault, Single,
 - ##### SingleOrDefault, Skip, SkipWhile, Take, TakeWhile, ElmentAt
<br>

### M�todos de Jun��o
- ##### Join, GroupJoin
<br>

---

> **Where** - Recebe os crit�rios que devem ser aplicados em sua consulta, 
interpreta e filtra os elementos com base nos crit�rios informados 
pelo desenvolvedor.

---

> **Count** - Capacidade de efetuar uma contagem de elementos 
em uma cole��o, podemos contar todos elementos ou informar um 
crit�rio que desejamos aplicar para o LINQ filtrar uma determinada 
regi�o dos dados em sua cole��o.

---

> **Sum** - Fornece a capacidade de efetuar c�lculo de soma sobre os elementos da cole��o, � limitado a tipos int, double, decimal, float e 
long

---

> **OrderBy** - Faz a ordena��o dos elementos em ordem ascendente (do menor para o maior) respeitando o tipo de objeto da cole��o.

---

> **OrderByDescending** - Este operador fornece a capacidade de devolver uma cole��o 
em uma ordem inversa.

---

> **Take** - Devolve uma nova cole��o de objetos com a quantidade de elementos informados, respeitando todos crit�rios 
de filtros aplicados a sua consulta.

---

> **TakeWhile** - Funciona como um filtro, ele faz itera��o na cole��o enquanto atender os crit�rios fornecidos, ou seja, quando a condi��o for falsa ele devolve os elementos 
da cole��o que atenderam os crit�rios. Diferente do **Where** que percorre todos elementos at� o fim.

---

> **First** - O m�todo de First() retorna o primeiro elemento da cole��o, aceita filros e sobrecarga. 
Quando a biblioteca for nula ele retorna uma exce��o do tipo InvalidOperationException. Bugando o programa.

---

> **FirstOrDefault** - Basicamente tem o mesmo comportamento do m�todo First, a �nica diferen�a � que n�o ser� gerada 
uma exce��o em caso da cole��o estar vazia ou n�o ser encontrado o elemento que 
atenda ao crit�rio passado na sobrecarga do m�todo.

---

> **Last e LastOrDefault** - O comportamento � o mesmo do First e FirstOrDefault, o que muda 
� apenas o retorno do elemento, retornando o �ltimo elemento da cole��o.

---

> **Skip** - O Skip � um recurso muito importante no LINQ fornecendo a 
capacidade de ler elementos a partir de uma determinada posi��o dentro da cole��o.

---

> **Concat** - Durante o processo de desenvolvimento de software, �s vezes 
nos deparamos com um cen�rio onde � necess�rio concatenar 2 cole��es.

---

> **ElementAt** - Para cen�rios onde precisamos recuperar um elemento pelo de 
�ndice, o LINQ fornece o m�todo ElementAt.

---

> **Single e SingleOrDefault** - Single e SingleOrDefault s�o recursos de pagina��o extremamente importantes, sendo �teis em alguns cen�rios. Os comportamentos s�o parecidos com o First e FirstOrDefault, que tem como objetivo retornar um �nico elemento de uma cole��o, mas o Single e 
SingleOrDefault � mais robusto, ele consegue validar se existe na 
cole��o mais de 1 (um) item que atende os mesmos crit�rios do filtro, se existir ele vai lan�ar uma exce��o, informando que a cole��o 
cont�m mais de um elemento.

---

> **Select** - Tem a capacidade de transformar os objetos de sua cole��o, em 
uma nova cole��o de objetos formatados, enriquecidos ou mais 
filtrados, ou seja, voc� pode criar novos tipos de objetos, fornecendo infinitas possibilidades de 
manipula��o de seus dados.

---

Livro utilizado para estudar:
[Livro C# para iniciante, Gratu�to](https://livrocsharp.com.br/wp-content/uploads/dae-uploads/CSharpIniciantes.pdf, "Livro c#"){:target="_blank"}