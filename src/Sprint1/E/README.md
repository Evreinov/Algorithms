<div class="problem-statement">
   <div class="header">
      <h1 class="title">E. Самое длинное слово</h1>
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
         <p>Чтобы подготовиться к семинару, Гоше надо прочитать статью по эффективному менеджменту. Так как Гоша хочет спланировать день
            заранее, ему необходимо оценить сложность статьи. 
         </p></span><p>Он придумал такой метод оценки: берётся случайное предложение из текста и в нём ищется самое длинное слово. Его длина и будет
         условной сложностью статьи. 
      </p>
      <p>Помогите Гоше справиться с этой задачей.</p>
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В первой строке дана длина текста <span class="tex-math-text">L</span> (<span class="tex-math-text">1 ≤ L ≤ 10<sup>5</sup></span>). 
         </p></span><p>В следующей строке записан текст, состоящий из строчных латинских букв и пробелов. Слово —– последовательность букв, не разделённых пробелами. Пробелы могут стоять в самом начале строки и в самом её конце. Текст заканчивается
         переносом строки, этот символ не включается в число остальных <span class="tex-math-text">L</span> символов.
      </p>
   </div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>В первой строке выведите самое длинное слово. Во второй строке выведите его длину. Если подходящих слов несколько, выведите
            то, которое встречается раньше.
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
            <td><pre>19
i love segment tree
</pre></td>
            <td><pre>segment
7</pre></td>
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
            <td><pre>21
frog jumps from river
</pre></td>
            <td><pre>jumps
5</pre></td>
         </tr>
      </tbody>
   </table>
</div>
