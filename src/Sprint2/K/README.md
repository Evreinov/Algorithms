
<div class="problem-statement">
   <div class="header">
      <h1 class="title">K. Рекурсивные числа Фибоначчи</h1>
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
            <td rowspan="7">стандартный ввод или input.txt</td>
            <td rowspan="7">стандартный вывод или output.txt</td>
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
   <div class="legend"> У Тимофея было <!--l. 47--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-1-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-1" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-2" class="mjx-mrow"><span id="MJXc-Node-3" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.247em; padding-bottom: 0.308em;">n</span></span></span></span></span><script type="math/mml" id="MathJax-Element-1"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><mi>n</mi></math></script>
      (<!--l. 47--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-2-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-4" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-5" class="mjx-mrow"><span id="MJXc-Node-6" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">0</span></span><span id="MJXc-Node-7" class="mjx-mo MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.491em;">≤</span></span><span id="MJXc-Node-8" class="mjx-mi MJXc-space3"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.247em; padding-bottom: 0.308em;">n</span></span><span id="MJXc-Node-9" class="mjx-mo MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.491em;">≤</span></span><span id="MJXc-Node-10" class="mjx-mn MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">3</span></span><span id="MJXc-Node-11" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">2</span></span></span></span></span><script type="math/mml" id="MathJax-Element-2"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><mn>0</mn> <mo>≤</mo>
      <mi>n</mi> <mo>≤</mo> <mn>3</mn><mn>2</mn></math></script>) стажёров. Каждый стажёр хотел быть лучше своих предшественников, поэтому
      <!--l. 47--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-3-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-12" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-13" class="mjx-mrow"><span id="MJXc-Node-14" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em;">i</span></span></span></span></span><script type="math/mml" id="MathJax-Element-3"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><mi>i</mi></math></script>-й
      стажёр делал столько коммитов, сколько делали два предыдущих стажёра в сумме. Два первых стажёра были менее инициативными
      —– они сделали по одному коммиту. <!--l. 49-->
      <p style="text-indent: 0em;">Пусть <!--l. 49--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-4-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-15" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-16" class="mjx-mrow"><span id="MJXc-Node-17" class="mjx-msub"><span class="mjx-base" style="margin-right: -0.106em;"><span id="MJXc-Node-18" class="mjx-mrow"><span id="MJXc-Node-19" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em; padding-right: 0.106em;">F</span></span></span></span><span class="mjx-sub" style="font-size: 70.7%; vertical-align: -0.212em; padding-right: 0.071em;"><span id="MJXc-Node-20" class="mjx-mrow" style=""><span id="MJXc-Node-21" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em;">i</span></span></span></span></span></span></span></span><script type="math/mml" id="MathJax-Element-4"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><msub><mrow><mi>F</mi></mrow><mrow><mi>i</mi></mrow></msub></math></script>
      —– число коммитов, сделанных <!--l. 49--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-5-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-22" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-23" class="mjx-mrow"><span id="MJXc-Node-24" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em;">i</span></span></span></span></span><script type="math/mml" id="MathJax-Element-5"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><mi>i</mi></math></script>-м
      стажёром (стажёры нумеруются с нуля). Тогда выполняется следующее: <!--l. 49--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-6-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-25" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-26" class="mjx-mrow"><span id="MJXc-Node-27" class="mjx-msub"><span class="mjx-base" style="margin-right: -0.106em;"><span id="MJXc-Node-28" class="mjx-mrow"><span id="MJXc-Node-29" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em; padding-right: 0.106em;">F</span></span></span></span><span class="mjx-sub" style="font-size: 70.7%; vertical-align: -0.212em; padding-right: 0.071em;"><span id="MJXc-Node-30" class="mjx-mrow" style=""><span id="MJXc-Node-31" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">0</span></span></span></span></span><span id="MJXc-Node-32" class="mjx-mo MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.064em; padding-bottom: 0.308em;">=</span></span><span id="MJXc-Node-33" class="mjx-msub MJXc-space3"><span class="mjx-base" style="margin-right: -0.106em;"><span id="MJXc-Node-34" class="mjx-mrow"><span id="MJXc-Node-35" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em; padding-right: 0.106em;">F</span></span></span></span><span class="mjx-sub" style="font-size: 70.7%; vertical-align: -0.212em; padding-right: 0.071em;"><span id="MJXc-Node-36" class="mjx-mrow" style=""><span id="MJXc-Node-37" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">1</span></span></span></span></span><span id="MJXc-Node-38" class="mjx-mo MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.064em; padding-bottom: 0.308em;">=</span></span><span id="MJXc-Node-39" class="mjx-mn MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">1</span></span></span></span></span><script type="math/mml" id="MathJax-Element-6"><math display="inline" style="text-indent:
      0em;" xmlns="http://www.w3.org/1998/Math/MathML"><msub><mrow><mi>F</mi></mrow><mrow><mn>0</mn></mrow></msub> <mo>=</mo> <msub><mrow><mi>F</mi></mrow><mrow><mn>1</mn></mrow></msub>
      <mo>=</mo> <mn>1</mn></math></script>. Для всех&nbsp;<!--l. 49--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-7-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-40" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-41" class="mjx-mrow"><span id="MJXc-Node-42" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em;">i</span></span><span id="MJXc-Node-43" class="mjx-mo MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.491em;">≥</span></span><span id="MJXc-Node-44" class="mjx-mn MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">2</span></span></span></span></span><script type="math/mml" id="MathJax-Element-7"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><mi>i</mi>
      <mo>≥</mo> <mn>2</mn></math></script>&nbsp; выполнено&nbsp;<!--l. 49--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-8-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-45" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-46" class="mjx-mrow"><span id="MJXc-Node-47" class="mjx-msub"><span class="mjx-base" style="margin-right: -0.106em;"><span id="MJXc-Node-48" class="mjx-mrow"><span id="MJXc-Node-49" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em; padding-right: 0.106em;">F</span></span></span></span><span class="mjx-sub" style="font-size: 70.7%; vertical-align: -0.212em; padding-right: 0.071em;"><span id="MJXc-Node-50" class="mjx-mrow" style=""><span id="MJXc-Node-51" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em;">i</span></span></span></span></span><span id="MJXc-Node-52" class="mjx-mo MJXc-space3"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.064em; padding-bottom: 0.308em;">=</span></span><span id="MJXc-Node-53" class="mjx-msub MJXc-space3"><span class="mjx-base" style="margin-right: -0.106em;"><span id="MJXc-Node-54" class="mjx-mrow"><span id="MJXc-Node-55" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em; padding-right: 0.106em;">F</span></span></span></span><span class="mjx-sub" style="font-size: 70.7%; vertical-align: -0.212em; padding-right: 0.071em;"><span id="MJXc-Node-56" class="mjx-mrow" style=""><span id="MJXc-Node-57" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em;">i</span></span><span id="MJXc-Node-58" class="mjx-mo"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.308em; padding-bottom: 0.43em;">−</span></span><span id="MJXc-Node-59" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">1</span></span></span></span></span><span id="MJXc-Node-60" class="mjx-mo MJXc-space2"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.308em; padding-bottom: 0.43em;">+</span></span><span id="MJXc-Node-61" class="mjx-msub MJXc-space2"><span class="mjx-base" style="margin-right: -0.106em;"><span id="MJXc-Node-62" class="mjx-mrow"><span id="MJXc-Node-63" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em; padding-right: 0.106em;">F</span></span></span></span><span class="mjx-sub" style="font-size: 70.7%; vertical-align: -0.212em; padding-right: 0.071em;"><span id="MJXc-Node-64" class="mjx-mrow" style=""><span id="MJXc-Node-65" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em;">i</span></span><span id="MJXc-Node-66" class="mjx-mo"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.308em; padding-bottom: 0.43em;">−</span></span><span id="MJXc-Node-67" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">2</span></span></span></span></span></span></span></span><script type="math/mml" id="MathJax-Element-8"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><msub><mrow><mi>F</mi></mrow><mrow><mi>i</mi></mrow></msub>
      <mo>=</mo> <msub><mrow><mi>F</mi></mrow><mrow><mi>i</mi><mo>−</mo><mn>1</mn></mrow></msub> <mo>+</mo> <msub><mrow><mi>F</mi></mrow><mrow><mi>i</mi><mo>−</mo><mn>2</mn></mrow></msub></math></script>.
      <!--l. 51-->
      </p><p style="text-indent: 0em;">Определите, сколько кода напишет следующий стажёр –— найдите <!--l. 51--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-9-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-68" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-69" class="mjx-mrow"><span id="MJXc-Node-70" class="mjx-msub"><span class="mjx-base" style="margin-right: -0.106em;"><span id="MJXc-Node-71" class="mjx-mrow"><span id="MJXc-Node-72" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em; padding-right: 0.106em;">F</span></span></span></span><span class="mjx-sub" style="font-size: 70.7%; vertical-align: -0.212em; padding-right: 0.071em;"><span id="MJXc-Node-73" class="mjx-mrow" style=""><span id="MJXc-Node-74" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.247em; padding-bottom: 0.308em;">n</span></span></span></span></span></span></span></span><script type="math/mml" id="MathJax-Element-9"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><msub><mrow><mi>F</mi></mrow><mrow><mi>n</mi></mrow></msub></math></script>.
      <!--l. 53-->
      </p><p style="text-indent: 0em;">Решение должно быть реализовано рекурсивно. <br>
      </p>
      <p></p>
      <p></p>
      
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"> На вход подаётся <!--l. 56--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-10-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-75" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-76" class="mjx-mrow"><span id="MJXc-Node-77" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.247em; padding-bottom: 0.308em;">n</span></span></span></span></span><script type="math/mml" id="MathJax-Element-10"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><mi>n</mi></math></script>
      — целое число в диапазоне от <!--l. 56--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-11-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-78" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-79" class="mjx-mrow"><span id="MJXc-Node-80" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">0</span></span></span></span></span><script type="math/mml" id="MathJax-Element-11"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><mn>0</mn></math></script>
      до <!--l. 56--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-12-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-81" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-82" class="mjx-mrow"><span id="MJXc-Node-83" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">3</span></span><span id="MJXc-Node-84" class="mjx-mn"><span class="mjx-char MJXc-TeX-main-R" style="padding-top: 0.369em; padding-bottom: 0.369em;">2</span></span></span></span></span><script type="math/mml" id="MathJax-Element-12"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><mn>3</mn><mn>2</mn></math></script>.
      
   </div>
   <h2>Формат вывода</h2>
   <div class="output-specification"> Нужно вывести <!--l. 59--><span class="MathJax_Preview" style="color: inherit; display: none;"></span><span id="MathJax-Element-13-Frame" class="mjx-chtml MathJax_CHTML" tabindex="0" style="font-size: 117%;"><span id="MJXc-Node-85" class="mjx-math" style="text-indent: 0em;"><span id="MJXc-Node-86" class="mjx-mrow"><span id="MJXc-Node-87" class="mjx-msub"><span class="mjx-base" style="margin-right: -0.106em;"><span id="MJXc-Node-88" class="mjx-mrow"><span id="MJXc-Node-89" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.43em; padding-bottom: 0.308em; padding-right: 0.106em;">F</span></span></span></span><span class="mjx-sub" style="font-size: 70.7%; vertical-align: -0.212em; padding-right: 0.071em;"><span id="MJXc-Node-90" class="mjx-mrow" style=""><span id="MJXc-Node-91" class="mjx-mi"><span class="mjx-char MJXc-TeX-math-I" style="padding-top: 0.247em; padding-bottom: 0.308em;">n</span></span></span></span></span></span></span></span><script type="math/mml" id="MathJax-Element-13"><math display="inline" style="text-indent: 0em;" xmlns="http://www.w3.org/1998/Math/MathML"><msub><mrow><mi>F</mi></mrow><mrow><mi>n</mi></mrow></msub></math></script>.
      
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
            <td><pre>3</pre></td>
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
            <td><pre>0</pre></td>
            <td><pre>1
</pre></td>
         </tr>
      </tbody>
   </table>
</div>