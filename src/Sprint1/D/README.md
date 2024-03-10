<div class="problem-statement">
   <div class="header">
      <h1 class="title">D. Хаотичность погоды</h1>
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
            <td>0.2&nbsp;секунды</td>
            <td>64Mb</td>
            <td rowspan="5">стандартный ввод или input.txt</td>
            <td rowspan="5">стандартный вывод или output.txt</td>
         </tr>
         <tr>
            <td>
               <nobr>OpenJDK Java 11</nobr>
            </td>
            <td>0.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 6.0 + ASP)</nobr>
            </td>
            <td>0.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Kotlin 1.8.0 (JRE 11)</nobr>
            </td>
            <td>0.6&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 5.0 + ASP)</nobr>
            </td>
            <td>0.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
      </tbody></table>
   </div>
   <h2></h2>
   <div class="legend"><span style="">
         <p>Метеорологическая служба вашего города решила исследовать погоду новым способом. 
            </p><ul>
               <li>Под <span style="font-weight:bold;">температурой воздуха</span> в конкретный день будем понимать максимальную температуру в этот день. 
               </li>
               <li>Под <span style="font-weight:bold;">хаотичностью погоды</span> за <span class="tex-math-text">n</span> дней служба понимает количество дней, в которые температура строго больше, чем в день до (если такой существует) и в день
                  после текущего (если такой существует). Например, если за 5 дней максимальная температура воздуха составляла <span class="tex-math-text">[1, 2, 5, 4, 8]</span> градусов, то хаотичность за этот период равна 2: в 3-й и 5-й дни выполнялись описанные условия. 
               </li>
            </ul>
         <p></p></span><p>Определите по ежедневным показаниям температуры хаотичность погоды за этот период.</p>
      <p>Заметим, что если число показаний <span class="tex-math-text">n=1</span>, то единственный день будет хаотичным.
      </p>
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В первой строке дано число <span class="tex-math-text">n</span> –— длина периода измерений в днях, <span class="tex-math-text">1 ≤ n≤ 10<sup>5</sup></span>. Во второй строке даны <span class="tex-math-text">n</span> целых чисел –— значения температуры в каждый из <span class="tex-math-text">n</span> дней. Значения температуры не превосходят <span class="tex-math-text">273</span> по модулю.
         </p></span></div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Выведите единственное число — хаотичность за данный период.</p></span></div>
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
            <td><pre>7
-1 -10 -8 0 2 0 5
</pre></td>
            <td><pre>3
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
            <td><pre>5
1 2 5 4 8
</pre></td>
            <td><pre>2
</pre></td>
         </tr>
      </tbody>
   </table>
</div>