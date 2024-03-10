
<div class="problem-statement">
   <div class="header">
      <h1 class="title">J. Факторизация</h1>
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
            <td>0.052&nbsp;секунды</td>
            <td>64Mb</td>
            <td rowspan="8">стандартный ввод или input.txt</td>
            <td rowspan="8">стандартный вывод или output.txt</td>
         </tr>
         <tr>
            <td>
               <nobr>Node.js 14.15.5</nobr>
            </td>
            <td>0.4&nbsp;секунды</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Python 3.7.3</nobr>
            </td>
            <td>0.2&nbsp;секунды</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>OpenJDK Java 11</nobr>
            </td>
            <td>0.4&nbsp;секунды</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 6.0 + ASP)</nobr>
            </td>
            <td>0.4&nbsp;секунды</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Kotlin 1.8.0 (JRE 11)</nobr>
            </td>
            <td>0.4&nbsp;секунды</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Python 3.11.4</nobr>
            </td>
            <td>0.2&nbsp;секунды</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 5.0 + ASP)</nobr>
            </td>
            <td>0.4&nbsp;секунды</td>
            <td>64Mb</td>
         </tr>
      </tbody></table>
   </div>
   <h2></h2>
   <div class="legend"><span style="">
         <p>Основная теорема арифметики говорит: любое число раскладывается на произведение простых множителей единственным образом, с
            точностью до их перестановки. Например: 
            </p><ul>
               <li>Число <span class="tex-math-text">8</span> можно представить как <span class="tex-math-text">2 × 2 × 2</span>. 
               </li>
               <li>Число <span class="tex-math-text">50</span> –— как <span class="tex-math-text">2 × 5 × 5</span> (или <span class="tex-math-text">5 × 5 × 2</span>, или <span class="tex-math-text">5 × 2 × 5</span>). Три варианта отличаются лишь порядком следования множителей. 
               </li>
            </ul>
         <p></p></span><p>Разложение числа на простые множители называется факторизацией числа.</p>
      <p>Напишите программу, которая производит факторизацию переданного числа.</p>
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В единственной строке дано число <span class="tex-math-text">n</span> (<span class="tex-math-text">2 ≤ n ≤ 10<sup>9</sup></span>), которое нужно факторизовать.
         </p></span></div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Выведите в порядке неубывания простые множители, на которые раскладывается число <span class="tex-math-text">n</span>.
         </p></span></div>
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
            <td><pre>8
</pre></td>
            <td><pre>2 2 2</pre></td>
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
            <td><pre>13
</pre></td>
            <td><pre>13</pre></td>
         </tr>
      </tbody>
   </table>
   <h3>Пример 3</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод<div class="problem__copy-sample"></div></th>
            <th>Вывод<div class="problem__copy-sample"></div></th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>100
</pre></td>
            <td><pre>2 2 5 5</pre></td>
         </tr>
      </tbody>
   </table>
</div>