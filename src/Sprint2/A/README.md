
<div class="problem-statement">
   <div class="header">
      <h1 class="title">A. Мониторинг</h1>
      <table>
         <tbody><tr>
            <th>Язык</th>
            <th>Ограничение времени</th>
            <th>Ограничение памяти</th>
            <th>Ввод</th>
            <th>Вывод</th>
         </tr>
         <tr>
            <td width="1%">Все языки</td>
            <td>1&nbsp;секунда</td>
            <td>64Mb</td>
            <td rowspan="8">стандартный ввод или input.txt</td>
            <td rowspan="8">стандартный вывод или output.txt</td>
         </tr>
         <tr>
            <td>
               <nobr>Node.js 14.15.5</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>128Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Oracle Java 8</nobr>
            </td>
            <td>4&nbsp;секунды</td>
            <td>150Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>OpenJDK Java 11</nobr>
            </td>
            <td>4&nbsp;секунды</td>
            <td>150Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 6.0 + ASP)</nobr>
            </td>
            <td>4&nbsp;секунды</td>
            <td>150Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Kotlin 1.8.0 (JRE 11)</nobr>
            </td>
            <td>4&nbsp;секунды</td>
            <td>150Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 5.0 + ASP)</nobr>
            </td>
            <td>4&nbsp;секунды</td>
            <td>150Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Node JS 8.16</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>128Mb</td>
         </tr>
      </tbody></table>
   </div>
   <h2></h2>
   <div class="legend"><span style="">
         <p>Алла получила задание, связанное с мониторингом работы различных серверов. Требуется понять, сколько времени обрабатываются
            определённые запросы на конкретных серверах. Эту информацию нужно хранить в матрице, где номер столбца соответствуют идентификатору
            запроса, а номер строки — идентификатору сервера. Алла перепутала строки и столбцы местами. С каждым бывает. Помогите ей исправить
            баг.
         </p></span><p>Есть матрица размера <span class="tex-math-text">m × n</span>. Нужно написать функцию, которая её транспонирует.
      </p>
      <p>Транспонированная матрица получается из исходной заменой строк на столбцы. </p>
      <p>Например, для матрицы <span class="tex-math-text">А</span> (слева) транспонированной будет следующая матрица (справа):
      </p>
      <img src="img\image.png">
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В первой строке задано число <span class="tex-math-text">n</span> — количество строк матрицы.<br>Во второй строке задано <span class="tex-math-text">m</span> — число столбцов, <span class="tex-math-text">m</span> и <span class="tex-math-text">n</span> не превосходят <span class="tex-math-text">1000</span>. В следующих <span class="tex-math-text">n</span> строках задана матрица. Числа в ней не превосходят по модулю <span class="tex-math-text">1000</span>.
         </p></span></div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Напечатайте транспонированную матрицу в том же формате, который задан во входных данных. Каждая строка матрицы выводится на
            отдельной строке, элементы разделяются пробелами.
         </p></span></div>
   <h3>Пример 1</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод</th>
            <th>Вывод</th>
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
</pre></td>
            <td><pre>1 0 7 2
2 2 4 7
3 6 1 0
</pre></td>
         </tr>
      </tbody>
   </table>
   <h3>Пример 2</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод</th>
            <th>Вывод</th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>9
5
-7 -1 0 -4 -9
5 -1 2 2 9
3 1 -8 -1 -7
9 0 8 -8 -1
2 4 5 2 8
-7 10 0 -4 -8
-3 10 -7 10 3
1 6 -7 -5 9
-1 9 9 1 9
</pre></td>
            <td><pre>-7 5 3 9 2 -7 -3 1 -1
-1 -1 1 0 4 10 10 6 9
0 2 -8 8 5 0 -7 -7 9
-4 2 -1 -8 2 -4 10 -5 1
-9 9 -7 -1 8 -8 3 9 9
</pre></td>
         </tr>
      </tbody>
   </table>
</div>