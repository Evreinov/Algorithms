
<div class="problem-statement">
   <div class="header">
      <h1 class="title">H. Скобочная последовательность</h1>
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
            <td>0.1&nbsp;секунда</td>
            <td>64Mb</td>
            <td rowspan="8">стандартный ввод или input.txt</td>
            <td rowspan="8">стандартный вывод или output.txt</td>
         </tr>
         <tr>
            <td>
               <nobr>Node.js 14.15.5</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Python 3.7.3</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>OpenJDK Java 11</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 6.0 + ASP)</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Kotlin 1.8.0 (JRE 11)</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Python 3.11.4</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 5.0 + ASP)</nobr>
            </td>
            <td>1&nbsp;секунда</td>
            <td>64Mb</td>
         </tr>
      </tbody></table>
   </div>
   <h2></h2>
   <div class="legend"><span style="">
         <p>Вот какую задачу Тимофей предложил на собеседовании одному из кандидатов. Если вы с ней ещё не сталкивались, то наверняка
            столкнётесь –— она довольно популярная.
         </p></span><p>Дана скобочная последовательность. Нужно определить, правильная ли она.</p>
      <p>Будем придерживаться такого определения:</p>
      <p>
         </p><ul>
            <li>пустая строка&nbsp;—– правильная скобочная последовательность; </li>
            <li>правильная скобочная последовательность, взятая в скобки одного типа,&nbsp;–— правильная скобочная последовательность; </li>
            <li>правильная скобочная последовательность с приписанной слева или справа правильной скобочной последовательностью&nbsp;—– тоже правильная. </li>
         </ul>На вход подаётся последовательность из скобок трёх видов: <span style="">[]</span>, (), {}.
      <p></p>
      <p>Напишите функцию <span class="tex-monospace">is_correct_bracket_seq</span>, которая принимает на вход скобочную последовательность и возвращает True, если последовательность правильная, а иначе False.
      </p>
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>На вход подаётся одна строка, содержащая скобочную последовательность. Скобки записаны подряд, без пробелов.</p></span></div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Выведите «True» или «False».</p></span></div>
   <h3>Пример 1</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_input i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать ввод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать ввод"></span></button></div></th>
            <th>Вывод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_output i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать вывод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать вывод"></span></button></div></th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>{[()]}
</pre></td>
            <td><pre>True
</pre></td>
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
            <td><pre>()
</pre></td>
            <td><pre>True
</pre></td>
         </tr>
      </tbody>
   </table>
</div>