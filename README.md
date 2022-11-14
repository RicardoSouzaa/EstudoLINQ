# <center>**ESTUDO DE MÉTODOS LINQ C#**</center>

## <center><mark>OPERADORES SUPORTADOS</mark></center>

 ### Métodos de Projeção e restrição
 - ##### Select, SelectMany, Where
<br>

### Métodos  de ordenação
- ##### OderBy, OrderByDescending, ThenByDescending, ThenBy, Reverse
<br>

### Métodos de Agregação
- ##### Average, Count, LongCount, Max, Min, Sum
<br>

### Métodos de Paginação
 - ##### First, FirstOrDefault, Last, LastOrDefault, Single,
 - ##### SingleOrDefault, Skip, SkipWhile, Take, TakeWhile, ElmentAt
<br>

### Métodos de Junção
- ##### Join, GroupJoin
<br>

---

> **Where** - Recebe os critérios que devem ser aplicados em sua consulta, 
interpreta e filtra os elementos com base nos critérios informados 
pelo desenvolvedor.

---

> **Count** - Capacidade de efetuar uma contagem de elementos 
em uma coleção, podemos contar todos elementos ou informar um 
critério que desejamos aplicar para o LINQ filtrar uma determinada 
região dos dados em sua coleção.

---

> **Sum** - Fornece a capacidade de efetuar cálculo de soma sobre os elementos da coleção, é limitado a tipos int, double, decimal, float e 
long

---

> **OrderBy** - Faz a ordenação dos elementos em ordem ascendente (do menor para o maior) respeitando o tipo de objeto da coleção.

---

> **OrderByDescending** - Este operador fornece a capacidade de devolver uma coleção 
em uma ordem inversa.

---

> **Take** - Devolve uma nova coleção de objetos com a quantidade de elementos informados, respeitando todos critérios 
de filtros aplicados a sua consulta.

---

> **TakeWhile** - Funciona como um filtro, ele faz iteração na coleção enquanto atender os critérios fornecidos, ou seja, quando a condição for falsa ele devolve os elementos 
da coleção que atenderam os critérios. Diferente do **Where** que percorre todos elementos até o fim.

---

> **First** - O método de First() retorna o primeiro elemento da coleção, aceita filros e sobrecarga. 
Quando a biblioteca for nula ele retorna uma exceção do tipo InvalidOperationException. Bugando o programa.

---

> **FirstOrDefault** - Basicamente tem o mesmo comportamento do método First, a única diferença é que não será gerada 
uma exceção em caso da coleção estar vazia ou não ser encontrado o elemento que 
atenda ao critério passado na sobrecarga do método.

---

> **Last e LastOrDefault** - O comportamento é o mesmo do First e FirstOrDefault, o que muda 
é apenas o retorno do elemento, retornando o último elemento da coleção.

---

> **Skip** - O Skip é um recurso muito importante no LINQ fornecendo a 
capacidade de ler elementos a partir de uma determinada posição dentro da coleção.

---

> **Concat** - Durante o processo de desenvolvimento de software, às vezes 
nos deparamos com um cenário onde é necessário concatenar 2 coleções.

---

> **ElementAt** - Para cenários onde precisamos recuperar um elemento pelo de 
índice, o LINQ fornece o método ElementAt.

---

> **Single e SingleOrDefault** - Single e SingleOrDefault são recursos de paginação extremamente importantes, sendo úteis em alguns cenários. Os comportamentos são parecidos com o First e FirstOrDefault, que tem como objetivo retornar um único elemento de uma coleção, mas o Single e 
SingleOrDefault é mais robusto, ele consegue validar se existe na 
coleção mais de 1 (um) item que atende os mesmos critérios do filtro, se existir ele vai lançar uma exceção, informando que a coleção 
contém mais de um elemento.

---

> **Select** - Tem a capacidade de transformar os objetos de sua coleção, em 
uma nova coleção de objetos formatados, enriquecidos ou mais 
filtrados, ou seja, você pode criar novos tipos de objetos, fornecendo infinitas possibilidades de 
manipulação de seus dados.

---

Livro utilizado para estudar:
[Livro C# para iniciante, Gratuíto](https://livrocsharp.com.br/wp-content/uploads/dae-uploads/CSharpIniciantes.pdf, "Livro c#"){:target="_blank"}