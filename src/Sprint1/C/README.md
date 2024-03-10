
   <div class="header">
      <h1 class="title">C. Соседи</h1>
      <table>
         <tbody><tr class="time-limit">
            <td class="property-title">Ограничение времени</td>
            <td>1&nbsp;секунда</td>
         </tr>
         <tr class="memory-limit">
            <td class="property-title">Ограничение памяти</td>
            <td>64Mb</td>
         </tr>
         <tr class="input-file">
            <td class="property-title">Ввод</td>
            <td colspan="1">стандартный ввод или input.txt</td>
         </tr>
         <tr class="output-file">
            <td class="property-title">Вывод</td>
            <td colspan="1">стандартный вывод или output.txt</td>
         </tr>
      </tbody></table>
   </div>
   <h2></h2>
   <div class="legend"><span style="">
         <p>Дана матрица. Нужно написать функцию, которая для элемента возвращает всех его соседей. Соседним считается элемент, находящийся
            от текущего на одну ячейку влево, вправо, вверх или вниз. Диагональные элементы соседними не считаются.
         </p></span><p>Например, в матрице <span class="tex-math-text">A</span> соседними элементами для <span class="tex-math-text">(0, 0)</span> будут <span class="tex-math-text">2</span> и <span class="tex-math-text">0</span>. А для <span class="tex-math-text">(2, 1)</span> –— <span class="tex-math-text">1, 2, 7, 7</span>.
      </p>
      <p><img class="user-image" src="/testsys/statement-image?imageId=1f83925f47077acfa8d1519afc9bb304ae19a6d23ce714b94255d3e799a91ee0"></p>
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В первой строке задано <span class="tex-math-text">n</span> — количество строк матрицы. Во второй — количество столбцов <span class="tex-math-text">m</span>. Числа <span class="tex-math-text">m</span> и <span class="tex-math-text">n</span> не превосходят <span class="tex-math-text">1000</span>. В следующих <span class="tex-math-text">n</span> строках задана матрица. Элементы матрицы — целые числа, по модулю не превосходящие <span class="tex-math-text">1000</span>. В последних двух строках записаны координаты элемента, соседей которого нужно найти. Индексация начинается с нуля.
         </p></span></div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Напечатайте нужные числа в возрастающем порядке через пробел.</p></span></div>
   <h3>Пример 1</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод<div class="problem__copy-sample"></div></th>
            <th>Вывод<div class="problem__copy-sample"></div></th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>4
3
1 2 3
0 2 6
7 4 1
2 7 0
3
0
</pre></td>
            <td><pre>7 7
</pre></td>
         </tr>
      </tbody>
   </table>
   <h3>Пример 2</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод<div class="problem__copy-sample"></div></th>
            <th>Вывод<div class="problem__copy-sample"></div></th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>4
3
1 2 3
0 2 6
7 4 1
2 7 0
0
0
</pre></td>
            <td><pre>0 2
</pre></td>
         </tr>
      </tbody>
   </table>
