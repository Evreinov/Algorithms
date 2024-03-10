   <div class="header">
      <h1 class="title">B. Чётные и нечётные числа</h1>
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
         <p>Представьте себе онлайн-игру для поездки в метро: игрок нажимает на кнопку, и на экране появляются три случайных числа. Если
            все три числа оказываются одной чётности, игрок выигрывает.
         </p></span><p>Напишите программу, которая по трём числам определяет, выиграл игрок или нет.</p>
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В первой строке записаны три случайных целых числа <span class="tex-math-text">a</span>, <span class="tex-math-text">b</span> и <span class="tex-math-text">c</span>. Числа не превосходят <span class="tex-math-text">10<sup>9</sup></span> по модулю.
         </p></span></div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Выведите «WIN», если игрок выиграл, и «FAIL» в противном случае.</p></span></div>
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
            <td><pre>1 2 -3
</pre></td>
            <td><pre>FAIL
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
            <td><pre>7 11 7
</pre></td>
            <td><pre>WIN
</pre></td>
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
            <td><pre>6 -2 0
</pre></td>
            <td><pre>WIN
</pre></td>
         </tr>
      </tbody>
   </table>
