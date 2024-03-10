
<div class="problem-statement">
   <div class="header">
      <h1 class="title">L. Фибоначчи по модулю</h1>
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
            <td>0.7&nbsp;секунд</td>
            <td>64Mb</td>
            <td rowspan="6">стандартный ввод или input.txt</td>
            <td rowspan="6">стандартный вывод или output.txt</td>
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
               <nobr>OpenJDK Java 11</nobr>
            </td>
            <td>0.25&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 6.0 + ASP)</nobr>
            </td>
            <td>0.25&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>Kotlin 1.8.0 (JRE 11)</nobr>
            </td>
            <td>0.25&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
         <tr>
            <td>
               <nobr>C# (MS .NET 5.0 + ASP)</nobr>
            </td>
            <td>0.25&nbsp;секунд</td>
            <td>64Mb</td>
         </tr>
      </tbody></table>
   </div>
   <h2></h2>
   <div class="legend"><span style="">
         <p>У Тимофея было очень много стажёров, целых <span class="tex-math-text">N</span> (<span class="tex-math-text">0 ≤ N ≤ 10<sup>6</sup></span>) человек. Каждый стажёр хотел быть лучше своих предшественников, поэтому <span class="tex-math-text">i</span>-й стажёр делал столько коммитов, сколько делали два предыдущих стажёра в сумме. Два первых стажёра были менее инициативными
            — они сделали по одному коммиту.
         </p></span><p>Пусть <span class="tex-math-text">F<sub>i</sub></span> —– число коммитов, сделанных <span class="tex-math-text">i-</span>м стажёром (стажёры нумеруются с нуля). Первые два стажёра сделали по одному коммиту: <span class="tex-math-text">F<sub>0</sub>=F<sub>1</sub>=1</span>. Для всех&nbsp;<span class="tex-math-text">i≥ 2</span>&nbsp;выполнено&nbsp;<span class="tex-math-text">F<sub>i</sub>=F<sub>i−1</sub>+F<sub>i−2</sub></span>.
      </p>
      <p>Определите, сколько кода напишет следующий стажёр –— найдите последние <span class="tex-math-text">k</span> цифр числа <span class="tex-math-text">F<sub>n</sub></span>.
      </p>
      <p><br><span style="font-weight:bold;">Как найти <span class="tex-math-text">k</span> последних цифр</span></p>
      <p>Чтобы вычислить <span class="tex-math-text">k</span> последних цифр некоторого числа <span class="tex-math-text">x</span>, достаточно взять остаток от его деления на число <span class="tex-math-text">10<sup>k</sup></span>. Эта операция обозначается как <span class="tex-math-text">x  mod  10<sup>k</sup></span>. Узнайте, как записывается операция взятия остатка по модулю в вашем языке программирования.
      </p>
      <p>Также обратите внимание на возможное переполнение целочисленных типов, если в вашем языке такое случается.</p>
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В первой строке записаны через пробел два целых числа <span class="tex-math-text">n</span> (<span class="tex-math-text">0 ≤ n ≤ 10<sup>6</sup></span>) и <span class="tex-math-text">k</span> (<span class="tex-math-text">1 ≤ k ≤ 8</span>).
         </p></span></div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Выведите единственное число – последние <span class="tex-math-text">k</span> цифр числа <span class="tex-math-text">F<sub>n</sub></span>.
         </p></span><p>Если в искомом числе меньше <span class="tex-math-text">k</span> цифр, то выведите само число без ведущих нулей. 
      </p>
   </div>
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
            <td><pre>3 1</pre></td>
            <td><pre>3
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
            <td><pre>10 1</pre></td>
            <td><pre>9
</pre></td>
         </tr>
      </tbody>
   </table>
</div>