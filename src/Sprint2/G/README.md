
<div class="problem-statement">
   <div class="header">
      <h1 class="title">G. Стек - MaxEffective</h1>
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
            <td rowspan="10">стандартный ввод или input.txt</td>
            <td rowspan="10">стандартный вывод или output.txt</td>
         </tr>
         <tr>
            <td>
               <nobr>Node.js 14.15.5</nobr>
            </td>
            <td>1.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Python 3.7.3</nobr>
            </td>
            <td>1.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Swift 5.8.1</nobr>
            </td>
            <td>2&nbsp;секунды</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>OpenJDK Java 11</nobr>
            </td>
            <td>1.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 6.0 + ASP)</nobr>
            </td>
            <td>1.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Golang 1.21.0</nobr>
            </td>
            <td>0.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Kotlin 1.8.0 (JRE 11)</nobr>
            </td>
            <td>1.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Python 3.11.4</nobr>
            </td>
            <td>1.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 5.0 + ASP)</nobr>
            </td>
            <td>1.5&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
      </tbody></table>
   </div>
   <h2></h2>
   <div class="legend"><span style="">
         <p>Реализуйте класс StackMaxEffective, поддерживающий операцию определения максимума среди элементов в стеке. Сложность операции
            должна быть <span class="tex-math-text">O(1)</span>. Для пустого стека операция должна возвращать None. При этом <span class="tex-monospace">push(x)</span> и <span class="tex-monospace">pop()</span> также должны выполняться за константное время. 
         </p></span></div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В первой строке записано одно число — количество команд, оно не превосходит <span class="tex-math-text">100000</span>. Далее идут команды по одной в строке. Команды могут быть следующих видов:
         </p></span><p>
         </p><ul>
            <li><span class="tex-monospace">push(x)</span> — добавить число <span class="tex-math-text">x</span> в стек. Число <span class="tex-math-text">x</span> не превышает <span class="tex-math-text">10<sup>5</sup></span>; 
            </li>
            <li><span class="tex-monospace">pop()</span> — удалить число с вершины стека; 
            </li>
            <li><span class="tex-monospace">get_max()</span> — напечатать максимальное число в стеке; 
            </li>
            <li><span class="tex-monospace">top()</span> — напечатать число с вершины стека; 
            </li>
         </ul>Если стек пуст, при вызове команды <span class="tex-monospace">get_max</span> нужно напечатать «None», для команды <span class="tex-monospace">pop</span> и <span class="tex-monospace">top</span> — «error». 
      <p></p>
   </div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Для каждой команды <span class="tex-monospace">get_max()</span> напечатайте результат её выполнения. Если стек пустой, для команды <span class="tex-monospace">get_max()</span> напечатайте «None». Если происходит удаление из пустого стека — напечатайте «error».
         </p></span></div>
   <h3>Пример 1</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_input i-bem button_js_inited" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать ввод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать ввод"></span></button></div></th>
            <th>Вывод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_output i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать вывод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать вывод"></span></button></div></th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>13
pop
pop
top
push 4
push -5
top
push 7
pop
pop
get_max
top
pop
get_max
</pre></td>
            <td><pre>error
error
error
-5
4
4
None</pre></td>
         </tr>
      </tbody>
   </table>
   <h3>Пример 2</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_input i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать ввод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать ввод"></span></button></div></th>
            <th>Вывод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_output i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать вывод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать вывод"></span></button></div></th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>10
get_max
push -6
pop
pop
get_max
push 2
get_max
pop
push -2
push -6
</pre></td>
            <td><pre>None
error
None
2
</pre></td>
         </tr>
      </tbody>
   </table>
</div>